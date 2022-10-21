% Copyright (C) 2022 by Crystal Instruments Corporation. All rights reserved.
% Load common and reader dll
NET.addAssembly('C:\MyStuff\DevelopmentalVer\bin\AnyCPU\Debug\Utility\CIATFXReader\Common.dll');
NET.addAssembly('C:\MyStuff\DevelopmentalVer\bin\AnyCPU\Debug\Utility\CIATFXReader\CI.ATFX.Reader.dll');

% Create a atfx recording instance
atfxFilePath = 'C:\Users\KevinCheng\Downloads\gps test example\{4499520}_REC_{20220419}(1).atfx';
rec = EDM.Recording.ODSNVHATFXMLRecording(atfxFilePath);
% array to contain boolean return and the actual out IRecording parameter
[openRecordSucceed, recording] = EDM.Recording.RecordingManager.Manager.OpenRecording(atfxFilePath);

% Display gps properties
disp(System.String.Format("GPS Enable:{0}",rec.Measurement.GPSEnabled));
disp(System.String.Format("Longitude:{0}",rec.Measurement.Longitude));
disp(System.String.Format("Latitude:{0}",rec.Measurement.Latitude));
disp(System.String.Format("Altitude:{0}",rec.Measurement.Altitude));
disp(System.String.Format("Time zone:{0}",rec.Environment.TimeZoneString));
disp(System.String.Format("Created Time (Local):{0}",recording.RecordingProperty.CreateTime));
disp(System.String.Format("Created Time (UTC):{0}",Common.Utils.GetUTCTime(recording.RecordingProperty.CreateTime, [])));
disp(System.String.Format("Nanoseconds Elapsed:{0}",rec.Measurement.NanoSecondElapsed));
