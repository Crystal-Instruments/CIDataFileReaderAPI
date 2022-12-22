% Copyright (C) 2022 by Crystal Instruments Corporation. All rights reserved.
% Load common and reader dll
NET.addAssembly('C:\MyStuff\DevelopmentalVer\bin\AnyCPU\Debug\Utility\CIATFXReader\Common.dll');
NET.addAssembly('C:\MyStuff\DevelopmentalVer\bin\AnyCPU\Debug\Utility\CIATFXReader\CI.ATFX.Reader.dll');

% Create a atfx recording instance
atfxFilePath = 'C:\Users\KevinCheng\Documents\EDM\test\Random69\Run3 Jul 01, 2022 11-20-16\SIG0004.atfx';
rec = EDM.Recording.ODSNVHATFXMLRecording(atfxFilePath);
% array to contain boolean return and the actual out IRecording parameter
[openRecordSucceed, recording] = EDM.Recording.RecordingManager.Manager.OpenRecording(atfxFilePath);

% Use item function to get a time signal instance
sig = Item(recording.Signals,0);

% Display signal properties
disp(System.String.Format("Name:{0}",sig.Name));
disp(System.String.Format("X Unit:{0}",sig.Properties.xUnit));
disp(System.String.Format("Y Unit:{0}",sig.Properties.yUnit));
disp(System.String.Format("GPS Enable:{0}",rec.Measurement.GPSEnabled));
disp(System.String.Format("Longitude:{0}",rec.Measurement.Longitude));
disp(System.String.Format("Latitude:{0}",rec.Measurement.Latitude));
disp(System.String.Format("Altitude:{0}",rec.Measurement.Altitude));
disp(System.String.Format("Time zone:{0}",rec.Environment.TimeZoneString));
disp(System.String.Format("Created Time (Local):{0}",recording.RecordingProperty.CreateTime));
disp(System.String.Format("Created Time (UTC):{0}",Common.Utils.GetUTCTime(recording.RecordingProperty.CreateTime, [])));
disp(System.String.Format("Nanoseconds Elapsed:{0}",rec.Measurement.NanoSecondElapsed));

dateTimeNano = Common.DateTimeNano(recording.RecordingProperty.CreateTime, rec.Measurement.NanoSecondElapsed);
disp(System.String.Format("DateTimeNano Object:{0}",dateTimeNano));

disp("display signal frame data");
% Get signal frame
frameIndex = 0;
frame = sig.GetFrame(frameIndex);
disp(frame);
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

% Start another plot figure
figure();
% Use item function to get a frequency signal instance
sig2 = Item(recording.Signals,9);
disp(System.String.Format("Name:{0}",sig2.Name));

% Assign the engineering unit 
engiUnit = EDM.RecordingInterface.AccelerationUnitEnumString.ArrayString(System.Convert.ToInt32(EDM.RecordingInterface.AccelerationUnitType.g)+1);
disp(engiUnit);

% Get signal frame
frameIndex2 = 0;
frame2 = sig2.GetFrame(frameIndex2, Common.('_SpectrumScalingType').EURMS2, engiUnit);

% Convert .Net double[][] array to matlab cell
matFrame = cell(frame2);
% Long format, showing more decimal places
format long;
% Display the cell(frame) content
%celldisp(matFrame);
% Convert back to mat array
xVals = cell2mat(matFrame(1));
yValues = cell2mat(matFrame(2));

plot(xVals,yValues,'r');
xlabel(string(sig2.Properties.xQuantity)+" ("+string(sig2.Properties.xUnit)+")");
ylabel(string(sig2.Properties.yQuantity)+" ("+string(sig2.Properties.yUnit)+")");
title("Plot of the "+string(sig2.Name));
legend(string(sig2.Name));