% Copyright (C) 2022 by Crystal Instruments Corporation. All rights reserved.
% Load common and reader dll
NET.addAssembly('C:\MyStuff\DevelopmentalVer\bin\AnyCPU\Debug\Utility\CIATFXReader\Common.dll');
NET.addAssembly('C:\MyStuff\DevelopmentalVer\bin\AnyCPU\Debug\Utility\CIATFXReader\CI.ATFX.Reader.dll');

% Create a atfx recording instance
atfxFilePath = 'C:\Users\KevinCheng\Downloads\GRS Data Files\REC0008.atfx';
rec = EDM.Recording.ODSNVHATFXMLRecording(atfxFilePath);
% array to contain boolean return and the actual out IRecording parameter
[openRecordSucceed, recording] = EDM.Recording.RecordingManager.Manager.OpenRecording(atfxFilePath);

% Grab the list of recordings that the .atfx file references
% This list should include .tsdat, which will be used to get the Time Stamp Data signal
recordingList = EDM.Utils.Utility.GetListOfAllRecordings(recording);
tsdatRec = Item(recordingList,2);
sig = Item(tsdatRec.Signals,0);

frame = EDM.Utils.Utility.ReadTimeStampData(sig, 0, 100);

% Convert .Net ulong[][] array to matlab cell
matFrame = cell(frame);
disp("frame");
disp(matFrame);

[dateTimeNano, frameX] = EDM.Utils.Utility.ReadTimeStampDataUTCFormat(sig, 0, 100);

disp("dateTimeNano");
disp(dateTimeNano);
disp(dateTimeNano.Item(0));
disp("frameX");
disp(frameX);
matFrameIndex = uint64(frameX);
disp(matFrameIndex);