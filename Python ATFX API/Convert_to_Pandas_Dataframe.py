# -*- coding: utf-8 -*-
"""
Copyright (C) 2022 by Crystal Instruments Corporation.
All rights reserved
@author: KevinCheng
"""
#---Pythonnet clr import
from tokenize import Name
import clr
# Change file path here to whereever the DLL files are
parentPath = "C:\\MyStuff\\DevelopmentalVer\\bin\\AnyCPU\\Debug\\Utility\\CIATFXReader\\"

clr.AddReference(parentPath + "CI.ATFX.Reader.dll")
clr.AddReference(parentPath + "Common.dll")
clr.AddReference('System.Linq')
clr.AddReference('System.Collections')

import numpy as np
import pandas as pd

#---C# .NET imports & dll imports
from EDM.Recording import *
from EDM.RecordingInterface import *
from ASAM.ODS.NVH import *
from EDM.Utils import *
from Common import *
from Common import _SpectrumScalingType
from Common.Spider import *
from System import *
from System.Diagnostics import *
from System.Reflection import *
from System.Text import *
from System.IO import *

# Function for converting signals from an ATFX file into a pandas dataframe in a specific order below:
# Frequency, profile(f), control(f), HighAbort, HighAlarm, LowAlarm, LowAbort, APS / Spectrum (Table), APS / Spectrum (Ch#)
def ConvertAllSignalsToDataframe(atfxFilePath):
    #OpenRecording(string, out IRecording)
    # openRecordSucceed is required for the OpenRecording as it is the returned boolean
    # Make sure to reference the correct file string 
    openRecordSucceed, recording1 = RecordingManager.Manager.OpenRecording(atfxFilePath, None)

    # Get a list of signals
    signalList = Utility.GetListOfAllSignals(recording1)

    PREFIX = 'EoT '
    df = pd.DataFrame()

    # Find the specific signal in the signal list
    for signal in signalList:
        # Skip over any signals with drive or Block in its name
        if 'drive' in signal.Name or 'Block' in signal.Name:
            continue
        # Skip any other signals that doesn't have the below strings in its name, such as H(f)
        if( 'Spectrum' not in signal.Name and 'APS' not in signal.Name and 
            'profile' not in signal.Name and 'control' not in signal.Name and 
            'HighAbort' not in signal.Name and 'HighAlarm' not in signal.Name and 
            'LowAlarm' not in signal.Name and 'LowAbort' not in signal.Name):
            continue

        # Get the signal frame and if the ATFX file is from a Swept Sine test then use (EU)RMS
        # and get the default engineering unit by passing in a empty string
        if recording1.RecordingProperty.MeasurementType == MeasurementConfigType.VCS_Sine:
            signalFrame = signal.GetFrame(0, _SpectrumScalingType.EURms, '')
        else:
            signalFrame = signal.GetFrame(0, _SpectrumScalingType.EURMS2, '')

        # if the signal is profile(f), get the Frequency column and profile(f) column and assign them at the beginning of the dataframe
        # There are chances where other signals such as control(f) went before profile(f) in the signalList order
        if 'profile' in signal.Name:
            frequencyFrame      = np.fromiter(signalFrame[0], float)
            profileFrameY       = np.fromiter(signalFrame[1], float)
            df.insert(0, PREFIX + "Frequency", frequencyFrame)
            df.insert(1, PREFIX + signal.name, profileFrameY)
            
        # Every other signal gets appended to the dataframe normally
        signalFrameY = np.fromiter(signalFrame[1], float)
        df[PREFIX + signal.name] = signalFrameY

    # Set up the proper order by getting the specific columns of the first dataframe and assigning to a new dataframe
    df2 = df[[PREFIX + 'Frequency', PREFIX + 'profile(f)', PREFIX + 'control(f)',
              PREFIX + 'HighAbort(f)', PREFIX + 'HighAlarm(f)', PREFIX + 'LowAlarm(f)',
              PREFIX + 'LowAbort(f)']]
    # Then drop the above columns to concat the first and second dataframe 
    df.drop(columns=[PREFIX + 'Frequency', PREFIX + 'profile(f)', PREFIX + 'control(f)',
              PREFIX + 'HighAbort(f)', PREFIX + 'HighAlarm(f)', PREFIX + 'LowAlarm(f)',
              PREFIX + 'LowAbort(f)'])
    df3 = pd.concat([df2, df])
    df3 = df3.apply(pd.to_numeric, errors='coerce')
    df3 = df3.dropna()
    return df3
    
    
# Change file path here to whereever signal or recording files are
recordingPath = "C:\\Users\\KevinCheng\\Documents\\EDM\\importapssignals2\\Sine6\\"
# ATFX file path, change contain the file name and correctly reference it in RecordingManager.Manager.OpenRecording
recordingPathRegular = recordingPath + "Run2 Aug 19, 2022 12-22-48\\SIG0001.atfx"
dataframe = ConvertAllSignalsToDataframe(recordingPathRegular)
print(dataframe.columns)
print(dataframe)