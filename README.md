# CIDataFileReaderAPI
![](https://github.com/Crystal-Instruments/CIDataFileReaderAPI/blob/main/images/ATFXAPIDiagram.png)

The Crystal Instruments (CI) ATFX ODS Signal Reader Application Programming Interface (API) consists of 2 Windows Dynamic-Linked Libraries (DLL) providing third-party applications an interface to access the signal data stored in the ASAM Transport Format XML (ATFX) files. 

ATFX files are formatted according to the Association for Standardization of Automation and Measuring Systems (ASAM) Open Data Services (ODS) standardization. This is a standard dedicated for storing vibration data and its different forms. CI software natively stores its data using the ATFX format, for both signals and recordings. 

For details about the ATFX ODS format please refer to the official website:

https://www.asam.net/standards/detail/ods/wiki/ 

The .atfx files are xml-based files which store the signal data along with all the attributes of the signal data including recording properties and time created, length of recording, number of channels, channel parameters (e.g., input channel sensor and sensitivities), geographic coordinates, sampling rate, high pass filter, etc. 

The .atfx files contain a reference to a .dat file that are well-defined for storing both raw time data as well as processed spectral data, calculated from methods including Fourier Transform, Frequency Response Functions, Cross-Power Spectrum, Octave Spectrum, etc. 

There are 2 additional file types that the .aftx file references that contain raw data: .ts and .gps. The .ts file is a TimeStamp recording that contains an accurate measure of when a recording was saved with accuracy down to nanoseconds. The .gps file is a GPS recording that contains locational data of where a recording was saved (e.g., latitude, longitude, altitude).

![](https://github.com/Crystal-Instruments/CIDataFileReaderAPI/blob/main/images/ATFXAPIOpenFileExample.png)

The CI Data File Reader API provides end-users with a streamlined file reading and browsing library to decode ATFX, TS and GPS files. Users can integrate the API with their own custom developed application. Currently, we support Windows-based programs, ideally written in C#. The same API also supports Python, MatLab and LabView. 

The API offer direct calls to the ASAM ODS model classes and objects used to store data saved in the ATFX file, such as calling the recording NVHMeasurement and NVHEnvironment to read the DateTime with nano seconds elapsed. 

The API also provides a Utility class that has functions to return data from the ATFX file without the user needing to understand the complexity of the ASAM ODS model classes. Such as the Utility GetListOfAllSignals that return a list of signals that a ATFX file contains or the Utility GetChannelTable that return a 2D list of strings, where each list is an input channel row. 

It is also possible to read any of the signals, time or frequency, in other engineering units (EU), such as Acceleration m/s2 to g. As well as reading frequency domain signals in other spectrum types, such as EUrms to EUPeak. All done by the signal function GetFrame where users can pass in parameters to return a converted signal frame data saved in the ATFX file.

When the ATFX API read the ATFX file, there may be some differences in the signal frame data, this is due to some display related parameters such as spectrum type not being saved into the ATFX file. By default, the spectrum type is EUrms2. Engineering units are saved into the ATFX file and should be the the default EU when reading the signal frame.

For more detailed information regarding the CI ATFX Reader API, please refer the CI ATFX Reader API Documentation that can be downloaded via the CI site:

https://www.crystalinstruments.com/basics-of-test-and-measurement 

https://www.crystalinstruments.com/programming-corner 

# CI ATFX Reader API Package Content

## API DLL Files

The bin folder contains the DLL files that your software integration needs to reference to fully utilize the CI ATFX Reader API methods and objects.

## Demo Code

The CI ATFX Reader API demo are used in 4 coding languages:
- C#
- Python
- Matlab
- LabVIEW

C# is the main coding language and demo for the CI ATFX Reader API, while the other coding languages import and reference the DLL files.

For Python, it uses a package called Python.Net to import the CI ATFX Reader API DLL files.

For Matlab, it uses the in built method that Matlab provides to import the CI ATFX Reader API DLL files.

For LabVIEW, it imports the CI ATFX Reader API methods directly while using another DLL file to assist LabVIEW in comprehending C# objects and methods.

# License & Term Agreement

The link below is our Crystal Instruments' End License Agreement usage for our software:

[Crystal Instruments End License Agreement](https://github.com/Crystal-Instruments/CIDataFileReaderAPI/blob/main/Crystal%20Instruments%20License.md)
