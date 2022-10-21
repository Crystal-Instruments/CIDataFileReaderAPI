# -*- coding: utf-8 -*-
"""
Copyright (C) 2022 by Crystal Instruments Corporation.
All rights reserved
@author: KevinCheng
"""
#---Pythonnet clr import
from cProfile import label
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
recordingPath = "C:\\Users\\KevinCheng\\Documents\\EDM\\SQLServer20210318203822_test\\Sine23\\"
# ATFX file path, change contain the file name and correctly reference it in RecordingManager.Manager.OpenRecording
recordingPathRegular1 = recordingPath + "Run1 Aug 05, 2022 14-07-26\\SIG0000.atfx"
recordingPathRegular2 = recordingPath + "Run2 Aug 05, 2022 14-15-22\\SIG0001.atfx"

#OpenRecording(string, out IRecording)
# openRecordSucceed is required for the OpenRecording as it is the returned boolean
# Make sure to reference the correct file string 
openRecordSucceed, recording1 = RecordingManager.Manager.OpenRecording(recordingPathRegular1, None)
openRecordSucceed, recording2 = RecordingManager.Manager.OpenRecording(recordingPathRegular2, None)

# Get a list of signals
signalList1 = Utility.GetListOfAllSignals(recording1)
signalList2 = Utility.GetListOfAllSignals(recording2)

# Get the frame of a frequency signal depending on where it is in the list 
# The Convert.ToInt32 is necessary for the the enum AccelerationUnitType to be read as a int instead of a string
signal1 = signalList1[4]
frame1 = signal1.GetFrame(0, _SpectrumScalingType.EURms, AccelerationUnitEnumString.ArrayString[Convert.ToInt32(AccelerationUnitType.g)])
signal2 = signalList2[4]
frame2 = signal2.GetFrame(0, _SpectrumScalingType.EURms, AccelerationUnitEnumString.ArrayString[Convert.ToInt32(AccelerationUnitType.g)])

# Convert System.Double[] to numpy array
# and set any 0 in the frame to nan, useful for certain signals like sine spectrum
frame1X = np.fromiter(frame1[0], float)
frame1X[frame1X == 0] = np.nan
frame1Y = np.fromiter(frame1[1], float)
frame1Y[frame1Y == 0] = np.nan

frame2X = np.fromiter(frame2[0], float)
frame2X[frame2X == 0] = np.nan
frame2Y = np.fromiter(frame2[1], float)
frame2Y[frame2Y == 0] = np.nan

# Plot the signal frames
plt.plot(frame1X,frame1Y,'r', label="SIG0000 "+signal1.Name)
plt.plot(frame2X,frame2Y,'b', label="SIG0001 "+signal2.Name)
plt.xlabel(signal2.Properties.xQuantity + " (" + signal2.Properties.xUnit + ")")
plt.ylabel(signal2.Properties.yQuantity + " (" + signal2.Properties.yUnit + ")")
plt.title("Plot of the " + signal1.Name + " and " + signal2.Name)
plt.legend()
plt.show()