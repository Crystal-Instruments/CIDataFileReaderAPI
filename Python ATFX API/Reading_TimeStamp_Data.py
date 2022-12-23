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
# This list should include .ts, which will be used to get the Stamp points signal
recordingList = Utility.GetListOfAllRecordings(recording)
tsRec = recordingList[1]
signal = tsRec.Signals[3]

# Return double[][] frame data, List<int> frame index for List<string> insertable strings
# put None in where out parameter is for python to read function correctly
frame, indexList, stringList = Utility.GetTSFrameData(None, None, signal,0)

# Convert System.double[][] to numpy array
frameX = np.fromiter(frame[0], float)
frameY = np.fromiter(frame[1], float)
    
print(frameX)
print(frameY)
print("index: ", indexList[0])
print("string: ", stringList[0])

frameCalc = Utility.GetTSDATatPoint(recording, 0, 100)

# Convert System.ulong[][] to numpy array
frameX = np.fromiter(frameCalc[0], float)
frameY = np.fromiter(frameCalc[1], float)
    
print(frameX)
print(frameY)