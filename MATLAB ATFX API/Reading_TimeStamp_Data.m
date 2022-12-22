% Copyright (C) 2022 by Crystal Instruments Corporation. All rights reserved.
% Load common and reader dll
NET.addAssembly('C:\MyStuff\DevelopmentalVer\bin\AnyCPU\Debug\Utility\CIATFXReader\Common.dll');
NET.addAssembly('C:\MyStuff\DevelopmentalVer\bin\AnyCPU\Debug\Utility\CIATFXReader\CI.ATFX.Reader.dll');

% Create a atfx recording instance
atfxFilePath = 'C:\Users\KevinCheng\Downloads\GRS Data Files\Locked During Pretrigger\REC0026.atfx';
rec = EDM.Recording.ODSNVHATFXMLRecording(atfxFilePath);
% array to contain boolean return and the actual out IRecording parameter
[openRecordSucceed, recording] = EDM.Recording.RecordingManager.Manager.OpenRecording(atfxFilePath);

% Grab the list of recordings that the .atfx file references
% This list should include .ts, which will be used to get the Stamp points signal
recordingList = EDM.Utils.Utility.GetListOfAllRecordings(recording);
tsRec = Item(recordingList,1);
sig = Item(tsRec.Signals,3);

[frame, indexList, stringsList] = EDM.Utils.Utility.GetTSFrameData(sig,0);
disp("strings");
disp(indexList);
disp(stringsList);
disp("frame");
disp(frame);

disp("time stamp strings mat");
disp(indexList.Item(0));
disp(stringsList.Item(0));

% Convert .Net double[][] array to matlab cell
matFrame = cell(frame);
disp("time stamp frame mat");
disp(matFrame);

frameCalc = EDM.Utils.Utility.GetTSDATatPoint(recording, 0, 100);

% Convert .Net ulong[][] array to matlab cell
matFrame = cell(frameCalc);
disp("calc time stamp data matframe");
disp(matFrame);