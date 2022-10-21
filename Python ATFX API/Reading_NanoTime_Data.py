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

    # Create DateTimeNano objects for local and UTC time zones
    createTimeLocal = DateTimeNano(recording.RecordingProperty.CreateTime, UInt32(nvhMeasurement.NanoSecondElapsed))
    createTimeUTC = DateTimeNano(Utils.GetUTCTime(recording.RecordingProperty.CreateTime, None), UInt32(nvhMeasurement.NanoSecondElapsed))

    print("Printing UTC")
    print(createTimeUTC.IsNanoTime)
    print(createTimeUTC.ms_us_ns)
    print(createTimeUTC.DayNanoSeconds)
    print(createTimeUTC.ToNanoString())

    ms = createTimeUTC.ms_us_ns / 1e6
    us = createTimeUTC.ms_us_ns / 1e3 % 1e3
    ns = createTimeUTC.ms_us_ns % 1e3
    # Custom Format: yyyy/mm/dd/hh/mm/ss/ms/us/ns
    print("{0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}/{8}".format(createTimeUTC.Year, createTimeUTC.Month, createTimeUTC.Day, createTimeUTC.Hour, createTimeUTC.Minute, createTimeUTC.Second, ms, us, ns))

    print("\nPrinting local")
    print(createTimeLocal.IsNanoTime)
    print(createTimeLocal.ms_us_ns)
    print(createTimeLocal.DayNanoSeconds)
    print(createTimeLocal.ToNanoString())

    ms = createTimeUTC.ms_us_ns / 1e6
    us = createTimeUTC.ms_us_ns / 1e3 % 1e3
    ns = createTimeUTC.ms_us_ns % 1e3
    # Custom Format: yyyy/mm/dd/hh/mm/ss/ms/us/ns
    print("{0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}/{8}".format(createTimeLocal.Year, createTimeLocal.Month, createTimeLocal.Day, createTimeLocal.Hour, createTimeLocal.Minute, createTimeLocal.Second, ms, us, ns))
