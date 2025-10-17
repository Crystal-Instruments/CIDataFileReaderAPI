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
parentPath = "C:\\MyStuff\\Github\\CIDataFileReaderAPI\\bin\\"

clr.AddReference(parentPath + "CI.ATFX.Reader.dll")
clr.AddReference(parentPath + "Common.dll")
clr.AddReference(parentPath + "PlatformWrapEx.dll")
clr.AddReference(parentPath + "System.Buffers.dll")
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

#---Functions
def ShowGPSInfo(recordingPath):
    recording = ODSNVHATFXMLRecording(recordingPath)
    
    if type(recording) is ODSNVHATFXMLRecording:
        nvhMeasurement = recording.Measurement 
        nvhEnvironment = recording.Environment
        bGPS = nvhMeasurement.GPSEnabled
        if bGPS:
            print("GPS Enabled: ", bGPS)
            print("Longitude: ", nvhMeasurement.Longitude)
            print("Latitude: ", nvhMeasurement.Latitude)
            print("Altitude: ", nvhMeasurement.Altitude)
            print("Nanoseconds Elapsed: ", nvhMeasurement.NanoSecondElapsed)
        
        if not String.IsNullOrEmpty(nvhEnvironment.TimeZoneString):
            print("Time Zone: ", nvhEnvironment.TimeZoneString)
        
        print("Created Time (Local): ", recording.RecordingProperty.CreateTime)
        print("Created Time (UTC): ", Utils.GetUTCTime(recording.RecordingProperty.CreateTime, None))
        dateTimeNano = DateTimeNano(recording.RecordingProperty.CreateTime, UInt32(nvhMeasurement.NanoSecondElapsed))
        print("DateTimeNano Object: ", dateTimeNano)        
    
def ShowFrameData(signal):
    frame = signal.GetFrame(0)

    # Convert System.Double[] to numpy array
    frameX = np.fromiter(frame[0], float)
    frameY = np.fromiter(frame[1], float)
    # print(frame[0].Length)
    
    # Print all data in frame or adjust the range to print a certain amount of data
    # for data in range(frame[0].Length):
    #     print("X: ", frame[0][data])
    #     print("Y: ", frame[1][data])

    # Print the first 3 pairs of the frame data
    print("X: ", frame[0][0])
    print("Y: ", frame[1][0])
    print("X: ", frame[0][1])
    print("Y: ", frame[1][1])
    print("X: ", frame[0][2])
    print("Y: ", frame[1][2])
    
    # Plot the signal frames
    plt.plot(frameX,frameY,'r', label=signal.Name)
    plt.xlabel(signal.Properties.xQuantity + " (" + signal.Properties.xUnit + ")")
    plt.ylabel(signal.Properties.yQuantity + " (" + signal.Properties.yUnit + ")")
    plt.title("Plot of the " + signal.Name)
    plt.legend()
    plt.show()
        
def ShowFrameDataSpectrumEU(signal, spectrum, engiUnit):
    frame = signal.GetFrame(0, spectrum, engiUnit)

    # Convert System.Double[] to numpy array
    frameX = np.fromiter(frame[0], float)
    frameY = np.fromiter(frame[1], float)
    # print(frame[0].Length)

    # Print all data in frame or adjust the range to print a certain amount of data
    # for data in range(frame[0].Length):
    #     print("X: ", frame[0][data])
    #     print("Y: ", frame[1][data])

    # Print the first 3 pairs of the frame data
    print("X: ", frame[0][0])
    print("Y: ", frame[1][0])
    print("X: ", frame[0][1])
    print("Y: ", frame[1][1])
    print("X: ", frame[0][2])
    print("Y: ", frame[1][2])
    
    # Plot the signal frames
    plt.plot(frameX,frameY,'r', label=signal.Name)
    plt.xlabel(signal.Properties.xQuantity + " (" + signal.Properties.xUnit + ")")
    plt.ylabel(signal.Properties.yQuantity + " (" + signal.Properties.yUnit + ")")
    plt.title("Plot of the " + signal.Name)
    plt.legend()
    plt.show()

#---Main Code
# Uncomment any prints and function calls to extract data from file
print("Running Main Code")
# recordingManager = RecordingManager

# Change file path here to whereever signal or recording files are
recordingPath = "C:\\Users\\Another CI\\Downloads\\signal files\\"
# Here are multiple strings for different files, change any of them to contain the file name and correctly
#  reference it in RecordingManager.Manager.OpenRecording
recordingPathRegular = recordingPath + "REC0157.atfx"
recordingPathTS = recordingPath + "{4499520}_REC_{20220419}(1).atfx"
recordingPathGPS = recordingPath + "REC0041.atfx"

#OpenRecording(string, out IRecording)
# openRecordSucceed is required for the OpenRecording as it is the returned boolean
# Make sure to reference the correct file string 
# testrecat = CommonRecording.CreateRecording(recordingPathRegular)
[openRecordSucceed, recording] = RecordingManager.Manager.OpenRecording(recordingPathRegular, None) 

#---Print Statements
# Comment or uncomment any print statements below 
print(recording)
print("\nRecording Properties\n")
for prop in Utility.GetListOfProperties(recording.RecordingProperty):
    print(prop[0], prop[1])

# Make sure to reference the correct file string 
#print("\nRecording GPS Properties\n")
#ShowGPSInfo(recordingPathTS)

print("\nSignal 1 Properties\n")
for prop in Utility.GetListOfProperties(recording.Signals[0].Properties):
    print(prop[0], prop[1])

print("\nSignal 1 Properties GeneratedTime\n")
for prop in Utility.GetListOfProperties(recording.Signals[0].Properties.GeneratedTime):
    print(prop[0], prop[1])

# print("\nRecording List\n")
# recordingList = Utility.GetListOfAllRecordings(recording)
# for record in recordingList:
#     print(record)

# print("\nODS Recording Properties\n")
# for prop in Utility.GetListOfProperties(recordingList[0].RecordingProperty):
#     print(prop[0], prop[1])

# Prints properties of a TimeStamp or GPS recording if the ATFX file references those files
# print("\nTS Recording Properties\n")
# for prop in Utility.GetListOfProperties(recordingList[1].RecordingProperty):
#     print(prop[0], prop[1])

print("\nSignal List\n")
signalList = Utility.GetListOfAllSignals(recording)
for signal in signalList:
    print(signal)
    
print("\nSignal Frame Data\n")
print(signalList[0])
ShowFrameData(signalList[0])    

# Prints frame data for the 5th signal in the list
# This can be any other signal, such as the 1st signal in the list
print(signalList[4])
ShowFrameData(signalList[4])    
print("-----------")
# GetFrameData with pass in parameters for spectrum and engineering unit
# The spectrum type and engineering unit can be changed by referencing the class library CHM file for valid values
# The Convert.ToInt32 is necessary for the the enum AccelerationUnitType to be read as a int instead of a string
ShowFrameDataSpectrumEU(signalList[4], _SpectrumScalingType.EUPeak, 
                                        AccelerationUnitEnumString.ArrayString[Convert.ToInt32(AccelerationUnitType.g)])
print("-----------")
ShowFrameDataSpectrumEU(signalList[4], _SpectrumScalingType.EUPeak, 
                                        AccelerationUnitEnumString.ArrayString[Convert.ToInt32(AccelerationUnitType.m_s_2)])