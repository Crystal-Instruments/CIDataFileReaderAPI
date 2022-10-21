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
recordingPathRegular = recordingPath + "{4499520}_REC_{20220419}(1).atfx"

#OpenRecording(string, out IRecording)
# openRecordSucceed is required for the OpenRecording as it is the returned boolean
# Make sure to reference the correct file string 
openRecordSucceed, recording = RecordingManager.Manager.OpenRecording(recordingPathRegular, None)

# Create ODS NVH ATFXML Recording object that contains NVH Measurement & NVH Environment using the file path
recording = ODSNVHATFXMLRecording(recordingPathRegular)
    
# If the above created object is ODSNVHATFXMLRecording, it should be able to get the NVH Measurement & NVH Environment and assigned them
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