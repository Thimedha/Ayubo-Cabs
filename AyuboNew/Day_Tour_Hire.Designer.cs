namespace AyuboNew
{
    partial class Day_Tour_Hire
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
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnDClear = new System.Windows.Forms.Button();
            this.btnDDelete = new System.Windows.Forms.Button();
            this.btnDUpdate = new System.Windows.Forms.Button();
            this.btnDInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDriverCharge = new System.Windows.Forms.TextBox();
            this.txtWaitingCharge = new System.Windows.Forms.TextBox();
            this.txtMaxHours = new System.Windows.Forms.TextBox();
            this.txtExtraKmCharge = new System.Windows.Forms.TextBox();
            this.txtMaxKmLimit = new System.Windows.Forms.TextBox();
            this.txtBasicKmCharge = new System.Windows.Forms.TextBox();
            this.cmbVehicleNo = new System.Windows.Forms.ComboBox();
            this.txtTotalHire = new System.Windows.Forms.TextBox();
            this.txtEndKmReading = new System.Windows.Forms.TextBox();
            this.txtStartKmReading = new System.Windows.Forms.TextBox();
            this.txtDayTourID = new System.Windows.Forms.TextBox();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.cmbPackage = new System.Windows.Forms.ComboBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblDayTourID = new System.Windows.Forms.Label();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientContactNo = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartKmReading = new System.Windows.Forms.Label();
            this.lblWaitingCharge = new System.Windows.Forms.Label();
            this.lblMaxHours = new System.Windows.Forms.Label();
            this.lblExtraKmLimit = new System.Windows.Forms.Label();
            this.lblMaxKmLimit = new System.Windows.Forms.Label();
            this.lblBasicCharge = new System.Windows.Forms.Label();
            this.lblDriverCharge = new System.Windows.Forms.Label();
            this.lblTotalHire = new System.Windows.Forms.Label();
            this.lblEndKmReading = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDCalculate = new System.Windows.Forms.Button();
            this.btnDView = new System.Windows.Forms.Button();
            this.dgvLongTour = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLongTour)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(1, 486);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(123, 33);
            this.btnMainMenu.TabIndex = 18;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnDClear
            // 
            this.btnDClear.BackColor = System.Drawing.Color.DimGray;
            this.btnDClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDClear.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDClear.ForeColor = System.Drawing.Color.White;
            this.btnDClear.Location = new System.Drawing.Point(1, 269);
            this.btnDClear.Name = "btnDClear";
            this.btnDClear.Size = new System.Drawing.Size(123, 33);
            this.btnDClear.TabIndex = 14;
            this.btnDClear.Text = "Clear";
            this.btnDClear.UseVisualStyleBackColor = false;
            this.btnDClear.Click += new System.EventHandler(this.btnDClear_Click);
            // 
            // btnDDelete
            // 
            this.btnDDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDDelete.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDDelete.ForeColor = System.Drawing.Color.White;
            this.btnDDelete.Location = new System.Drawing.Point(1, 230);
            this.btnDDelete.Name = "btnDDelete";
            this.btnDDelete.Size = new System.Drawing.Size(123, 33);
            this.btnDDelete.TabIndex = 13;
            this.btnDDelete.Text = "Delete";
            this.btnDDelete.UseVisualStyleBackColor = false;
            this.btnDDelete.Click += new System.EventHandler(this.btnDDelete_Click);
            // 
            // btnDUpdate
            // 
            this.btnDUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnDUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDUpdate.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDUpdate.ForeColor = System.Drawing.Color.White;
            this.btnDUpdate.Location = new System.Drawing.Point(1, 191);
            this.btnDUpdate.Name = "btnDUpdate";
            this.btnDUpdate.Size = new System.Drawing.Size(123, 33);
            this.btnDUpdate.TabIndex = 12;
            this.btnDUpdate.Text = "Update";
            this.btnDUpdate.UseVisualStyleBackColor = false;
            this.btnDUpdate.Click += new System.EventHandler(this.btnDUpdate_Click);
            // 
            // btnDInsert
            // 
            this.btnDInsert.BackColor = System.Drawing.Color.DimGray;
            this.btnDInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDInsert.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDInsert.ForeColor = System.Drawing.Color.White;
            this.btnDInsert.Location = new System.Drawing.Point(1, 152);
            this.btnDInsert.Name = "btnDInsert";
            this.btnDInsert.Size = new System.Drawing.Size(123, 33);
            this.btnDInsert.TabIndex = 11;
            this.btnDInsert.Text = "Insert";
            this.btnDInsert.UseVisualStyleBackColor = false;
            this.btnDInsert.Click += new System.EventHandler(this.btnDInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 312);
            this.label1.TabIndex = 1;
            this.label1.Text = "D\r\na\r\ny\r\n \r\nT\r\no\r\nu\r\nr";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.txtDriverCharge);
            this.panel1.Controls.Add(this.txtWaitingCharge);
            this.panel1.Controls.Add(this.txtMaxHours);
            this.panel1.Controls.Add(this.txtExtraKmCharge);
            this.panel1.Controls.Add(this.txtMaxKmLimit);
            this.panel1.Controls.Add(this.txtBasicKmCharge);
            this.panel1.Controls.Add(this.cmbVehicleNo);
            this.panel1.Controls.Add(this.txtTotalHire);
            this.panel1.Controls.Add(this.txtEndKmReading);
            this.panel1.Controls.Add(this.txtStartKmReading);
            this.panel1.Controls.Add(this.txtDayTourID);
            this.panel1.Controls.Add(this.dtpEndTime);
            this.panel1.Controls.Add(this.cmbPackage);
            this.panel1.Controls.Add(this.dtpStartTime);
            this.panel1.Controls.Add(this.txtClient);
            this.panel1.Controls.Add(this.txtContactNo);
            this.panel1.Controls.Add(this.lblDayTourID);
            this.panel1.Controls.Add(this.lblPackage);
            this.panel1.Controls.Add(this.lblVehicleNo);
            this.panel1.Controls.Add(this.lblClientName);
            this.panel1.Controls.Add(this.lblClientContactNo);
            this.panel1.Controls.Add(this.lblStartTime);
            this.panel1.Controls.Add(this.lblEndTime);
            this.panel1.Controls.Add(this.lblStartKmReading);
            this.panel1.Controls.Add(this.lblWaitingCharge);
            this.panel1.Controls.Add(this.lblMaxHours);
            this.panel1.Controls.Add(this.lblExtraKmLimit);
            this.panel1.Controls.Add(this.lblMaxKmLimit);
            this.panel1.Controls.Add(this.lblBasicCharge);
            this.panel1.Controls.Add(this.lblDriverCharge);
            this.panel1.Controls.Add(this.lblTotalHire);
            this.panel1.Controls.Add(this.lblEndKmReading);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnDCalculate);
            this.panel1.Controls.Add(this.btnDView);
            this.panel1.Controls.Add(this.dgvLongTour);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 794);
            this.panel1.TabIndex = 0;
            // 
            // txtDriverCharge
            // 
            this.txtDriverCharge.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDriverCharge.Enabled = false;
            this.txtDriverCharge.Location = new System.Drawing.Point(174, 483);
            this.txtDriverCharge.Margin = new System.Windows.Forms.Padding(2);
            this.txtDriverCharge.Name = "txtDriverCharge";
            this.txtDriverCharge.Size = new System.Drawing.Size(85, 20);
            this.txtDriverCharge.TabIndex = 0;
            // 
            // txtWaitingCharge
            // 
            this.txtWaitingCharge.Cursor = System.Windows.Forms.Cursors.No;
            this.txtWaitingCharge.Enabled = false;
            this.txtWaitingCharge.Location = new System.Drawing.Point(787, 483);
            this.txtWaitingCharge.Margin = new System.Windows.Forms.Padding(2);
            this.txtWaitingCharge.Name = "txtWaitingCharge";
            this.txtWaitingCharge.Size = new System.Drawing.Size(85, 20);
            this.txtWaitingCharge.TabIndex = 0;
            // 
            // txtMaxHours
            // 
            this.txtMaxHours.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMaxHours.Enabled = false;
            this.txtMaxHours.Location = new System.Drawing.Point(653, 483);
            this.txtMaxHours.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxHours.Name = "txtMaxHours";
            this.txtMaxHours.Size = new System.Drawing.Size(85, 20);
            this.txtMaxHours.TabIndex = 0;
            // 
            // txtExtraKmCharge
            // 
            this.txtExtraKmCharge.Cursor = System.Windows.Forms.Cursors.No;
            this.txtExtraKmCharge.Enabled = false;
            this.txtExtraKmCharge.Location = new System.Drawing.Point(529, 483);
            this.txtExtraKmCharge.Margin = new System.Windows.Forms.Padding(2);
            this.txtExtraKmCharge.Name = "txtExtraKmCharge";
            this.txtExtraKmCharge.Size = new System.Drawing.Size(85, 20);
            this.txtExtraKmCharge.TabIndex = 0;
            // 
            // txtMaxKmLimit
            // 
            this.txtMaxKmLimit.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMaxKmLimit.Enabled = false;
            this.txtMaxKmLimit.Location = new System.Drawing.Point(417, 483);
            this.txtMaxKmLimit.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxKmLimit.Name = "txtMaxKmLimit";
            this.txtMaxKmLimit.Size = new System.Drawing.Size(85, 20);
            this.txtMaxKmLimit.TabIndex = 0;
            // 
            // txtBasicKmCharge
            // 
            this.txtBasicKmCharge.Cursor = System.Windows.Forms.Cursors.No;
            this.txtBasicKmCharge.Enabled = false;
            this.txtBasicKmCharge.Location = new System.Drawing.Point(298, 483);
            this.txtBasicKmCharge.Margin = new System.Windows.Forms.Padding(2);
            this.txtBasicKmCharge.Name = "txtBasicKmCharge";
            this.txtBasicKmCharge.Size = new System.Drawing.Size(81, 20);
            this.txtBasicKmCharge.TabIndex = 0;
            // 
            // cmbVehicleNo
            // 
            this.cmbVehicleNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbVehicleNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbVehicleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVehicleNo.FormattingEnabled = true;
            this.cmbVehicleNo.Location = new System.Drawing.Point(454, 101);
            this.cmbVehicleNo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVehicleNo.Name = "cmbVehicleNo";
            this.cmbVehicleNo.Size = new System.Drawing.Size(314, 24);
            this.cmbVehicleNo.TabIndex = 3;
            // 
            // txtTotalHire
            // 
            this.txtTotalHire.Enabled = false;
            this.txtTotalHire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHire.Location = new System.Drawing.Point(454, 403);
            this.txtTotalHire.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalHire.Name = "txtTotalHire";
            this.txtTotalHire.Size = new System.Drawing.Size(314, 22);
            this.txtTotalHire.TabIndex = 0;
            // 
            // txtEndKmReading
            // 
            this.txtEndKmReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndKmReading.Location = new System.Drawing.Point(454, 358);
            this.txtEndKmReading.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndKmReading.Name = "txtEndKmReading";
            this.txtEndKmReading.Size = new System.Drawing.Size(314, 22);
            this.txtEndKmReading.TabIndex = 9;
            // 
            // txtStartKmReading
            // 
            this.txtStartKmReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartKmReading.Location = new System.Drawing.Point(454, 312);
            this.txtStartKmReading.Margin = new System.Windows.Forms.Padding(2);
            this.txtStartKmReading.Name = "txtStartKmReading";
            this.txtStartKmReading.Size = new System.Drawing.Size(314, 22);
            this.txtStartKmReading.TabIndex = 8;
            // 
            // txtDayTourID
            // 
            this.txtDayTourID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDayTourID.Location = new System.Drawing.Point(454, 10);
            this.txtDayTourID.Margin = new System.Windows.Forms.Padding(2);
            this.txtDayTourID.Name = "txtDayTourID";
            this.txtDayTourID.Size = new System.Drawing.Size(314, 22);
            this.txtDayTourID.TabIndex = 1;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(454, 275);
            this.dtpEndTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(314, 22);
            this.dtpEndTime.TabIndex = 7;
            // 
            // cmbPackage
            // 
            this.cmbPackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPackage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Location = new System.Drawing.Point(454, 54);
            this.cmbPackage.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(314, 24);
            this.cmbPackage.TabIndex = 2;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(454, 237);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(314, 22);
            this.dtpStartTime.TabIndex = 6;
            // 
            // txtClient
            // 
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClient.Location = new System.Drawing.Point(454, 144);
            this.txtClient.Margin = new System.Windows.Forms.Padding(2);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(314, 22);
            this.txtClient.TabIndex = 4;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(454, 188);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(314, 22);
            this.txtContactNo.TabIndex = 5;
            // 
            // lblDayTourID
            // 
            this.lblDayTourID.AutoSize = true;
            this.lblDayTourID.BackColor = System.Drawing.Color.Transparent;
            this.lblDayTourID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayTourID.ForeColor = System.Drawing.Color.White;
            this.lblDayTourID.Location = new System.Drawing.Point(253, 13);
            this.lblDayTourID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDayTourID.Name = "lblDayTourID";
            this.lblDayTourID.Size = new System.Drawing.Size(88, 21);
            this.lblDayTourID.TabIndex = 46;
            this.lblDayTourID.Text = "Day Tour ID";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.BackColor = System.Drawing.Color.Transparent;
            this.lblPackage.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage.ForeColor = System.Drawing.Color.White;
            this.lblPackage.Location = new System.Drawing.Point(253, 60);
            this.lblPackage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(70, 21);
            this.lblPackage.TabIndex = 47;
            this.lblPackage.Text = "Package";
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleNo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleNo.ForeColor = System.Drawing.Color.White;
            this.lblVehicleNo.Location = new System.Drawing.Point(253, 101);
            this.lblVehicleNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(81, 21);
            this.lblVehicleNo.TabIndex = 48;
            this.lblVehicleNo.Text = "Vehicle No";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.Transparent;
            this.lblClientName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.Color.White;
            this.lblClientName.Location = new System.Drawing.Point(253, 148);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(49, 21);
            this.lblClientName.TabIndex = 49;
            this.lblClientName.Text = "Client";
            // 
            // lblClientContactNo
            // 
            this.lblClientContactNo.AutoSize = true;
            this.lblClientContactNo.BackColor = System.Drawing.Color.Transparent;
            this.lblClientContactNo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientContactNo.ForeColor = System.Drawing.Color.White;
            this.lblClientContactNo.Location = new System.Drawing.Point(253, 189);
            this.lblClientContactNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientContactNo.Name = "lblClientContactNo";
            this.lblClientContactNo.Size = new System.Drawing.Size(84, 21);
            this.lblClientContactNo.TabIndex = 50;
            this.lblClientContactNo.Text = "Contact No";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.BackColor = System.Drawing.Color.Transparent;
            this.lblStartTime.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.ForeColor = System.Drawing.Color.White;
            this.lblStartTime.Location = new System.Drawing.Point(253, 241);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(81, 21);
            this.lblStartTime.TabIndex = 51;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.BackColor = System.Drawing.Color.Transparent;
            this.lblEndTime.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.ForeColor = System.Drawing.Color.White;
            this.lblEndTime.Location = new System.Drawing.Point(253, 278);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(75, 21);
            this.lblEndTime.TabIndex = 52;
            this.lblEndTime.Text = "End Time";
            // 
            // lblStartKmReading
            // 
            this.lblStartKmReading.AutoSize = true;
            this.lblStartKmReading.BackColor = System.Drawing.Color.Transparent;
            this.lblStartKmReading.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartKmReading.ForeColor = System.Drawing.Color.White;
            this.lblStartKmReading.Location = new System.Drawing.Point(253, 312);
            this.lblStartKmReading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartKmReading.Name = "lblStartKmReading";
            this.lblStartKmReading.Size = new System.Drawing.Size(132, 21);
            this.lblStartKmReading.TabIndex = 53;
            this.lblStartKmReading.Text = "Start Km Reading";
            // 
            // lblWaitingCharge
            // 
            this.lblWaitingCharge.AutoSize = true;
            this.lblWaitingCharge.BackColor = System.Drawing.Color.Transparent;
            this.lblWaitingCharge.Cursor = System.Windows.Forms.Cursors.No;
            this.lblWaitingCharge.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitingCharge.ForeColor = System.Drawing.Color.White;
            this.lblWaitingCharge.Location = new System.Drawing.Point(790, 505);
            this.lblWaitingCharge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWaitingCharge.Name = "lblWaitingCharge";
            this.lblWaitingCharge.Size = new System.Drawing.Size(84, 16);
            this.lblWaitingCharge.TabIndex = 55;
            this.lblWaitingCharge.Text = "Waiting Charge";
            // 
            // lblMaxHours
            // 
            this.lblMaxHours.AutoSize = true;
            this.lblMaxHours.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxHours.Cursor = System.Windows.Forms.Cursors.No;
            this.lblMaxHours.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxHours.ForeColor = System.Drawing.Color.White;
            this.lblMaxHours.Location = new System.Drawing.Point(666, 504);
            this.lblMaxHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxHours.Name = "lblMaxHours";
            this.lblMaxHours.Size = new System.Drawing.Size(60, 16);
            this.lblMaxHours.TabIndex = 55;
            this.lblMaxHours.Text = "Max Hours";
            // 
            // lblExtraKmLimit
            // 
            this.lblExtraKmLimit.AutoSize = true;
            this.lblExtraKmLimit.BackColor = System.Drawing.Color.Transparent;
            this.lblExtraKmLimit.Cursor = System.Windows.Forms.Cursors.No;
            this.lblExtraKmLimit.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraKmLimit.ForeColor = System.Drawing.Color.White;
            this.lblExtraKmLimit.Location = new System.Drawing.Point(531, 504);
            this.lblExtraKmLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtraKmLimit.Name = "lblExtraKmLimit";
            this.lblExtraKmLimit.Size = new System.Drawing.Size(79, 16);
            this.lblExtraKmLimit.TabIndex = 55;
            this.lblExtraKmLimit.Text = "Extra Km Limit";
            // 
            // lblMaxKmLimit
            // 
            this.lblMaxKmLimit.AutoSize = true;
            this.lblMaxKmLimit.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxKmLimit.Cursor = System.Windows.Forms.Cursors.No;
            this.lblMaxKmLimit.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxKmLimit.ForeColor = System.Drawing.Color.White;
            this.lblMaxKmLimit.Location = new System.Drawing.Point(423, 505);
            this.lblMaxKmLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxKmLimit.Name = "lblMaxKmLimit";
            this.lblMaxKmLimit.Size = new System.Drawing.Size(75, 16);
            this.lblMaxKmLimit.TabIndex = 55;
            this.lblMaxKmLimit.Text = "Max Km Limit";
            // 
            // lblBasicCharge
            // 
            this.lblBasicCharge.AutoSize = true;
            this.lblBasicCharge.BackColor = System.Drawing.Color.Transparent;
            this.lblBasicCharge.Cursor = System.Windows.Forms.Cursors.No;
            this.lblBasicCharge.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicCharge.ForeColor = System.Drawing.Color.White;
            this.lblBasicCharge.Location = new System.Drawing.Point(304, 505);
            this.lblBasicCharge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBasicCharge.Name = "lblBasicCharge";
            this.lblBasicCharge.Size = new System.Drawing.Size(72, 16);
            this.lblBasicCharge.TabIndex = 55;
            this.lblBasicCharge.Text = "Basic Charge";
            // 
            // lblDriverCharge
            // 
            this.lblDriverCharge.AutoSize = true;
            this.lblDriverCharge.BackColor = System.Drawing.Color.Transparent;
            this.lblDriverCharge.Cursor = System.Windows.Forms.Cursors.No;
            this.lblDriverCharge.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverCharge.ForeColor = System.Drawing.Color.White;
            this.lblDriverCharge.Location = new System.Drawing.Point(178, 503);
            this.lblDriverCharge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDriverCharge.Name = "lblDriverCharge";
            this.lblDriverCharge.Size = new System.Drawing.Size(75, 16);
            this.lblDriverCharge.TabIndex = 55;
            this.lblDriverCharge.Text = "Driver Charge";
            // 
            // lblTotalHire
            // 
            this.lblTotalHire.AutoSize = true;
            this.lblTotalHire.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalHire.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHire.ForeColor = System.Drawing.Color.White;
            this.lblTotalHire.Location = new System.Drawing.Point(253, 403);
            this.lblTotalHire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalHire.Name = "lblTotalHire";
            this.lblTotalHire.Size = new System.Drawing.Size(75, 21);
            this.lblTotalHire.TabIndex = 55;
            this.lblTotalHire.Text = "Total Hire";
            // 
            // lblEndKmReading
            // 
            this.lblEndKmReading.AutoSize = true;
            this.lblEndKmReading.BackColor = System.Drawing.Color.Transparent;
            this.lblEndKmReading.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndKmReading.ForeColor = System.Drawing.Color.White;
            this.lblEndKmReading.Location = new System.Drawing.Point(253, 358);
            this.lblEndKmReading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndKmReading.Name = "lblEndKmReading";
            this.lblEndKmReading.Size = new System.Drawing.Size(126, 21);
            this.lblEndKmReading.TabIndex = 54;
            this.lblEndKmReading.Text = "End Km Reading";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(454, 548);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 20);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnDCalculate
            // 
            this.btnDCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDCalculate.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDCalculate.Location = new System.Drawing.Point(556, 441);
            this.btnDCalculate.Name = "btnDCalculate";
            this.btnDCalculate.Size = new System.Drawing.Size(112, 24);
            this.btnDCalculate.TabIndex = 10;
            this.btnDCalculate.Text = "Calculate";
            this.btnDCalculate.UseVisualStyleBackColor = true;
            this.btnDCalculate.Click += new System.EventHandler(this.btnDCalculate_Click);
            // 
            // btnDView
            // 
            this.btnDView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDView.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDView.Location = new System.Drawing.Point(655, 548);
            this.btnDView.Name = "btnDView";
            this.btnDView.Size = new System.Drawing.Size(83, 20);
            this.btnDView.TabIndex = 17;
            this.btnDView.Text = "View";
            this.btnDView.UseVisualStyleBackColor = true;
            this.btnDView.Click += new System.EventHandler(this.btnDView_Click);
            // 
            // dgvLongTour
            // 
            this.dgvLongTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLongTour.Location = new System.Drawing.Point(4, 573);
            this.dgvLongTour.Name = "dgvLongTour";
            this.dgvLongTour.RowHeadersWidth = 51;
            this.dgvLongTour.Size = new System.Drawing.Size(1036, 219);
            this.dgvLongTour.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnMainMenu);
            this.panel3.Controls.Add(this.btnDClear);
            this.panel3.Controls.Add(this.btnDDelete);
            this.panel3.Controls.Add(this.btnDUpdate);
            this.panel3.Controls.Add(this.btnDInsert);
            this.panel3.Location = new System.Drawing.Point(911, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 563);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 564);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AyuboNew.Properties.Resources.SGN_09_21_2022_1663705436108;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(8, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 96);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Day_Tour_Hire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1061, 807);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Day_Tour_Hire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day_Tour_Hire";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLongTour)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnDClear;
        private System.Windows.Forms.Button btnDDelete;
        private System.Windows.Forms.Button btnDUpdate;
        private System.Windows.Forms.Button btnDInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDayTourID;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientContactNo;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartKmReading;
        private System.Windows.Forms.Label lblTotalHire;
        private System.Windows.Forms.Label lblEndKmReading;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDCalculate;
        private System.Windows.Forms.Button btnDView;
        private System.Windows.Forms.DataGridView dgvLongTour;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbVehicleNo;
        private System.Windows.Forms.TextBox txtTotalHire;
        private System.Windows.Forms.TextBox txtEndKmReading;
        private System.Windows.Forms.TextBox txtStartKmReading;
        private System.Windows.Forms.TextBox txtDayTourID;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.ComboBox cmbPackage;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtDriverCharge;
        private System.Windows.Forms.TextBox txtWaitingCharge;
        private System.Windows.Forms.TextBox txtMaxHours;
        private System.Windows.Forms.TextBox txtExtraKmCharge;
        private System.Windows.Forms.TextBox txtMaxKmLimit;
        private System.Windows.Forms.TextBox txtBasicKmCharge;
        private System.Windows.Forms.Label lblBasicCharge;
        private System.Windows.Forms.Label lblDriverCharge;
        private System.Windows.Forms.Label lblWaitingCharge;
        private System.Windows.Forms.Label lblMaxHours;
        private System.Windows.Forms.Label lblExtraKmLimit;
        private System.Windows.Forms.Label lblMaxKmLimit;
    }
}