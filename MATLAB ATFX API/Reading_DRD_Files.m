% Copyright (C) 2023 by Crystal Instruments Corporation. All rights reserved.
% Load ATFX API dll
NET.addAssembly('D:\Common.dll');
NET.addAssembly('D:\CI.ATFX.Reader.dll');
NET.addAssembly('D:\PlatformWrapEx.dll');
NET.addAssembly('D:\System.Buffers.dll');

drdConverter = CI.ATFX.Reader.DRDConverter();

%Get the file content from directory containing DRD data files
drdFolder = 'C:\Users\KevinCheng\Downloads\1 to 5, 9 to 13, 17 to 20 high samp sine';
listing = dir(drdFolder);

% Extract the folder and name combined together from the struct dir(drdFolder);
fileNames = cell(1, numel(listing) - 2); % subtract 2 for '.' and '..'
for i = 3:numel(listing) % Start from 3 to skip '.' and '..'
    fileNames{i-2} = fullfile(listing(i).folder, listing(i).name);
end
stringFilePaths = string(fileNames); % Convert the combined folder/name array to string for C# code

% Combine DRD Files
drdOutputPath = drdConverter.CombineDRDFiles(stringFilePaths);
disp(drdOutputPath);
disp(drdConverter.ErrorMSG);

% Convert DRD Files
DRDConvertSucceed = drdConverter.ConvertDATATFXFileSimple(drdOutputPath);
disp(DRDConvertSucceed);
disp(drdConverter.ErrorMSG);

% Get a converted atfx file from the first folder
test = string(Item(drdOutputPath,0));
test2 = split(test, "\");
test3 = test2(length(test2));

atfxFilePath = test + '\' + test3 + '.atfx';
disp(atfxFilePath)
% array to contain boolean return and the actual out IRecording parameter
[openRecordSucceed, recording] = EDM.Recording.RecordingManager.Manager.OpenRecording(atfxFilePath);

% Use item function to get a time signal instance
sig = Item(recording.Signals,0);

% Display signal properties
disp(System.String.Format("Name:{0}",sig.Name));
disp(System.String.Format("X Unit:{0}",sig.Properties.xUnit));
disp(System.String.Format("Y Unit:{0}",sig.Properties.yUnit));

disp("display signal frame data");
% Get signal frame
frame = sig.GetFrame(0);
% Convert .Net double[][] array to matlab cell
matFrame = cell(frame);
% Long format, showing more decimal places
format long;
% Display the cell(frame) content
%celldisp(matFrame);
% Convert back to mat array
xVals = cell2mat(matFrame(1));
yValues = cell2mat(matFrame(2));

%plot the signal
plot(xVals,yValues,'r');
xlabel(string(sig.Properties.xQuantity)+" ("+string(sig.Properties.xUnit)+")");
ylabel(string(sig.Properties.yQuantity)+" ("+string(sig.Properties.yUnit)+")");
title("Plot of the "+string(sig.Name));
legend(string(sig.Name));