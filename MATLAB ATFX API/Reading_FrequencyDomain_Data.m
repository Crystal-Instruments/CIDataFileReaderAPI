% Copyright (C) 2022 by Crystal Instruments Corporation. All rights reserved.
% Load common and reader dll
NET.addAssembly('C:\MyStuff\DevelopmentalVer\bin\AnyCPU\Debug\Utility\CIATFXReader\Common.dll');
NET.addAssembly('C:\MyStuff\DevelopmentalVer\bin\AnyCPU\Debug\Utility\CIATFXReader\CI.ATFX.Reader.dll');

% Create a atfx recording instance
atfxFilePath = 'C:\Users\KevinCheng\Documents\EDM\test\Random69\Run3 Jul 01, 2022 11-20-16\SIG0004.atfx';
% array to contain boolean return and the actual out IRecording parameter
[openRecordSucceed, recording] = EDM.Recording.RecordingManager.Manager.OpenRecording(atfxFilePath);

% Use item function to get a time signal instance
sig = Item(recording.Signals,9);

% Display signal properties
disp(System.String.Format("Name:{0}",sig.Name));
disp(System.String.Format("X Unit:{0}",sig.Properties.xUnit));
disp(System.String.Format("Y Unit:{0}",sig.Properties.yUnit));

% Assign the engineering unit 
engiUnit = EDM.RecordingInterface.AccelerationUnitEnumString.ArrayString(System.Convert.ToInt32(EDM.RecordingInterface.AccelerationUnitType.g)+1);
disp(engiUnit);

disp("display signal frame data");
% Get signal frame
frame = sig.GetFrame(0, Common.('_SpectrumScalingType').EURMS2, engiUnit);
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
