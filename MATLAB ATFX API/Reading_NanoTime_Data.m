% Copyright (C) 2022 by Crystal Instruments Corporation. All rights reserved.
% Load common and reader dll
NET.addAssembly('C:\MyStuff\DevelopmentalVer\bin\AnyCPU\Debug\Utility\CIATFXReader\Common.dll');
NET.addAssembly('C:\MyStuff\DevelopmentalVer\bin\AnyCPU\Debug\Utility\CIATFXReader\CI.ATFX.Reader.dll');

% Create a atfx recording instance
atfxFilePath = 'C:\Users\KevinCheng\Downloads\gps test example\{4499520}_REC_{20220419}(1).atfx';
rec = EDM.Recording.ODSNVHATFXMLRecording(atfxFilePath);
% array to contain boolean return and the actual out IRecording parameter
[openRecordSucceed, recording] = EDM.Recording.RecordingManager.Manager.OpenRecording(atfxFilePath);

% Assign the NVH Measurement and NVH Environment
nvhMeasurement = rec.Measurement;

% Create the DateTimeNano in UTC and or Local
createTimeLocal = Common.DateTimeNano(recording.RecordingProperty.CreateTime, nvhMeasurement.NanoSecondElapsed);
createTimeUTC = Common.DateTimeNano(Common.Utils.GetUTCTime(recording.RecordingProperty.CreateTime, []), nvhMeasurement.NanoSecondElapsed);

% Display nano type properties
disp('Printing UTC');
disp(createTimeUTC.IsNanoTime);
disp(createTimeUTC.ms_us_ns);
disp(createTimeUTC.DayNanoSeconds);
disp(createTimeUTC.ToNanoString());

ms = (createTimeUTC.ms_us_ns - rem(createTimeUTC.ms_us_ns,  1e6)) / 1e6;
us = rem(createTimeUTC.ms_us_ns / 1e3, 1e3);
ns = rem(createTimeUTC.ms_us_ns, 1e3);

% Custom Format: yyyy/mm/dd/hh/mm/ss/ms/us/ns
str = sprintf('%d/%d/%d/%d/%d/%d/%d/%d/%d', createTimeUTC.Year, createTimeUTC.Month, createTimeUTC.Day, createTimeUTC.Hour, createTimeUTC.Minute, createTimeUTC.Second, ms, us, ns);
disp(str);

% Display nano type properties
disp('Printing local');
disp(createTimeLocal.IsNanoTime);
disp(createTimeLocal.ms_us_ns);
disp(createTimeLocal.DayNanoSeconds);
disp(createTimeLocal.ToNanoString());

ms = (createTimeLocal.ms_us_ns - rem(createTimeLocal.ms_us_ns,  1e6)) / 1e6;
us = rem(createTimeLocal.ms_us_ns / 1e3, 1e3);
ns = rem(createTimeLocal.ms_us_ns, 1e3);

% Custom Format: yyyy/mm/dd/hh/mm/ss/ms/us/ns
str = sprintf('%d/%d/%d/%d/%d/%d/%d/%d/%d', createTimeLocal.Year, createTimeLocal.Month, createTimeLocal.Day, createTimeLocal.Hour, createTimeLocal.Minute, createTimeLocal.Second, ms, us, ns);
disp(str);