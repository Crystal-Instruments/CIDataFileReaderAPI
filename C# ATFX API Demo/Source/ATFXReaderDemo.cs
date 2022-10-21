﻿/*------------------------------------------------------------------------
 * Copyright (C) 2022 by Crystal Instruments Corporation.
 * All rights reserved
 ------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EDM.RecordingInterface;
using EDM.Recording;
using ASAM.ODS.NVH;
using System.Reflection;
using Common;
using Common.Spider;
using System.Diagnostics;
using EDM.Utils;

namespace ATFXReader
{
    public partial class ATFXReaderDemo : Form
    {
        #region Fields
        /// <summary>
        /// Determine whether the current datagridview for Signals should be displaying
        /// <br>Basic info, advance info, frame data, parameters or generated time</br>
        /// </summary>
        private SignalDataInfo signalDataInfo;
        public enum SignalDataInfo
        {
            SignalBasicInfo = 0,
            SignalAdvanceInfo = 1,
            SignalFrameData = 2,
            SignalParameters = 3,
            SignalGeneratedTime = 4,
        }

        /// <summary>
        /// Determine whether the current datagridview for Recording should be displaying
        /// <br>Recording property, recording date time nano local, recording date time nano UTC</br>
        /// </summary>
        private RecordDataInfo recordDataInfo;
        public enum RecordDataInfo
        {
            RecordProperty = 0,
            DateTimeNanoLocal = 1,
            DateTimeNanoUTC = 2,
        }

        //For the GetPropertiesString function
        // if the current TabPage is selected variables
        private bool istpRecInfoSelected;
        private bool istpSignalInfoSelected;
        private bool istpChannelInfoSelected;
        private bool istpMergeInfoSelected;
        #endregion

        #region Constructor & Initialize functions
        //Constructor
        public ATFXReaderDemo()
        {
            InitializeComponent();
            signalDataInfo = SignalDataInfo.SignalBasicInfo;
            recordDataInfo = RecordDataInfo.RecordProperty;
            // Hide extra columns for signal parameters
            clmHighAbort.Visible = false;
            clmHighAlarm.Visible = false;
            clmLowAlarm.Visible = false;
            clmLowAbort.Visible = false;
        }

        /// <summary>
        /// Load all data from IRecording and display or store data into various list and grids
        /// </summary>
        /// <param name="rec"></param>
        private void LoadRecord(IRecording rec)
        {
            ShowContents(dgvRecInfo, rec.RecordingProperty);
            ShowGPSInfo(rec);
            ShowSignals(rec);
            ShowRecordings(rec);
            ShowChannelTable(rec);
            ShowCandidateParameters();
            ShowMergeInfo(rec);
        }
        #endregion

        #region ListBox Show Data
        /// <summary>
        /// Add signals from IRecording to a listbox to easily access data during operations
        /// </summary>
        /// <param name="rec"></param>
        private void ShowSignals(IRecording rec)
        {
            lbSignalDataInfo.Items.Clear();

            lbSignalDataInfo.Items.AddRange(Utility.GetListOfAllSignals(rec).ToArray());

            if (lbSignalDataInfo.Items.Count > 0) 
                lbSignalDataInfo.SelectedIndex = 0;
        }

        /// <summary>
        /// Add Recording to a listbox if their is more than 1 recording, such as the recording from the measurement device,
        /// the recording regarding timestamp data and / or recording regarding gps data
        /// </summary>
        /// <param name="rec"></param>
        private void ShowRecordings(IRecording rec)
        {
            if (rec as ODSATFXMLRecording == null)
            {
                lbRecordingDataInfo.Items.Clear();
                lbRecordingDataInfo.Items.Add(rec); // Add the initial IRecording object  
                return;
            }

            lbRecordingDataInfo.Items.Clear();
            lbRecordingDataInfo.Items.AddRange(Utility.GetListOfAllRecordings(rec).ToArray());

            if (lbRecordingDataInfo.Items.Count > 0)
                lbRecordingDataInfo.SelectedIndex = 0;
        }

        /// <summary>
        /// Add signal parameters to a listbox to easily access data during operations
        /// </summary>
        private void ShowCandidateParameters()
        {
            try
            {
                lbSignalParameters.SuspendLayout();
                lbSignalParameters.Items.Clear();

                lbSignalParameters.Items.AddRange(Utility.GetListOfNVHParameterSet().ToArray());
                
                if (lbSignalParameters.Items.Count > 0)
                    lbSignalParameters.SelectedIndex = 0;
            }
            finally
            {
                lbSignalParameters.ResumeLayout();
                lbSignalParameters.PerformLayout();
            }
        }
        #endregion

        #region DataGridView Show Data
        /// <summary>
        /// Shows all properties inside an object, whether its a signal or recording
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="item"></param>
        /// <param name="showPublicField"></param>
        private void ShowContents(DataGridView grid, object item, bool showPublicField = false)
        {
            try
            {
                grid.SuspendLayout();
                grid.Rows.Clear();
                clmSignalProp.HeaderText = "Property";
                clmSignalPropValue.HeaderText = "Value";
                clmSignalPropValue.Visible = true; 
                clmHighAbort.Visible = false;
                clmHighAlarm.Visible = false;
                clmLowAlarm.Visible = false;
                clmLowAbort.Visible = false;

                foreach(List<string> property in Utility.GetListOfProperties(item, showPublicField))
                {
                    grid.Rows.Add(property[0], property[1]);
                }
            }
            finally
            {
                grid.ResumeLayout();
                grid.PerformLayout();
            }
        }

        /// <summary>
        /// Show gps data of the recording
        /// <br>Example code to show gps data</br>
        /// </summary>
        /// <param name="rec"></param>
        private void ShowGPSInfo(IRecording rec)
        {
            if (rec is ODSNVHATFXMLRecording nvhRec)
            {
                NVHMeasurement nvhMeasurement = nvhRec.Measurement as NVHMeasurement;
                NVHEnvironment nvhEnvironment = nvhRec.Environment as NVHEnvironment;

                bool bGPS = nvhMeasurement.GPSEnabled;

                if (bGPS)
                {
                    dgvRecInfo.Rows.Add("GPS Enabled", bGPS);
                    double lng = nvhMeasurement.Longitude;
                    double lat = nvhMeasurement.Latitude;
                    double alt = nvhMeasurement.Altitude;
                    double nano = nvhMeasurement.NanoSecondElapsed;

                    dgvRecInfo.Rows.Add("Longitude", lng);
                    dgvRecInfo.Rows.Add("Latitude", lat);
                    dgvRecInfo.Rows.Add("Altitude", alt);
                    dgvRecInfo.Rows.Add("Nanoseconds Elapsed", nano);
                }

                if (!String.IsNullOrEmpty(nvhEnvironment.TimeZoneString))
                {
                    dgvRecInfo.Rows.Add("Time Zone", nvhEnvironment.TimeZoneString);
                }

                dgvRecInfo.Rows.Add("Created Time (Local)", nvhRec.RecordingProperty.CreateTime);
                dgvRecInfo.Rows.Add("Created Time (UTC)", Utils.GetUTCTime(nvhRec.RecordingProperty.CreateTime, null));
                
                if (!String.IsNullOrEmpty(nvhEnvironment.InstruSoftwareVersion))
                {
                    dgvRecInfo.Rows.Add("Instrument Software Version", nvhEnvironment.InstruSoftwareVersion);
                    dgvRecInfo.Rows.Add("Hardware Version", nvhEnvironment.HardwareVersion);
                    dgvRecInfo.Rows.Add("Firmware Version", nvhEnvironment.FirmwareVersion);
                    dgvRecInfo.Rows.Add("Bit Version", nvhEnvironment.BitVersion);
                }
            }
        }

        /// <summary>
        /// Show the DateTimeNano of a recording in either local or UTC time
        /// <br>Example code to show DateTimeNano</br>
        /// </summary>
        /// <param name="rec"></param>
        /// <param name="isLocal"></param>
        private void ShowDateTimeNano(IRecording rec, bool isLocal)
        {
            try
            {
                dgvRecInfo.SuspendLayout();
                dgvRecInfo.Rows.Clear();
                clmSignalProp.HeaderText = "Property";
                clmSignalPropValue.HeaderText = "Value";
                clmSignalPropValue.Visible = true;
                clmHighAbort.Visible = false;
                clmHighAlarm.Visible = false;
                clmLowAlarm.Visible = false;
                clmLowAbort.Visible = false;

                if (rec is ODSNVHATFXMLRecording nvhRec)
                {
                    NVHMeasurement nvhMeasurement = nvhRec.Measurement as NVHMeasurement;

                    DateTimeNano createTimeUTC;
                    if (isLocal)
                    {
                        createTimeUTC = new DateTimeNano(nvhRec.RecordingProperty.CreateTime, nvhMeasurement.NanoSecondElapsed);
                    }
                    else
                    {
                        createTimeUTC = new DateTimeNano(Utils.GetUTCTime(nvhRec.RecordingProperty.CreateTime, null),
                            nvhMeasurement.NanoSecondElapsed);
                    }
                    dgvRecInfo.Rows.Add("Year", createTimeUTC.Year);
                    dgvRecInfo.Rows.Add("Month", createTimeUTC.Month);
                    dgvRecInfo.Rows.Add("Day", createTimeUTC.Day);
                    dgvRecInfo.Rows.Add("Hour", createTimeUTC.Hour);
                    dgvRecInfo.Rows.Add("Minute", createTimeUTC.Minute);
                    dgvRecInfo.Rows.Add("Second", createTimeUTC.Second);
                    dgvRecInfo.Rows.Add("Millisecond", createTimeUTC.Millisecond);
                    dgvRecInfo.Rows.Add("IsNanoTime", createTimeUTC.IsNanoTime);
                    dgvRecInfo.Rows.Add("NanoSeconds", createTimeUTC.ms_us_ns);
                    dgvRecInfo.Rows.Add("TotalNanosec", createTimeUTC.DayNanoSeconds);
                    dgvRecInfo.Rows.Add("Date Time", createTimeUTC._DateTime);
                    dgvRecInfo.Rows.Add("TimeOfDay", createTimeUTC.TimeOfDay);
                    dgvRecInfo.Rows.Add("ToNanoString()", createTimeUTC.ToNanoString());

                    int ms = (int)(createTimeUTC.ms_us_ns / 1e6);
                    int us = (int)(createTimeUTC.ms_us_ns / 1e3 % 1e3);
                    int ns = (int)(createTimeUTC.ms_us_ns % 1e3);
                    string customFormat = string.Format("{0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}/{8}", createTimeUTC.Year, createTimeUTC.Month,
                        createTimeUTC.Day, createTimeUTC.Hour, createTimeUTC.Minute, createTimeUTC.Second, ms, us, ns);
                    dgvRecInfo.Rows.Add("Custom Format: yyyy/mm/dd/hh/mm/ss/ms/us/ns", customFormat);
                }
            }
            finally
            {
                dgvRecInfo.ResumeLayout();
                dgvRecInfo.PerformLayout();
            }
        }

        /// <summary>
        /// Shows input channel table data of the recording
        /// </summary>
        /// <param name="rec"></param>
        private void ShowChannelTable(IRecording rec)
        {
            try
            {
                dgvChannel.SuspendLayout();
                dgvChannel.Rows.Clear();

                if(rec == null)
                {
                    return;
                }

                RecordingProperty recProp = rec.RecordingProperty;

                if (recProp.MeasurementType == MeasurementConfigType.CSA_FFT ||
                    recProp.MeasurementType == MeasurementConfigType.DSA_Acoustic ||
                    recProp.MeasurementType == MeasurementConfigType.DSA_OrderTracking ||
                    recProp.MeasurementType == MeasurementConfigType.DSA_MotorVibration ||
                    recProp.MeasurementType == MeasurementConfigType.DSA_RotorDynamics ||
                    recProp.MeasurementType == MeasurementConfigType.DSA_TachoTracking)
                {
                    clmWeight.Visible = false;
                }

                foreach (List<string> channel in Utility.GetChannelTable(rec))
                {
                    dgvChannel.Rows.Add(channel.ToArray());
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                dgvChannel.ResumeLayout();
                dgvChannel.PerformLayout();
            }
        }

        /// <summary>
        /// Show a signal parameter depending on a selected NVHParameter key
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="sig"></param>
        /// <param name="parameterKey"></param>
        private void ShowParameters(DataGridView grid, ISignal sig, string parameterKey)
        {
            try
            {
                grid.SuspendLayout();
                grid.Rows.Clear();
                clmSignalProp.HeaderText = "Data Type";
                clmSignalPropValue.HeaderText = "Value";
                clmHighAbort.Visible = false;
                clmHighAlarm.Visible = false;
                clmLowAlarm.Visible = false;
                clmLowAbort.Visible = false;

                if (parameterKey == NVHParameterSet.testProfile)
                {
                    clmSignalProp.HeaderText = "Frequency";
                    clmSignalPropValue.HeaderText = "Profile";
                    clmSignalPropValue.Visible = true;

                    clmHighAbort.Visible = true;
                    clmHighAlarm.Visible = true;
                    clmLowAlarm.Visible = true;
                    clmLowAbort.Visible = true;

                    foreach (List<string> entry in Utility.GetSignalProfileOrLimit(sig, parameterKey))
                    {
                        grid.Rows.Add(entry.ToArray());
                    }
                }
                else if (parameterKey == NVHParameterSet.testAbortLimit ||
                    parameterKey == NVHParameterSet.testAlarmLimit ||
                    parameterKey == NVHParameterSet.testNotchLimit)
                {
                    clmSignalProp.HeaderText = "Frequency";
                    clmSignalPropValue.HeaderText = "Acc";
                    clmSignalPropValue.Visible = true;

                    foreach (List<string> entry in Utility.GetSignalProfileOrLimit(sig, parameterKey))
                    {
                        grid.Rows.Add(entry.ToArray());
                    }
                }
                else
                {
                    List<string> signalParam = Utility.GetSignalNVHParameter(sig, parameterKey);
                    grid.Rows.Add(signalParam.ToArray());
                }
            }
            finally
            {
                grid.ResumeLayout();
                grid.PerformLayout();
            }
        }

        /// <summary>
        /// Show the signal frame data that allows spectrum type and engineering unit conversion
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="signal"></param>
        /// <param name="spectrum"></param>
        /// <param name="engiUnit"></param>
        private void ShowFrameData(DataGridView grid, ISignal signal, _SpectrumScalingType spectrum, string engiUnit)
        {
            double[][] frame = signal.GetFrame(0, spectrum, engiUnit);
            if (frame == null || frame.Length < 2) return;

            try
            {
                grid.SuspendLayout();
                grid.Rows.Clear();

                var frameSize = frame[0].Length;

                clmSignalProp.HeaderText = $"X Data-{signal.GetLabel(0)}";
                clmSignalPropValue.HeaderText = $"Y Data-{signal.GetYLabel()[0]}";
                clmHighAbort.Visible = false; 
                clmSignalPropValue.Visible = true;
                clmHighAlarm.Visible = false;
                clmLowAlarm.Visible = false;
                clmLowAbort.Visible = false;

                if (frame.Length == 3)
                {
                    clmHighAbort.HeaderText = $"Z Data-{signal.GetLabel(2)}";
                    clmHighAbort.Visible = true;
                }

                if (signal.Type == SignalType.Frequency && signal.Name != "H(f)" &&
                    (signal.Properties.NvhType == _NVHType.FrequencyResponseSpectrum ||
                    signal.Properties.NvhType == _NVHType.CrosspowerSpectrum || 
                    signal.Properties.NvhType == _NVHType.ComplexSpectrum))
                {
                    clmHighAbort.Visible = true;
                    clmHighAbort.HeaderText = $"Y data-{signal.GetYLabel()[1]}";
                    // For H data / phase column data as signal saved it together in the Y data of frame
                    // It is why the Y data frame size is double than X data frame size
                    for (int index = 0; index < frameSize * 2; index += 2)
                    {
                        grid.Rows.Add(frame[0][index / 2].ToString(), frame[1][index].ToString(), frame[1][index + 1].ToString());
                    }
                }
                else
                {
                    for (int index = 0; index < frameSize; index++)
                    {
                        grid.Rows.Add(frame[0][index].ToString(), frame[1][index].ToString());
                        if (frame.Length == 3 && frame[2].Length > index)
                            grid.Rows[index].Cells[2].Value = frame[2][index].ToString();
                    }
                }
            }
            finally
            {
                grid.ResumeLayout();
                grid.PerformLayout();
            }
        }

        /// <summary>
        /// Show properties regarding a merged signal file
        /// </summary>
        /// <param name="rec"></param>
        private void ShowMergeInfo(IRecording rec)
        {
            try
            {
                dgvMergeInfo.SuspendLayout();
                dgvMergeInfo.Rows.Clear();

                List<List<string>> mergeInfo = Utility.GetMergeInfo(rec, out int sigMapCount);

                if (sigMapCount == 0)
                {
                    dgvMergeInfo.Columns[0].Visible = false;
                    dgvMergeInfo.Columns[1].Visible = false;
                }
                else
                {
                    dgvMergeInfo.Columns[0].Visible = true;
                    dgvMergeInfo.Columns[1].Visible = true;
                }

                foreach (List<string> merge in mergeInfo)
                {
                    dgvMergeInfo.Rows.Add(merge.ToArray());
                }
                this.Refresh();
            }
            finally
            {
                dgvMergeInfo.ResumeLayout();
                dgvMergeInfo.PerformLayout();
            }
        }
        #endregion

        #region Selection Index Change
        /// <summary>
        /// comboBox selected index change for engineering unit
        /// <br>Re get the selected signal frame data with selected spectrum type and new unit selection</br>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbEngiUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSignalDataInfo.SelectedItem is ISignal signal)
            {
                _SpectrumScalingType spectrum;
                if (cbSpecScaleType.SelectedItem == null)
                {
                    if(signal.Recording.RecordingProperty.MeasurementType == MeasurementConfigType.VCS_Sine)
                        spectrum = _SpectrumScalingType.EURms;
                    else
                        spectrum = _SpectrumScalingType.EURMS2;
                }
                else
                {
                    spectrum = Utility.GetSpectrumType(cbSpecScaleType.SelectedItem.ToString());
                }
                string unit = "";
                if (cbEngiUnit.SelectedItem != null)
                {
                    unit = cbEngiUnit.SelectedItem.ToString();
                }
                ShowFrameData(dgvSignalDataInfo, signal, spectrum, unit);
            }
        }

        /// <summary>
        /// Listbox signal list selected index change
        /// <br>Handles what data to show for the selected signal</br>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbSignalDataInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSignalDataInfo.SelectedItem is ISignal signal)
            {
                if (signal.Type == SignalType.Frequency &&
                    (signal.Properties.NvhType == _NVHType.FrequencyResponseSpectrum ||
                    signal.Properties.NvhType == _NVHType.CrosspowerSpectrum ||
                    signal.Properties.NvhType == _NVHType.Coherence ||
                    signal.Properties.NvhType == _NVHType.Equidistant))
                {
                    cbEngiUnit.Items.Clear();
                    cbEngiUnit.Text = "";
                    cbEngiUnit.Enabled = false;
                }
                else
                {
                    cbEngiUnit.Enabled = true;

                    string[] engiUnits = Utility.GetSignalQuantityEngiUnitStrings(signal);
                    if(engiUnits != null)
                    {
                        cbEngiUnit.Items.Clear();
                        cbEngiUnit.Items.AddRange(engiUnits);
                        cbEngiUnit.SelectedItem = signal.GetUnit(1);
                    }
                    else
                    {
                        cbEngiUnit.Items.Clear();
                        cbEngiUnit.Text = "";
                        cbEngiUnit.Enabled = false;
                    }
                }

                if (signal.Type == SignalType.Frequency && !signal.Name.Contains("Swept THD") &&
                    (signal.Properties.NvhType == _NVHType.AutopowerSpectrum || 
                    signal.Properties.NvhType == _NVHType.OctaveAutopowerSpectrum ||
                    signal.Properties.NvhType == _NVHType.OrderAutopowerSpectrum))
                {
                    cbSpecScaleType.Enabled = true;

                    cbSpecScaleType.Items.Clear();
                    cbSpecScaleType.Items.AddRange(Utility.GetListOfSpectrumTypes(signal).ToArray());
                    if (cbSpecScaleType.Items.Contains(Utility.GetSpectrumTypeString(signal.Properties.specType)))
                        cbSpecScaleType.SelectedItem = Utility.GetSpectrumTypeString(signal.Properties.specType);
                    else
                        cbSpecScaleType.SelectedItem = cbSpecScaleType.Items[0];
                }
                else
                {
                    cbSpecScaleType.Items.Clear();
                    cbSpecScaleType.Text = "";
                    cbSpecScaleType.Enabled = false;
                }
            }
            //Keep tracks of the displayed grid for signal if switching from signal to recording and so on
            switch (signalDataInfo)
            {
                case SignalDataInfo.SignalBasicInfo:
                    BtnSignalBasicInfo_Click(sender, e);
                    break;
                case SignalDataInfo.SignalAdvanceInfo:
                    BtnSignalAdvInfo_Click(sender, e);
                    break;
                case SignalDataInfo.SignalFrameData:
                    BtnSignalFrameData_Click(sender, e);
                    break;
                case SignalDataInfo.SignalParameters:
                    BtnSignalParam_Click(sender, e);
                    break;
                case SignalDataInfo.SignalGeneratedTime:
                    BtnShowGeneratedTime_Click(sender, e);
                    break;
            }
        }

        /// <summary>
        /// Listbox signal parameter selected index change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbSignalParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(signalDataInfo == SignalDataInfo.SignalParameters)
            {
                BtnSignalParam_Click(sender, e);
            }
        }

        /// <summary>
        /// Listbox recording selected index change
        /// <br>Handles what data to show for the selected recording</br>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbRecording_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbRecordingDataInfo.SelectedItem is IRecording rec)
            {
                //Keep tracks of the displayed grid for recording if switching from recording to signal and so on
                switch (recordDataInfo)
                {
                    case RecordDataInfo.RecordProperty:
                        BtnShowRecordingProperty_Click(sender, e);
                        break;
                    case RecordDataInfo.DateTimeNanoUTC:
                        BtnShowDateTimeNanoUTC_Click(sender, e);
                        break;
                    case RecordDataInfo.DateTimeNanoLocal:
                        BtnShowDateTimeNanoLocal_Click(sender, e);
                        break;
                }
            }
        }
        #endregion

        #region Button Events
        /// <summary>
        /// Button for loading up the ATFX file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            lbSignalParameters.Visible = false;
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "ATFX file|*.atfx|TS file|*.ts|GPS file|*.gps|All File|*.*";
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {

                    if (!string.IsNullOrEmpty(tbFile.Text))
                    {
                        RecordingManager.Manager.CloseRecording(tbFile.Text);
                    }

                    tbFile.Text = dlg.FileName;
                    if (RecordingManager.Manager.OpenRecording(tbFile.Text, out IRecording rec))
                    {
                        LoadRecord(rec);
                        btnCopy.Enabled = true;
                        btnExport.Enabled = true;
                    }
                }
            }
        }

        /// <summary>
        /// Button for showing the signal property data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSignalBasicInfo_Click(object sender, EventArgs e)
        {
            lbSignalParameters.Visible = false;
            signalDataInfo = SignalDataInfo.SignalBasicInfo;
            if (lbSignalDataInfo.SelectedItem is ISignal signal)
            {
                ShowContents(dgvSignalDataInfo, signal.Properties);
            }
        }

        /// <summary>
        /// Button for showing the signal advance property data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSignalAdvInfo_Click(object sender, EventArgs e)
        {
            lbSignalParameters.Visible = false;
            signalDataInfo = SignalDataInfo.SignalAdvanceInfo;
            if (lbSignalDataInfo.SelectedItem is ISignal signal)
            {
                //if signal is a dsa signal, dsa properties should not be empty
                if (signal.Properties.dsaProperties != null)
                {
                    ShowContents(dgvSignalDataInfo, signal.Properties.dsaProperties, true);
                }
                //if signal is a vcs signal, vcs properties should not be empty
                if (signal.Properties.vcsProperties != null)
                {
                    ShowContents(dgvSignalDataInfo, signal.Properties.vcsProperties, true);
                }
            }
        }

        /// <summary>
        /// Button for showing the signal frame data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSignalFrameData_Click(object sender, EventArgs e)
        {
            lbSignalParameters.Visible = false;
            signalDataInfo = SignalDataInfo.SignalFrameData;
            if (lbSignalDataInfo.SelectedItem is ISignal signal)
            {
                _SpectrumScalingType spectrum;
                if (cbSpecScaleType.SelectedItem == null)
                {
                    if (signal.Recording.RecordingProperty.MeasurementType == MeasurementConfigType.VCS_Sine)
                        spectrum = _SpectrumScalingType.EURms;
                    else
                        spectrum = _SpectrumScalingType.EURMS2;
                }
                else
                {
                    spectrum = Utility.GetSpectrumType(cbSpecScaleType.SelectedItem.ToString());
                }
                string unit = "";
                if(cbEngiUnit.SelectedItem != null)
                {
                    unit = cbEngiUnit.SelectedItem.ToString();
                }
                ShowFrameData(dgvSignalDataInfo, signal, spectrum, unit);
            }
        }

        /// <summary>
        /// Button for showing the signal NVHParameter key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSignalParam_Click(object sender, EventArgs e)
        {
            lbSignalParameters.Visible = true;
            signalDataInfo = SignalDataInfo.SignalParameters;
            string parameterKey = lbSignalParameters.SelectedItem as string;
            if (lbSignalDataInfo.SelectedItem is ISignal signal && !string.IsNullOrEmpty(parameterKey))
            {
                ShowParameters(dgvSignalDataInfo, signal, parameterKey);
            }
        }

        /// <summary>
        /// Button for showing the signal generated time property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowGeneratedTime_Click(object sender, EventArgs e)
        {
            lbSignalParameters.Visible = false;
            signalDataInfo = SignalDataInfo.SignalGeneratedTime;
            if (lbSignalDataInfo.SelectedItem is ISignal signal)
            {
                ShowContents(dgvSignalDataInfo, signal.Properties.GeneratedTime);
            }
        }

        /// <summary>
        /// Button for showing the recording properties & GPS data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowRecordingProperty_Click(object sender, EventArgs e)
        {
            recordDataInfo = RecordDataInfo.RecordProperty;
            if (lbRecordingDataInfo.SelectedItem is IRecording rec)
            {
                ShowContents(dgvRecInfo, rec.RecordingProperty);
                ShowGPSInfo(rec);
            }
        }

        /// <summary>
        /// Button for showing the recording DateTimeNano in UTC time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowDateTimeNanoUTC_Click(object sender, EventArgs e)
        {
            recordDataInfo = RecordDataInfo.DateTimeNanoUTC;
            if (lbRecordingDataInfo.SelectedItem is IRecording rec)
            {
                ShowDateTimeNano(rec, false);
            }
        }

        /// <summary>
        /// Button for showing the recording DateTimeNano in local time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowDateTimeNanoLocal_Click(object sender, EventArgs e)
        {
            recordDataInfo = RecordDataInfo.DateTimeNanoLocal;
            if (lbRecordingDataInfo.SelectedItem is IRecording rec)
            {
                ShowDateTimeNano(rec, true);
            }
        }

        /// <summary>
        /// Simple Export function that export the ATFX file into a CSV file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExportCSV_Click(object sender, EventArgs e)
        {
            if (lbSignalDataInfo.SelectedItem is ISignal signal)
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.Filter = "CSV File|*.csv";
                    dlg.FileName = $"{signal.Name}.csv";
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        //export the signal in the list, the export type can be judged by export file name automatically.
                        var ret = RecordingManager.Manager.ExportSignals(new List<ISignal>() { signal }, dlg.FileName);
                        MessageBox.Show($"Signal export result:{ret}");
                    }
                }
            }
        }

        /// <summary>
        /// Simple Copy function that export the ATFX file into the PC clipboard to paste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            var str = this.GetPropertiesString();
            if (String.IsNullOrEmpty(str))
            {
                return;
            }
            Clipboard.SetText(str);
        }

        /// <summary>
        /// Simple Export function that export the ATFX file into a txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Text files|*.txt";
                dlg.FileName = tabControl1.SelectedTab.Text;
                dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(dlg.FileName))
                    {
                        var str = this.GetPropertiesString();
                        if (String.IsNullOrEmpty(str))
                        {
                            return;
                        }
                        writer.Write(str);
                    }
                }
            }
        }
        #endregion

        #region Utility Functions
        /// <summary>
        /// Get the properties depending on which grid is visible
        /// </summary>
        /// <returns></returns>
        private string GetPropertiesString()
        {
            DataGridView currDgv;

            //Get the current displayed grid
            if (istpRecInfoSelected)
            {
                currDgv = dgvRecInfo;
            }
            else if (istpSignalInfoSelected)
            {
                currDgv = dgvSignalDataInfo;
            }
            else if (istpChannelInfoSelected)
            {
                currDgv = dgvChannel;
            }
            else if (istpMergeInfoSelected)
            {
                currDgv = dgvMergeInfo;
            }
            else
            {
                return "";
            }

            //Gets the headertext from the column to append first
            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewColumn col in currDgv.Columns)
            {
                if (!col.Visible)
                    break;
                sb.Append(col.HeaderText);
                if (col.Index < currDgv.Columns.Count - 1)
                    sb.Append("\t");
            }
            sb.AppendLine();

            //Then gets the value that correspond to each header text
            foreach (DataGridViewRow row in currDgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value);
                    if (cell.ColumnIndex < row.Cells.Count - 1)
                        sb.Append("\t");
                }
                sb.AppendLine();
            }
            
            return sb.ToString();
        }
        #endregion

        //Sets the current selected tab to be true and is used for the GetPropertiesString function
        #region TabPage Enter Events
        //For GetPropertiesString function
        private void tpRecInfo_Enter(object sender, EventArgs e)
        {
            istpRecInfoSelected = true;
            istpSignalInfoSelected = false;
            istpChannelInfoSelected = false;
            istpMergeInfoSelected = false;
        }

        //For GetPropertiesString function
        private void tpSignalDataInfo_Enter(object sender, EventArgs e)
        {
            istpSignalInfoSelected = true;
            istpRecInfoSelected = false;
            istpChannelInfoSelected = false;
            istpMergeInfoSelected = false;
        }

        //For GetPropertiesString function
        private void tpChannelInfo_Enter(object sender, EventArgs e)
        {
            istpChannelInfoSelected = true;
            istpRecInfoSelected = false;
            istpSignalInfoSelected = false;
            istpMergeInfoSelected = false;
        }

        //For GetPropertiesString function
        private void tpMergeInfo_Enter(object sender, EventArgs e)
        {
            istpMergeInfoSelected = true;
            istpRecInfoSelected = false;
            istpSignalInfoSelected = false;
            istpChannelInfoSelected = false;
        }
        #endregion
    }
}
