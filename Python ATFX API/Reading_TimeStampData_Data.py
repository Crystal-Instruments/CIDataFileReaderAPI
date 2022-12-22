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
recordingPath = "C:\\Users\\KevinCheng\\Downloads\\GRS Data Files\\Locked During Pretrigger\\"
# ATFX file path, change contain the file name and correctly reference it in RecordingManager.Manager.OpenRecording
recordingPathRegular = recordingPath + "REC0026.atfx"

#OpenRecording(string, out IRecording)
# openRecordSucceed is required for the OpenRecording as it is the returned boolean
# Make sure to reference the correct file string 
openRecordSucceed, recording = RecordingManager.Manager.OpenRecording(recordingPathRegular, None)

# Grab the list of recordings that the .atfx file references
# This list should include .tsdat, which will be used to get the Time Stamp Data signal
recordingList = Utility.GetListOfAllRecordings(recording)
tsdatRec = recordingList[2]
signal = tsdatRec.Signals[0]
frame = Utility.ReadTimeStampData(signal, 0, 100)

print("X: ", frame[0][0])
print("Y: ", frame[1][0])
print("X: ", frame[0][1])
print("Y: ", frame[1][1])
print("X: ", frame[0][2])
print("Y: ", frame[1][2])

# Return List<DateTimeNano> and out ulong[] frame index
# put None in where out parameter is for python to read function correctly
dateTimeNano, frameX = Utility.ReadTimeStampDataUTCFormat(None, signal, 0, 100)

print("dateTimeNano")
print(dateTimeNano[0])
print(dateTimeNano[1])
print(dateTimeNano[2])
print("frameX")
print(frameX[0])
print(frameX[1])
print(frameX[2])

# Convert System.Double[] to numpy array
frameX = np.fromiter(frame[0], float)
frameY = np.fromiter(frame[1], float)
    
# Plot the signal frames
plt.plot(frameX,frameY,'r', label="Time Stamp Data")
plt.xlabel("(Points)")
plt.ylabel("(Nanoseconds)")
plt.title("Plot of the Time Stamp Data")
plt.legend()
plt.show()