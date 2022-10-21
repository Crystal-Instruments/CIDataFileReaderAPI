# -*- coding: utf-8 -*-
"""
Copyright (C) 2022 by Crystal Instruments Corporation.
All rights reserved
@author: KevinCheng
"""
#---Pythonnet clr import
import clr
# Change file path here to whereever the DLL files are
parentPath = "C:\\MyStuff\\DevelopmentalVer\\bin\\AnyCPU\\Debug\\Utility\\CIATFXReader\\"

clr.AddReference(parentPath + "CI.ATFX.Reader.dll")
clr.AddReference(parentPath + "Common.dll")
clr.AddReference('System.Linq')
clr.AddReference('System.Collections')

import numpy as np
import matplotlib.pyplot as plt

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

# Change file path here to whereever signal or recording files are
recordingPath = "C:\\Users\\KevinCheng\\Downloads\\gps test example\\"
# ATFX file path, change contain the file name and correctly reference it in RecordingManager.Manager.OpenRecording
recordingPathRegular = recordingPath + "SIG0000.atfx"

#OpenRecording(string, out IRecording)
# openRecordSucceed is required for the OpenRecording as it is the returned boolean
# Make sure to reference the correct file string 
openRecordSucceed, recording = RecordingManager.Manager.OpenRecording(recordingPathRegular, None)

# Get a list of signals
signalList = Utility.GetListOfAllSignals(recording)

# Get the frame of a frequency signal depending on where it is in the list 
# The Convert.ToInt32 is necessary for the the enum AccelerationUnitType to be read as a int instead of a string
signal = signalList[5]
frame = signal.GetFrame(0, _SpectrumScalingType.EUPeak, AccelerationUnitEnumString.ArrayString[Convert.ToInt32(AccelerationUnitType.g)])

print("X: ", frame[0][0])
print("Y: ", frame[1][0])
print("X: ", frame[0][1])
print("Y: ", frame[1][1])
print("X: ", frame[0][2])
print("Y: ", frame[1][2])

# Convert System.Double[] to numpy array
frameX = np.fromiter(frame[0], float)
frameY = np.fromiter(frame[1], float)
    
# Plot the signal frames
plt.plot(frameX,frameY,'r', label=signal.Name)
plt.xlabel(signal.Properties.xQuantity + " (" + signal.Properties.xUnit + ")")
plt.ylabel(signal.Properties.yQuantity + " (" + signal.Properties.yUnit + ")")
plt.title("Plot of the " + signal.Name)
plt.legend()
plt.show()