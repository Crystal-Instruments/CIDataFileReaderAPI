/*------------------------------------------------------------------------
 * Copyright (C) 2022 by Crystal Instruments Corporation.
 * All rights reserved
 ------------------------------------------------------------------------*/
namespace ATFXReader
{
    partial class ATFXReaderDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRecInfo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvRecInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbRecordingDataInfo = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowRecordProp = new System.Windows.Forms.Button();
            this.btnShowDateTimeNanoUTC = new System.Windows.Forms.Button();
            this.btnShowDateTimeNanoLocal = new System.Windows.Forms.Button();
            this.tpSignalDataInfo = new System.Windows.Forms.TabPage();
            this.tlpSignalDataInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lbSignalDataInfo = new System.Windows.Forms.ListBox();
            this.dgvSignalDataInfo = new System.Windows.Forms.DataGridView();
            this.clmSignalProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSignalPropValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHighAbort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHighAlarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLowAlarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLowAbort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbSignalParameters = new System.Windows.Forms.ListBox();
            this.flpSignalChanges = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSpecScaleType = new System.Windows.Forms.ComboBox();
            this.cbEngiUnit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSignalFrameIndex = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSignalBasic = new System.Windows.Forms.Button();
            this.btnSignalAdv = new System.Windows.Forms.Button();
            this.btnSignalFrame = new System.Windows.Forms.Button();
            this.btnSignalParam = new System.Windows.Forms.Button();
            this.btnShowGeneratedTime = new System.Windows.Forms.Button();
            this.btnShowtsdatUTC = new System.Windows.Forms.Button();
            this.btnExportCSV2 = new System.Windows.Forms.Button();
            this.tpChannelInfo = new System.Windows.Forms.TabPage();
            this.dgvChannel = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHiPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpMergeInfo = new System.Windows.Forms.TabPage();
            this.dgvMergeInfo = new System.Windows.Forms.DataGridView();
            this.clmSourceFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSourceLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurrFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurrLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpTSDATInfo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvCalculateTSDATInfo = new System.Windows.Forms.DataGridView();
            this.clmCalTSDATIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCalTSDATRead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReadTSDATInfo = new System.Windows.Forms.DataGridView();
            this.clmReadTSDATIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReadTSDATData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbTSDATFrameIndex = new System.Windows.Forms.TextBox();
            this.btnReadTSDAT = new System.Windows.Forms.Button();
            this.cbUseRecording = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbTSDATInput = new System.Windows.Forms.TextBox();
            this.btnCalculateTSDAT = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnGenTSDATFile = new System.Windows.Forms.Button();
            this.btnGenSatStat = new System.Windows.Forms.Button();
            this.btnGenTSTSDATCompare = new System.Windows.Forms.Button();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSegmentLost = new System.Windows.Forms.Label();
            this.cbUTCFormatTSDAT = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbMergeAllDRD = new System.Windows.Forms.CheckBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCombineDRDFiles = new System.Windows.Forms.Button();
            this.cbOnlyDATX = new System.Windows.Forms.CheckBox();
            this.lblErrorMSG = new System.Windows.Forms.Label();
            this.bgWorkerDRDCombine = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgWorkerDRDConvert = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tpRecInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecInfo)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tpSignalDataInfo.SuspendLayout();
            this.tlpSignalDataInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSignalDataInfo)).BeginInit();
            this.flpSignalChanges.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tpChannelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChannel)).BeginInit();
            this.tpMergeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMergeInfo)).BeginInit();
            this.tpTSDATInfo.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculateTSDATInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadTSDATInfo)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(674, 4);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // tbFile
            // 
            this.tbFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFile.Location = new System.Drawing.Point(10, 4);
            this.tbFile.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tbFile.Name = "tbFile";
            this.tbFile.ReadOnly = true;
            this.tbFile.Size = new System.Drawing.Size(644, 23);
            this.tbFile.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tabControl1, 5);
            this.tabControl1.Controls.Add(this.tpRecInfo);
            this.tabControl1.Controls.Add(this.tpSignalDataInfo);
            this.tabControl1.Controls.Add(this.tpChannelInfo);
            this.tabControl1.Controls.Add(this.tpMergeInfo);
            this.tabControl1.Controls.Add(this.tpTSDATInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1203, 637);
            this.tabControl1.TabIndex = 2;
            // 
            // tpRecInfo
            // 
            this.tpRecInfo.Controls.Add(this.tableLayoutPanel1);
            this.tpRecInfo.Location = new System.Drawing.Point(4, 24);
            this.tpRecInfo.Name = "tpRecInfo";
            this.tpRecInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpRecInfo.Size = new System.Drawing.Size(1195, 609);
            this.tpRecInfo.TabIndex = 0;
            this.tpRecInfo.Text = "Record Information";
            this.tpRecInfo.UseVisualStyleBackColor = true;
            this.tpRecInfo.Enter += new System.EventHandler(this.tpRecInfo_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.dgvRecInfo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbRecordingDataInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1189, 603);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvRecInfo
            // 
            this.dgvRecInfo.AllowUserToAddRows = false;
            this.dgvRecInfo.AllowUserToDeleteRows = false;
            this.dgvRecInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvRecInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRecInfo.Location = new System.Drawing.Point(240, 3);
            this.dgvRecInfo.Name = "dgvRecInfo";
            this.dgvRecInfo.RowHeadersVisible = false;
            this.dgvRecInfo.RowHeadersWidth = 62;
            this.dgvRecInfo.RowTemplate.Height = 23;
            this.dgvRecInfo.Size = new System.Drawing.Size(946, 518);
            this.dgvRecInfo.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Property";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 180;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 180;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // lbRecordingDataInfo
            // 
            this.lbRecordingDataInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbRecordingDataInfo.FormattingEnabled = true;
            this.lbRecordingDataInfo.HorizontalScrollbar = true;
            this.lbRecordingDataInfo.ItemHeight = 15;
            this.lbRecordingDataInfo.Location = new System.Drawing.Point(3, 3);
            this.lbRecordingDataInfo.Name = "lbRecordingDataInfo";
            this.tableLayoutPanel1.SetRowSpan(this.lbRecordingDataInfo, 2);
            this.lbRecordingDataInfo.Size = new System.Drawing.Size(211, 597);
            this.lbRecordingDataInfo.TabIndex = 2;
            this.lbRecordingDataInfo.SelectedIndexChanged += new System.EventHandler(this.LbRecording_SelectedIndexChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnShowRecordProp);
            this.flowLayoutPanel2.Controls.Add(this.btnShowDateTimeNanoUTC);
            this.flowLayoutPanel2.Controls.Add(this.btnShowDateTimeNanoLocal);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(238, 525);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(950, 77);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // btnShowRecordProp
            // 
            this.btnShowRecordProp.AutoSize = true;
            this.btnShowRecordProp.Location = new System.Drawing.Point(13, 8);
            this.btnShowRecordProp.Name = "btnShowRecordProp";
            this.btnShowRecordProp.Size = new System.Drawing.Size(163, 25);
            this.btnShowRecordProp.TabIndex = 0;
            this.btnShowRecordProp.Text = "Show Recording Property";
            this.btnShowRecordProp.UseVisualStyleBackColor = true;
            this.btnShowRecordProp.Click += new System.EventHandler(this.BtnShowRecordingProperty_Click);
            // 
            // btnShowDateTimeNanoUTC
            // 
            this.btnShowDateTimeNanoUTC.AutoSize = true;
            this.btnShowDateTimeNanoUTC.Location = new System.Drawing.Point(182, 8);
            this.btnShowDateTimeNanoUTC.Name = "btnShowDateTimeNanoUTC";
            this.btnShowDateTimeNanoUTC.Size = new System.Drawing.Size(207, 25);
            this.btnShowDateTimeNanoUTC.TabIndex = 1;
            this.btnShowDateTimeNanoUTC.Text = "Extract DateTimeNano Data in UTC";
            this.btnShowDateTimeNanoUTC.UseVisualStyleBackColor = true;
            this.btnShowDateTimeNanoUTC.Click += new System.EventHandler(this.BtnShowDateTimeNanoUTC_Click);
            // 
            // btnShowDateTimeNanoLocal
            // 
            this.btnShowDateTimeNanoLocal.AutoSize = true;
            this.btnShowDateTimeNanoLocal.Location = new System.Drawing.Point(395, 8);
            this.btnShowDateTimeNanoLocal.Name = "btnShowDateTimeNanoLocal";
            this.btnShowDateTimeNanoLocal.Size = new System.Drawing.Size(212, 25);
            this.btnShowDateTimeNanoLocal.TabIndex = 2;
            this.btnShowDateTimeNanoLocal.Text = "Extract DateTimeNano Data in Local";
            this.btnShowDateTimeNanoLocal.UseVisualStyleBackColor = true;
            this.btnShowDateTimeNanoLocal.Click += new System.EventHandler(this.BtnShowDateTimeNanoLocal_Click);
            // 
            // tpSignalDataInfo
            // 
            this.tpSignalDataInfo.Controls.Add(this.tlpSignalDataInfo);
            this.tpSignalDataInfo.Location = new System.Drawing.Point(4, 24);
            this.tpSignalDataInfo.Name = "tpSignalDataInfo";
            this.tpSignalDataInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpSignalDataInfo.Size = new System.Drawing.Size(1195, 609);
            this.tpSignalDataInfo.TabIndex = 6;
            this.tpSignalDataInfo.Text = "Signal Data Information";
            this.tpSignalDataInfo.UseVisualStyleBackColor = true;
            this.tpSignalDataInfo.Enter += new System.EventHandler(this.tpSignalDataInfo_Enter);
            // 
            // tlpSignalDataInfo
            // 
            this.tlpSignalDataInfo.ColumnCount = 3;
            this.tlpSignalDataInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSignalDataInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSignalDataInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSignalDataInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSignalDataInfo.Controls.Add(this.lbSignalDataInfo, 0, 0);
            this.tlpSignalDataInfo.Controls.Add(this.dgvSignalDataInfo, 2, 0);
            this.tlpSignalDataInfo.Controls.Add(this.lbSignalParameters, 1, 0);
            this.tlpSignalDataInfo.Controls.Add(this.flpSignalChanges, 2, 1);
            this.tlpSignalDataInfo.Controls.Add(this.tableLayoutPanel4, 2, 2);
            this.tlpSignalDataInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSignalDataInfo.Location = new System.Drawing.Point(3, 3);
            this.tlpSignalDataInfo.Name = "tlpSignalDataInfo";
            this.tlpSignalDataInfo.RowCount = 3;
            this.tlpSignalDataInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSignalDataInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSignalDataInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSignalDataInfo.Size = new System.Drawing.Size(1189, 603);
            this.tlpSignalDataInfo.TabIndex = 0;
            // 
            // lbSignalDataInfo
            // 
            this.lbSignalDataInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSignalDataInfo.FormattingEnabled = true;
            this.lbSignalDataInfo.HorizontalScrollbar = true;
            this.lbSignalDataInfo.ItemHeight = 15;
            this.lbSignalDataInfo.Location = new System.Drawing.Point(3, 3);
            this.lbSignalDataInfo.Name = "lbSignalDataInfo";
            this.tlpSignalDataInfo.SetRowSpan(this.lbSignalDataInfo, 3);
            this.lbSignalDataInfo.Size = new System.Drawing.Size(150, 628);
            this.lbSignalDataInfo.TabIndex = 0;
            this.lbSignalDataInfo.SelectedIndexChanged += new System.EventHandler(this.LbSignalDataInfo_SelectedIndexChanged);
            // 
            // dgvSignalDataInfo
            // 
            this.dgvSignalDataInfo.AllowUserToAddRows = false;
            this.dgvSignalDataInfo.AllowUserToDeleteRows = false;
            this.dgvSignalDataInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSignalDataInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSignalProp,
            this.clmSignalPropValue,
            this.clmHighAbort,
            this.clmHighAlarm,
            this.clmLowAlarm,
            this.clmLowAbort});
            this.dgvSignalDataInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSignalDataInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSignalDataInfo.Location = new System.Drawing.Point(315, 3);
            this.dgvSignalDataInfo.Name = "dgvSignalDataInfo";
            this.dgvSignalDataInfo.RowHeadersVisible = false;
            this.dgvSignalDataInfo.RowHeadersWidth = 62;
            this.dgvSignalDataInfo.Size = new System.Drawing.Size(871, 481);
            this.dgvSignalDataInfo.TabIndex = 1;
            // 
            // clmSignalProp
            // 
            this.clmSignalProp.HeaderText = "Property";
            this.clmSignalProp.MinimumWidth = 8;
            this.clmSignalProp.Name = "clmSignalProp";
            this.clmSignalProp.Width = 150;
            // 
            // clmSignalPropValue
            // 
            this.clmSignalPropValue.HeaderText = "Value";
            this.clmSignalPropValue.MinimumWidth = 8;
            this.clmSignalPropValue.Name = "clmSignalPropValue";
            this.clmSignalPropValue.Width = 150;
            // 
            // clmHighAbort
            // 
            this.clmHighAbort.HeaderText = "High Abort";
            this.clmHighAbort.MinimumWidth = 8;
            this.clmHighAbort.Name = "clmHighAbort";
            this.clmHighAbort.Width = 150;
            // 
            // clmHighAlarm
            // 
            this.clmHighAlarm.HeaderText = "High Alarm";
            this.clmHighAlarm.MinimumWidth = 8;
            this.clmHighAlarm.Name = "clmHighAlarm";
            this.clmHighAlarm.Width = 150;
            // 
            // clmLowAlarm
            // 
            this.clmLowAlarm.HeaderText = "Low Alarm";
            this.clmLowAlarm.MinimumWidth = 8;
            this.clmLowAlarm.Name = "clmLowAlarm";
            this.clmLowAlarm.Width = 150;
            // 
            // clmLowAbort
            // 
            this.clmLowAbort.HeaderText = "Low Alarm";
            this.clmLowAbort.MinimumWidth = 8;
            this.clmLowAbort.Name = "clmLowAbort";
            this.clmLowAbort.Width = 150;
            // 
            // lbSignalParameters
            // 
            this.lbSignalParameters.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSignalParameters.FormattingEnabled = true;
            this.lbSignalParameters.HorizontalScrollbar = true;
            this.lbSignalParameters.ItemHeight = 15;
            this.lbSignalParameters.Location = new System.Drawing.Point(159, 3);
            this.lbSignalParameters.Name = "lbSignalParameters";
            this.tlpSignalDataInfo.SetRowSpan(this.lbSignalParameters, 3);
            this.lbSignalParameters.Size = new System.Drawing.Size(150, 628);
            this.lbSignalParameters.TabIndex = 2;
            this.lbSignalParameters.Visible = false;
            this.lbSignalParameters.SelectedIndexChanged += new System.EventHandler(this.LbSignalParameter_SelectedIndexChanged);
            // 
            // flpSignalChanges
            // 
            this.flpSignalChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpSignalChanges.Controls.Add(this.label1);
            this.flpSignalChanges.Controls.Add(this.cbSpecScaleType);
            this.flpSignalChanges.Controls.Add(this.cbEngiUnit);
            this.flpSignalChanges.Controls.Add(this.label2);
            this.flpSignalChanges.Controls.Add(this.tbSignalFrameIndex);
            this.flpSignalChanges.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpSignalChanges.Location = new System.Drawing.Point(313, 488);
            this.flpSignalChanges.Margin = new System.Windows.Forms.Padding(1);
            this.flpSignalChanges.Name = "flpSignalChanges";
            this.flpSignalChanges.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.flpSignalChanges.Size = new System.Drawing.Size(875, 50);
            this.flpSignalChanges.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(280, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change how the signal frame data is read. \r\nThis does not change the values insid" +
    "e the ATFX file.";
            // 
            // cbSpecScaleType
            // 
            this.cbSpecScaleType.Enabled = false;
            this.cbSpecScaleType.FormattingEnabled = true;
            this.cbSpecScaleType.Location = new System.Drawing.Point(299, 8);
            this.cbSpecScaleType.Name = "cbSpecScaleType";
            this.cbSpecScaleType.Size = new System.Drawing.Size(121, 23);
            this.cbSpecScaleType.TabIndex = 0;
            this.cbSpecScaleType.SelectedIndexChanged += new System.EventHandler(this.cbEngiUnit_SelectedIndexChanged);
            // 
            // cbEngiUnit
            // 
            this.cbEngiUnit.FormattingEnabled = true;
            this.cbEngiUnit.Location = new System.Drawing.Point(426, 8);
            this.cbEngiUnit.Name = "cbEngiUnit";
            this.cbEngiUnit.Size = new System.Drawing.Size(121, 23);
            this.cbEngiUnit.TabIndex = 3;
            this.cbEngiUnit.SelectedIndexChanged += new System.EventHandler(this.cbEngiUnit_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Frame Index";
            // 
            // tbSignalFrameIndex
            // 
            this.tbSignalFrameIndex.Location = new System.Drawing.Point(631, 8);
            this.tbSignalFrameIndex.Name = "tbSignalFrameIndex";
            this.tbSignalFrameIndex.Size = new System.Drawing.Size(77, 23);
            this.tbSignalFrameIndex.TabIndex = 11;
            this.tbSignalFrameIndex.Text = "0";
            this.tbSignalFrameIndex.TextChanged += new System.EventHandler(this.cbEngiUnit_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(315, 542);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(871, 89);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnSignalBasic);
            this.flowLayoutPanel1.Controls.Add(this.btnSignalAdv);
            this.flowLayoutPanel1.Controls.Add(this.btnSignalFrame);
            this.flowLayoutPanel1.Controls.Add(this.btnSignalParam);
            this.flowLayoutPanel1.Controls.Add(this.btnShowGeneratedTime);
            this.flowLayoutPanel1.Controls.Add(this.btnShowtsdatUTC);
            this.flowLayoutPanel1.Controls.Add(this.btnExportCSV2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(869, 88);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnSignalBasic
            // 
            this.btnSignalBasic.Location = new System.Drawing.Point(13, 8);
            this.btnSignalBasic.Name = "btnSignalBasic";
            this.btnSignalBasic.Size = new System.Drawing.Size(136, 23);
            this.btnSignalBasic.TabIndex = 0;
            this.btnSignalBasic.Text = "Show Basic Signal Info";
            this.btnSignalBasic.UseVisualStyleBackColor = true;
            this.btnSignalBasic.Click += new System.EventHandler(this.BtnSignalBasicInfo_Click);
            // 
            // btnSignalAdv
            // 
            this.btnSignalAdv.Location = new System.Drawing.Point(155, 8);
            this.btnSignalAdv.Name = "btnSignalAdv";
            this.btnSignalAdv.Size = new System.Drawing.Size(156, 23);
            this.btnSignalAdv.TabIndex = 1;
            this.btnSignalAdv.Text = "Show Advance Signal Info";
            this.btnSignalAdv.UseVisualStyleBackColor = true;
            this.btnSignalAdv.Click += new System.EventHandler(this.BtnSignalAdvInfo_Click);
            // 
            // btnSignalFrame
            // 
            this.btnSignalFrame.Location = new System.Drawing.Point(317, 8);
            this.btnSignalFrame.Name = "btnSignalFrame";
            this.btnSignalFrame.Size = new System.Drawing.Size(148, 23);
            this.btnSignalFrame.TabIndex = 2;
            this.btnSignalFrame.Text = "Show Signal Frame Data";
            this.btnSignalFrame.UseVisualStyleBackColor = true;
            this.btnSignalFrame.Click += new System.EventHandler(this.BtnSignalFrameData_Click);
            // 
            // btnSignalParam
            // 
            this.btnSignalParam.Location = new System.Drawing.Point(471, 8);
            this.btnSignalParam.Name = "btnSignalParam";
            this.btnSignalParam.Size = new System.Drawing.Size(146, 23);
            this.btnSignalParam.TabIndex = 3;
            this.btnSignalParam.Text = "Show Signal Parameters";
            this.btnSignalParam.UseVisualStyleBackColor = true;
            this.btnSignalParam.Click += new System.EventHandler(this.BtnSignalParam_Click);
            // 
            // btnShowGeneratedTime
            // 
            this.btnShowGeneratedTime.Location = new System.Drawing.Point(623, 8);
            this.btnShowGeneratedTime.Name = "btnShowGeneratedTime";
            this.btnShowGeneratedTime.Size = new System.Drawing.Size(136, 23);
            this.btnShowGeneratedTime.TabIndex = 4;
            this.btnShowGeneratedTime.Text = "Show Generated Time";
            this.btnShowGeneratedTime.UseVisualStyleBackColor = true;
            this.btnShowGeneratedTime.Click += new System.EventHandler(this.BtnShowGeneratedTime_Click);
            // 
            // btnShowtsdatUTC
            // 
            this.btnShowtsdatUTC.Location = new System.Drawing.Point(13, 37);
            this.btnShowtsdatUTC.Name = "btnShowtsdatUTC";
            this.btnShowtsdatUTC.Size = new System.Drawing.Size(188, 23);
            this.btnShowtsdatUTC.TabIndex = 5;
            this.btnShowtsdatUTC.Text = "Show TSDAT Frame Data in UTC";
            this.btnShowtsdatUTC.UseVisualStyleBackColor = true;
            this.btnShowtsdatUTC.Click += new System.EventHandler(this.btnShowtsdatUTC_Click);
            // 
            // btnExportCSV2
            // 
            this.btnExportCSV2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCSV2.Location = new System.Drawing.Point(209, 37);
            this.btnExportCSV2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnExportCSV2.Name = "btnExportCSV2";
            this.btnExportCSV2.Size = new System.Drawing.Size(79, 23);
            this.btnExportCSV2.TabIndex = 0;
            this.btnExportCSV2.Text = "Export CSV";
            this.btnExportCSV2.UseVisualStyleBackColor = true;
            this.btnExportCSV2.Click += new System.EventHandler(this.BtnExportCSV_Click);
            // 
            // tpChannelInfo
            // 
            this.tpChannelInfo.Controls.Add(this.dgvChannel);
            this.tpChannelInfo.Location = new System.Drawing.Point(4, 24);
            this.tpChannelInfo.Name = "tpChannelInfo";
            this.tpChannelInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpChannelInfo.Size = new System.Drawing.Size(1195, 609);
            this.tpChannelInfo.TabIndex = 4;
            this.tpChannelInfo.Text = "Channel Table";
            this.tpChannelInfo.UseVisualStyleBackColor = true;
            this.tpChannelInfo.Enter += new System.EventHandler(this.tpChannelInfo_Enter);
            // 
            // dgvChannel
            // 
            this.dgvChannel.AllowUserToAddRows = false;
            this.dgvChannel.AllowUserToDeleteRows = false;
            this.dgvChannel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChannel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column10,
            this.Column8,
            this.Column11,
            this.clmWeight,
            this.clmHiPass});
            this.dgvChannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChannel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChannel.Location = new System.Drawing.Point(3, 3);
            this.dgvChannel.Name = "dgvChannel";
            this.dgvChannel.RowHeadersVisible = false;
            this.dgvChannel.RowHeadersWidth = 62;
            this.dgvChannel.RowTemplate.Height = 23;
            this.dgvChannel.Size = new System.Drawing.Size(1189, 603);
            this.dgvChannel.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Location ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Channel Type";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Measurement Quantity";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Engineering Unit";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sensitivity";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Input Mode";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Input Range";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Sensor SN";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Max. sensor range";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Intergration";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // clmWeight
            // 
            this.clmWeight.HeaderText = "Control Weighting";
            this.clmWeight.MinimumWidth = 8;
            this.clmWeight.Name = "clmWeight";
            this.clmWeight.ReadOnly = true;
            // 
            // clmHiPass
            // 
            this.clmHiPass.HeaderText = "Hi-Pass Filter";
            this.clmHiPass.MinimumWidth = 8;
            this.clmHiPass.Name = "clmHiPass";
            // 
            // tpMergeInfo
            // 
            this.tpMergeInfo.Controls.Add(this.dgvMergeInfo);
            this.tpMergeInfo.Location = new System.Drawing.Point(4, 24);
            this.tpMergeInfo.Name = "tpMergeInfo";
            this.tpMergeInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpMergeInfo.Size = new System.Drawing.Size(1195, 609);
            this.tpMergeInfo.TabIndex = 7;
            this.tpMergeInfo.Text = "Merge Info";
            this.tpMergeInfo.UseVisualStyleBackColor = true;
            this.tpMergeInfo.Enter += new System.EventHandler(this.tpMergeInfo_Enter);
            // 
            // dgvMergeInfo
            // 
            this.dgvMergeInfo.AllowUserToAddRows = false;
            this.dgvMergeInfo.AllowUserToDeleteRows = false;
            this.dgvMergeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMergeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSourceFile,
            this.clmSourceLabel,
            this.clmCurrFile,
            this.clmCurrLabel});
            this.dgvMergeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMergeInfo.Location = new System.Drawing.Point(3, 3);
            this.dgvMergeInfo.Name = "dgvMergeInfo";
            this.dgvMergeInfo.ReadOnly = true;
            this.dgvMergeInfo.RowHeadersVisible = false;
            this.dgvMergeInfo.RowHeadersWidth = 62;
            this.dgvMergeInfo.Size = new System.Drawing.Size(1189, 603);
            this.dgvMergeInfo.TabIndex = 0;
            // 
            // clmSourceFile
            // 
            this.clmSourceFile.HeaderText = "Source File";
            this.clmSourceFile.MinimumWidth = 8;
            this.clmSourceFile.Name = "clmSourceFile";
            this.clmSourceFile.ReadOnly = true;
            this.clmSourceFile.Width = 150;
            // 
            // clmSourceLabel
            // 
            this.clmSourceLabel.HeaderText = "Channel Label";
            this.clmSourceLabel.MinimumWidth = 8;
            this.clmSourceLabel.Name = "clmSourceLabel";
            this.clmSourceLabel.ReadOnly = true;
            this.clmSourceLabel.Width = 150;
            // 
            // clmCurrFile
            // 
            this.clmCurrFile.HeaderText = "Current File";
            this.clmCurrFile.MinimumWidth = 8;
            this.clmCurrFile.Name = "clmCurrFile";
            this.clmCurrFile.ReadOnly = true;
            this.clmCurrFile.Width = 150;
            // 
            // clmCurrLabel
            // 
            this.clmCurrLabel.HeaderText = "Channel Label";
            this.clmCurrLabel.MinimumWidth = 8;
            this.clmCurrLabel.Name = "clmCurrLabel";
            this.clmCurrLabel.ReadOnly = true;
            this.clmCurrLabel.Width = 150;
            // 
            // tpTSDATInfo
            // 
            this.tpTSDATInfo.Controls.Add(this.tableLayoutPanel3);
            this.tpTSDATInfo.Location = new System.Drawing.Point(4, 24);
            this.tpTSDATInfo.Name = "tpTSDATInfo";
            this.tpTSDATInfo.Size = new System.Drawing.Size(1195, 609);
            this.tpTSDATInfo.TabIndex = 8;
            this.tpTSDATInfo.Text = "Time Stamp Data";
            this.tpTSDATInfo.UseVisualStyleBackColor = true;
            this.tpTSDATInfo.Enter += new System.EventHandler(this.tpTSDATInfo_Enter);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel3.Controls.Add(this.textBox2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgvCalculateTSDATInfo, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.dgvReadTSDATInfo, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel6, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.90099F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.70297F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.67327F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.72277F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1195, 609);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(743, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(449, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Calculating TSDAT File";
            // 
            // dgvCalculateTSDATInfo
            // 
            this.dgvCalculateTSDATInfo.AllowUserToAddRows = false;
            this.dgvCalculateTSDATInfo.AllowUserToDeleteRows = false;
            this.dgvCalculateTSDATInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalculateTSDATInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCalTSDATIndex,
            this.clmCalTSDATRead});
            this.dgvCalculateTSDATInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalculateTSDATInfo.Location = new System.Drawing.Point(743, 32);
            this.dgvCalculateTSDATInfo.Name = "dgvCalculateTSDATInfo";
            this.dgvCalculateTSDATInfo.ReadOnly = true;
            this.dgvCalculateTSDATInfo.RowHeadersVisible = false;
            this.dgvCalculateTSDATInfo.RowHeadersWidth = 62;
            this.tableLayoutPanel3.SetRowSpan(this.dgvCalculateTSDATInfo, 4);
            this.dgvCalculateTSDATInfo.Size = new System.Drawing.Size(449, 574);
            this.dgvCalculateTSDATInfo.TabIndex = 3;
            // 
            // clmCalTSDATIndex
            // 
            this.clmCalTSDATIndex.HeaderText = "Index Point";
            this.clmCalTSDATIndex.MinimumWidth = 8;
            this.clmCalTSDATIndex.Name = "clmCalTSDATIndex";
            this.clmCalTSDATIndex.ReadOnly = true;
            this.clmCalTSDATIndex.Width = 150;
            // 
            // clmCalTSDATRead
            // 
            this.clmCalTSDATRead.HeaderText = "Nanoseconds";
            this.clmCalTSDATRead.MinimumWidth = 8;
            this.clmCalTSDATRead.Name = "clmCalTSDATRead";
            this.clmCalTSDATRead.ReadOnly = true;
            this.clmCalTSDATRead.Width = 275;
            // 
            // dgvReadTSDATInfo
            // 
            this.dgvReadTSDATInfo.AllowUserToAddRows = false;
            this.dgvReadTSDATInfo.AllowUserToDeleteRows = false;
            this.dgvReadTSDATInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReadTSDATInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmReadTSDATIndex,
            this.clmReadTSDATData});
            this.dgvReadTSDATInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReadTSDATInfo.Location = new System.Drawing.Point(289, 32);
            this.dgvReadTSDATInfo.Name = "dgvReadTSDATInfo";
            this.dgvReadTSDATInfo.ReadOnly = true;
            this.dgvReadTSDATInfo.RowHeadersVisible = false;
            this.dgvReadTSDATInfo.RowHeadersWidth = 62;
            this.tableLayoutPanel3.SetRowSpan(this.dgvReadTSDATInfo, 4);
            this.dgvReadTSDATInfo.Size = new System.Drawing.Size(448, 574);
            this.dgvReadTSDATInfo.TabIndex = 0;
            // 
            // clmReadTSDATIndex
            // 
            this.clmReadTSDATIndex.HeaderText = "Index Point";
            this.clmReadTSDATIndex.MinimumWidth = 8;
            this.clmReadTSDATIndex.Name = "clmReadTSDATIndex";
            this.clmReadTSDATIndex.ReadOnly = true;
            this.clmReadTSDATIndex.Width = 150;
            // 
            // clmReadTSDATData
            // 
            this.clmReadTSDATData.HeaderText = "Nanoseconds";
            this.clmReadTSDATData.MinimumWidth = 8;
            this.clmReadTSDATData.Name = "clmReadTSDATData";
            this.clmReadTSDATData.ReadOnly = true;
            this.clmReadTSDATData.Width = 275;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.textBox5);
            this.flowLayoutPanel3.Controls.Add(this.tbTSDATFrameIndex);
            this.flowLayoutPanel3.Controls.Add(this.btnReadTSDAT);
            this.flowLayoutPanel3.Controls.Add(this.cbUseRecording);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 89);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(280, 166);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(8, 8);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(229, 40);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Read directly from the .tsdat file\r\nExample: startIndex,endIndex";
            // 
            // tbTSDATFrameIndex
            // 
            this.tbTSDATFrameIndex.Location = new System.Drawing.Point(8, 54);
            this.tbTSDATFrameIndex.Name = "tbTSDATFrameIndex";
            this.tbTSDATFrameIndex.Size = new System.Drawing.Size(219, 23);
            this.tbTSDATFrameIndex.TabIndex = 10;
            // 
            // btnReadTSDAT
            // 
            this.btnReadTSDAT.Location = new System.Drawing.Point(8, 83);
            this.btnReadTSDAT.Name = "btnReadTSDAT";
            this.btnReadTSDAT.Size = new System.Drawing.Size(110, 23);
            this.btnReadTSDAT.TabIndex = 3;
            this.btnReadTSDAT.Text = "Read TSDAT File";
            this.btnReadTSDAT.UseVisualStyleBackColor = true;
            this.btnReadTSDAT.Click += new System.EventHandler(this.btnReadTSDAT_Click);
            // 
            // cbUseRecording
            // 
            this.cbUseRecording.AutoSize = true;
            this.cbUseRecording.Location = new System.Drawing.Point(8, 112);
            this.cbUseRecording.Name = "cbUseRecording";
            this.cbUseRecording.Size = new System.Drawing.Size(102, 19);
            this.cbUseRecording.TabIndex = 5;
            this.cbUseRecording.Text = "Use Recording";
            this.cbUseRecording.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.textBox4);
            this.flowLayoutPanel4.Controls.Add(this.tbTSDATInput);
            this.flowLayoutPanel4.Controls.Add(this.btnCalculateTSDAT);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 261);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(280, 183);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(8, 8);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(229, 57);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Efficiently get .tsdat data at specified points\r\nExample: startIndex,endIndex";
            // 
            // tbTSDATInput
            // 
            this.tbTSDATInput.Location = new System.Drawing.Point(8, 71);
            this.tbTSDATInput.Name = "tbTSDATInput";
            this.tbTSDATInput.Size = new System.Drawing.Size(219, 23);
            this.tbTSDATInput.TabIndex = 0;
            // 
            // btnCalculateTSDAT
            // 
            this.btnCalculateTSDAT.Location = new System.Drawing.Point(8, 100);
            this.btnCalculateTSDAT.Name = "btnCalculateTSDAT";
            this.btnCalculateTSDAT.Size = new System.Drawing.Size(166, 23);
            this.btnCalculateTSDAT.TabIndex = 1;
            this.btnCalculateTSDAT.Text = "Get TSDAT data at points:";
            this.btnCalculateTSDAT.UseVisualStyleBackColor = true;
            this.btnCalculateTSDAT.Click += new System.EventHandler(this.btnCalculateTSDAT_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(289, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(448, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Reading TSDAT File";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.textBox3);
            this.flowLayoutPanel5.Controls.Add(this.btnGenTSDATFile);
            this.flowLayoutPanel5.Controls.Add(this.btnGenSatStat);
            this.flowLayoutPanel5.Controls.Add(this.btnGenTSTSDATCompare);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 450);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(280, 156);
            this.flowLayoutPanel5.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, 8);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(229, 41);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "May take several minutes depending on recording size";
            // 
            // btnGenTSDATFile
            // 
            this.btnGenTSDATFile.Location = new System.Drawing.Point(8, 55);
            this.btnGenTSDATFile.Name = "btnGenTSDATFile";
            this.btnGenTSDATFile.Size = new System.Drawing.Size(136, 27);
            this.btnGenTSDATFile.TabIndex = 2;
            this.btnGenTSDATFile.Text = "Generate TSDAT File";
            this.btnGenTSDATFile.UseVisualStyleBackColor = true;
            this.btnGenTSDATFile.Click += new System.EventHandler(this.btnGenTSDATFile_Click);
            // 
            // btnGenSatStat
            // 
            this.btnGenSatStat.Location = new System.Drawing.Point(8, 88);
            this.btnGenSatStat.Name = "btnGenSatStat";
            this.btnGenSatStat.Size = new System.Drawing.Size(175, 27);
            this.btnGenSatStat.TabIndex = 6;
            this.btnGenSatStat.Text = "Generate Satellite Status File";
            this.btnGenSatStat.UseVisualStyleBackColor = true;
            this.btnGenSatStat.Click += new System.EventHandler(this.btnGenSatStat_Click);
            // 
            // btnGenTSTSDATCompare
            // 
            this.btnGenTSTSDATCompare.Location = new System.Drawing.Point(8, 121);
            this.btnGenTSTSDATCompare.Name = "btnGenTSTSDATCompare";
            this.btnGenTSTSDATCompare.Size = new System.Drawing.Size(219, 27);
            this.btnGenTSTSDATCompare.TabIndex = 7;
            this.btnGenTSTSDATCompare.Text = "Generate TS and TSDAT Compare File";
            this.btnGenTSTSDATCompare.UseVisualStyleBackColor = true;
            this.btnGenTSTSDATCompare.Click += new System.EventHandler(this.btnGenTSTSDATCompare_Click);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.lbSegmentLost);
            this.flowLayoutPanel6.Controls.Add(this.cbUTCFormatTSDAT);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.SetRowSpan(this.flowLayoutPanel6, 2);
            this.flowLayoutPanel6.Size = new System.Drawing.Size(280, 80);
            this.flowLayoutPanel6.TabIndex = 7;
            // 
            // lbSegmentLost
            // 
            this.lbSegmentLost.AutoSize = true;
            this.lbSegmentLost.Location = new System.Drawing.Point(8, 5);
            this.lbSegmentLost.Name = "lbSegmentLost";
            this.lbSegmentLost.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbSegmentLost.Size = new System.Drawing.Size(154, 20);
            this.lbSegmentLost.TabIndex = 9;
            this.lbSegmentLost.Text = "Time Stamp Segment Lost:  ";
            // 
            // cbUTCFormatTSDAT
            // 
            this.cbUTCFormatTSDAT.AutoSize = true;
            this.cbUTCFormatTSDAT.Location = new System.Drawing.Point(8, 28);
            this.cbUTCFormatTSDAT.Name = "cbUTCFormatTSDAT";
            this.cbUTCFormatTSDAT.Size = new System.Drawing.Size(110, 19);
            this.cbUTCFormatTSDAT.TabIndex = 7;
            this.cbUTCFormatTSDAT.Text = "Use UTC Format";
            this.cbUTCFormatTSDAT.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.cbMergeAllDRD, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnOpen, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbFile, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnCopy, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExport, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCombineDRDFiles, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbOnlyDATX, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblErrorMSG, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1209, 705);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // cbMergeAllDRD
            // 
            this.cbMergeAllDRD.AutoSize = true;
            this.cbMergeAllDRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMergeAllDRD.Location = new System.Drawing.Point(1028, 34);
            this.cbMergeAllDRD.Name = "cbMergeAllDRD";
            this.cbMergeAllDRD.Size = new System.Drawing.Size(178, 25);
            this.cbMergeAllDRD.TabIndex = 8;
            this.cbMergeAllDRD.Text = "Merge all DRD files in folder";
            this.cbMergeAllDRD.UseVisualStyleBackColor = true;
            this.cbMergeAllDRD.Visible = false;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(794, 4);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(76, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(794, 35);
            this.btnExport.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(76, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCombineDRDFiles
            // 
            this.btnCombineDRDFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCombineDRDFiles.Location = new System.Drawing.Point(890, 4);
            this.btnCombineDRDFiles.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnCombineDRDFiles.Name = "btnCombineDRDFiles";
            this.btnCombineDRDFiles.Size = new System.Drawing.Size(125, 23);
            this.btnCombineDRDFiles.TabIndex = 5;
            this.btnCombineDRDFiles.Text = "Convert DRD Files";
            this.btnCombineDRDFiles.UseVisualStyleBackColor = true;
            this.btnCombineDRDFiles.Click += new System.EventHandler(this.btnCombineDRDFiles_Click);
            // 
            // cbOnlyDATX
            // 
            this.cbOnlyDATX.AutoSize = true;
            this.cbOnlyDATX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbOnlyDATX.Location = new System.Drawing.Point(1028, 3);
            this.cbOnlyDATX.Name = "cbOnlyDATX";
            this.cbOnlyDATX.Size = new System.Drawing.Size(178, 25);
            this.cbOnlyDATX.TabIndex = 7;
            this.cbOnlyDATX.Text = "Convert with only DATX";
            this.cbOnlyDATX.UseVisualStyleBackColor = true;
            this.cbOnlyDATX.Visible = false;
            // 
            // lblErrorMSG
            // 
            this.lblErrorMSG.AutoSize = true;
            this.lblErrorMSG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblErrorMSG.Location = new System.Drawing.Point(3, 34);
            this.lblErrorMSG.Margin = new System.Windows.Forms.Padding(3);
            this.lblErrorMSG.Name = "lblErrorMSG";
            this.lblErrorMSG.Padding = new System.Windows.Forms.Padding(5);
            this.lblErrorMSG.Size = new System.Drawing.Size(658, 25);
            this.lblErrorMSG.TabIndex = 9;
            // 
            // bgWorkerDRDCombine
            // 
            this.bgWorkerDRDCombine.WorkerReportsProgress = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Property";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Value";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "High Abort";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "High Alarm";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Low Alarm";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Low Alarm";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Location ID";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Channel Type";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Measurement Quantity";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Engineering Unit";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Sensitivity";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Input Mode";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Input Range";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Sensor SN";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 150;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Max. sensor range";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 150;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Intergration";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 150;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Control Weighting";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 150;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Source File";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 150;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "Channel Label";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 150;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "Current File";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 150;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.HeaderText = "Channel Label";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 150;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.HeaderText = "Channel Label";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 150;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.HeaderText = "Index Point";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 150;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.HeaderText = "Nanoseconds";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 275;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.HeaderText = "Index Point";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 150;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.HeaderText = "Nanoseconds";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 275;
            // 
            // bgWorkerDRDConvert
            // 
            this.bgWorkerDRDConvert.WorkerReportsProgress = true;
            // 
            // ATFXReaderDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 705);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ATFXReaderDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CI Data File Reader API C# Demo";
            this.tabControl1.ResumeLayout(false);
            this.tpRecInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecInfo)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tpSignalDataInfo.ResumeLayout(false);
            this.tlpSignalDataInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSignalDataInfo)).EndInit();
            this.flpSignalChanges.ResumeLayout(false);
            this.flpSignalChanges.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tpChannelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChannel)).EndInit();
            this.tpMergeInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMergeInfo)).EndInit();
            this.tpTSDATInfo.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculateTSDATInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadTSDATInfo)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRecInfo;
        private System.Windows.Forms.DataGridView dgvRecInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage tpChannelInfo;
        private System.Windows.Forms.DataGridView dgvChannel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabPage tpSignalDataInfo;
        private System.Windows.Forms.TableLayoutPanel tlpSignalDataInfo;
        private System.Windows.Forms.ListBox lbSignalDataInfo;
        private System.Windows.Forms.DataGridView dgvSignalDataInfo;
        private System.Windows.Forms.ListBox lbSignalParameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSignalProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSignalPropValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHighAbort;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHighAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLowAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLowAbort;
        private System.Windows.Forms.TabPage tpMergeInfo;
        private System.Windows.Forms.DataGridView dgvMergeInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSourceFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSourceLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurrFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurrLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lbRecordingDataInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnShowRecordProp;
        private System.Windows.Forms.Button btnShowDateTimeNanoUTC;
        private System.Windows.Forms.Button btnShowDateTimeNanoLocal;
        private System.Windows.Forms.FlowLayoutPanel flpSignalChanges;
        private System.Windows.Forms.ComboBox cbSpecScaleType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEngiUnit;
        private System.Windows.Forms.TabPage tpTSDATInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvReadTSDATInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox tbTSDATInput;
        private System.Windows.Forms.Button btnCalculateTSDAT;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnGenTSDATFile;
        private System.Windows.Forms.Button btnReadTSDAT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dgvCalculateTSDATInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbUseRecording;
        private System.Windows.Forms.CheckBox cbUTCFormatTSDAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCalTSDATIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCalTSDATRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReadTSDATIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReadTSDATData;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbTSDATFrameIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSignalFrameIndex;
        private System.Windows.Forms.Label lbSegmentLost;
        private System.Windows.Forms.Button btnGenSatStat;
        private System.Windows.Forms.Button btnGenTSTSDATCompare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHiPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Button btnCombineDRDFiles;
        private System.ComponentModel.BackgroundWorker bgWorkerDRDCombine;
        private System.ComponentModel.BackgroundWorker bgWorkerDRDConvert;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSignalBasic;
        private System.Windows.Forms.Button btnSignalAdv;
        private System.Windows.Forms.Button btnSignalFrame;
        private System.Windows.Forms.Button btnSignalParam;
        private System.Windows.Forms.Button btnShowGeneratedTime;
        private System.Windows.Forms.Button btnShowtsdatUTC;
        private System.Windows.Forms.Button btnExportCSV2;
        private System.Windows.Forms.CheckBox cbMergeAllDRD;
        private System.Windows.Forms.CheckBox cbOnlyDATX;
        private System.Windows.Forms.Label lblErrorMSG;
    }
}

