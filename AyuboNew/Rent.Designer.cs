namespace AyuboNew
{
    partial class Rent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtDriverCharge = new System.Windows.Forms.TextBox();
            this.txtDailyRent = new System.Windows.Forms.TextBox();
            this.txtWeeklyRent = new System.Windows.Forms.TextBox();
            this.txtMonthlyRent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbWithoutDriver = new System.Windows.Forms.RadioButton();
            this.rdbWithDriver = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbVehicleNo = new System.Windows.Forms.ComboBox();
            this.txtTotalRent = new System.Windows.Forms.TextBox();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.lblRentID = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.lblRentDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalRent = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.dgvRent = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRClear = new System.Windows.Forms.Button();
            this.btnRDelete = new System.Windows.Forms.Button();
            this.btnRUpdate = new System.Windows.Forms.Button();
            this.btnRInsert = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnMainMenu);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.txtDriverCharge);
            this.panel1.Controls.Add(this.txtDailyRent);
            this.panel1.Controls.Add(this.txtWeeklyRent);
            this.panel1.Controls.Add(this.txtMonthlyRent);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.cmbVehicleNo);
            this.panel1.Controls.Add(this.txtTotalRent);
            this.panel1.Controls.Add(this.txtRentID);
            this.panel1.Controls.Add(this.txtClient);
            this.panel1.Controls.Add(this.txtContactNo);
            this.panel1.Controls.Add(this.dtpReturnDate);
            this.panel1.Controls.Add(this.dtpRentDate);
            this.panel1.Controls.Add(this.lblRentID);
            this.panel1.Controls.Add(this.lblClient);
            this.panel1.Controls.Add(this.lblContactNo);
            this.panel1.Controls.Add(this.lblVehicleNo);
            this.panel1.Controls.Add(this.lblRentDate);
            this.panel1.Controls.Add(this.lblReturnDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTotalRent);
            this.panel1.Controls.Add(this.lblDriver);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.dgvRent);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 655);
            this.panel1.TabIndex = 0;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(598, 430);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(103, 32);
            this.btnMainMenu.TabIndex = 16;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DarkGray;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.Location = new System.Drawing.Point(381, 339);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 30);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtDriverCharge
            // 
            this.txtDriverCharge.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDriverCharge.Enabled = false;
            this.txtDriverCharge.Location = new System.Drawing.Point(169, 382);
            this.txtDriverCharge.Margin = new System.Windows.Forms.Padding(2);
            this.txtDriverCharge.Name = "txtDriverCharge";
            this.txtDriverCharge.ReadOnly = true;
            this.txtDriverCharge.Size = new System.Drawing.Size(77, 20);
            this.txtDriverCharge.TabIndex = 36;
            // 
            // txtDailyRent
            // 
            this.txtDailyRent.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDailyRent.Enabled = false;
            this.txtDailyRent.Location = new System.Drawing.Point(274, 382);
            this.txtDailyRent.Margin = new System.Windows.Forms.Padding(2);
            this.txtDailyRent.Name = "txtDailyRent";
            this.txtDailyRent.ReadOnly = true;
            this.txtDailyRent.Size = new System.Drawing.Size(77, 20);
            this.txtDailyRent.TabIndex = 35;
            // 
            // txtWeeklyRent
            // 
            this.txtWeeklyRent.Cursor = System.Windows.Forms.Cursors.No;
            this.txtWeeklyRent.Enabled = false;
            this.txtWeeklyRent.Location = new System.Drawing.Point(381, 382);
            this.txtWeeklyRent.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeeklyRent.Name = "txtWeeklyRent";
            this.txtWeeklyRent.ReadOnly = true;
            this.txtWeeklyRent.Size = new System.Drawing.Size(81, 20);
            this.txtWeeklyRent.TabIndex = 34;
            // 
            // txtMonthlyRent
            // 
            this.txtMonthlyRent.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMonthlyRent.Enabled = false;
            this.txtMonthlyRent.Location = new System.Drawing.Point(487, 382);
            this.txtMonthlyRent.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonthlyRent.Name = "txtMonthlyRent";
            this.txtMonthlyRent.ReadOnly = true;
            this.txtMonthlyRent.Size = new System.Drawing.Size(75, 20);
            this.txtMonthlyRent.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbWithoutDriver);
            this.groupBox1.Controls.Add(this.rdbWithDriver);
            this.groupBox1.Location = new System.Drawing.Point(301, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 73);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // rdbWithoutDriver
            // 
            this.rdbWithoutDriver.AutoSize = true;
            this.rdbWithoutDriver.BackColor = System.Drawing.Color.Transparent;
            this.rdbWithoutDriver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbWithoutDriver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWithoutDriver.ForeColor = System.Drawing.Color.White;
            this.rdbWithoutDriver.Location = new System.Drawing.Point(139, 28);
            this.rdbWithoutDriver.Margin = new System.Windows.Forms.Padding(2);
            this.rdbWithoutDriver.Name = "rdbWithoutDriver";
            this.rdbWithoutDriver.Size = new System.Drawing.Size(116, 23);
            this.rdbWithoutDriver.TabIndex = 8;
            this.rdbWithoutDriver.TabStop = true;
            this.rdbWithoutDriver.Text = "Without Driver";
            this.rdbWithoutDriver.UseVisualStyleBackColor = false;
            // 
            // rdbWithDriver
            // 
            this.rdbWithDriver.AutoSize = true;
            this.rdbWithDriver.BackColor = System.Drawing.Color.Transparent;
            this.rdbWithDriver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbWithDriver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWithDriver.ForeColor = System.Drawing.Color.White;
            this.rdbWithDriver.Location = new System.Drawing.Point(7, 28);
            this.rdbWithDriver.Margin = new System.Windows.Forms.Padding(2);
            this.rdbWithDriver.Name = "rdbWithDriver";
            this.rdbWithDriver.Size = new System.Drawing.Size(97, 23);
            this.rdbWithDriver.TabIndex = 7;
            this.rdbWithDriver.TabStop = true;
            this.rdbWithDriver.Text = "With Driver";
            this.rdbWithDriver.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(301, 430);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(152, 22);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // cmbVehicleNo
            // 
            this.cmbVehicleNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbVehicleNo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbVehicleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVehicleNo.FormattingEnabled = true;
            this.cmbVehicleNo.Location = new System.Drawing.Point(301, 124);
            this.cmbVehicleNo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVehicleNo.Name = "cmbVehicleNo";
            this.cmbVehicleNo.Size = new System.Drawing.Size(260, 24);
            this.cmbVehicleNo.TabIndex = 4;
            // 
            // txtTotalRent
            // 
            this.txtTotalRent.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTotalRent.Enabled = false;
            this.txtTotalRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRent.Location = new System.Drawing.Point(301, 313);
            this.txtTotalRent.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalRent.Name = "txtTotalRent";
            this.txtTotalRent.Size = new System.Drawing.Size(260, 22);
            this.txtTotalRent.TabIndex = 17;
            // 
            // txtRentID
            // 
            this.txtRentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentID.Location = new System.Drawing.Point(301, 21);
            this.txtRentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.Size = new System.Drawing.Size(260, 22);
            this.txtRentID.TabIndex = 1;
            // 
            // txtClient
            // 
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClient.Location = new System.Drawing.Point(301, 60);
            this.txtClient.Margin = new System.Windows.Forms.Padding(2);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(260, 22);
            this.txtClient.TabIndex = 2;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(301, 90);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(260, 22);
            this.txtContactNo.TabIndex = 3;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnDate.Location = new System.Drawing.Point(301, 189);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(260, 22);
            this.dtpReturnDate.TabIndex = 6;
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpRentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRentDate.Location = new System.Drawing.Point(301, 159);
            this.dtpRentDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(260, 22);
            this.dtpRentDate.TabIndex = 5;
            // 
            // lblRentID
            // 
            this.lblRentID.AutoSize = true;
            this.lblRentID.BackColor = System.Drawing.Color.Transparent;
            this.lblRentID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentID.ForeColor = System.Drawing.Color.White;
            this.lblRentID.Location = new System.Drawing.Point(141, 26);
            this.lblRentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRentID.Name = "lblRentID";
            this.lblRentID.Size = new System.Drawing.Size(60, 21);
            this.lblRentID.TabIndex = 14;
            this.lblRentID.Text = "Rent ID";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.BackColor = System.Drawing.Color.Transparent;
            this.lblClient.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(141, 60);
            this.lblClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(53, 21);
            this.lblClient.TabIndex = 15;
            this.lblClient.Text = "Client ";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.ForeColor = System.Drawing.Color.White;
            this.lblContactNo.Location = new System.Drawing.Point(141, 95);
            this.lblContactNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(84, 21);
            this.lblContactNo.TabIndex = 16;
            this.lblContactNo.Text = "Contact No";
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleNo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleNo.ForeColor = System.Drawing.Color.White;
            this.lblVehicleNo.Location = new System.Drawing.Point(141, 128);
            this.lblVehicleNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(81, 21);
            this.lblVehicleNo.TabIndex = 17;
            this.lblVehicleNo.Text = "Vehicle No";
            // 
            // lblRentDate
            // 
            this.lblRentDate.AutoSize = true;
            this.lblRentDate.BackColor = System.Drawing.Color.Transparent;
            this.lblRentDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentDate.ForeColor = System.Drawing.Color.White;
            this.lblRentDate.Location = new System.Drawing.Point(141, 164);
            this.lblRentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRentDate.Name = "lblRentDate";
            this.lblRentDate.Size = new System.Drawing.Size(95, 21);
            this.lblRentDate.TabIndex = 18;
            this.lblRentDate.Text = "Rented Date";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.Color.White;
            this.lblReturnDate.Location = new System.Drawing.Point(141, 199);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(92, 21);
            this.lblReturnDate.TabIndex = 19;
            this.lblReturnDate.Text = "Return Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(488, 401);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Monthly Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(380, 401);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Weekly Rent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(272, 401);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Daily Rent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(172, 401);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Driver charge";
            // 
            // lblTotalRent
            // 
            this.lblTotalRent.AutoSize = true;
            this.lblTotalRent.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRent.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRent.ForeColor = System.Drawing.Color.White;
            this.lblTotalRent.Location = new System.Drawing.Point(142, 311);
            this.lblTotalRent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRent.Name = "lblTotalRent";
            this.lblTotalRent.Size = new System.Drawing.Size(80, 21);
            this.lblTotalRent.TabIndex = 21;
            this.lblTotalRent.Text = "Total Rent";
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.BackColor = System.Drawing.Color.Transparent;
            this.lblDriver.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriver.ForeColor = System.Drawing.Color.White;
            this.lblDriver.Location = new System.Drawing.Point(142, 245);
            this.lblDriver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(49, 21);
            this.lblDriver.TabIndex = 20;
            this.lblDriver.Text = "Driver";
            // 
            // btnView
            // 
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(486, 430);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 22);
            this.btnView.TabIndex = 15;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dgvRent
            // 
            this.dgvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRent.Location = new System.Drawing.Point(5, 467);
            this.dgvRent.Name = "dgvRent";
            this.dgvRent.RowHeadersWidth = 51;
            this.dgvRent.Size = new System.Drawing.Size(698, 181);
            this.dgvRent.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnRClear);
            this.panel3.Controls.Add(this.btnRDelete);
            this.panel3.Controls.Add(this.btnRUpdate);
            this.panel3.Controls.Add(this.btnRInsert);
            this.panel3.Location = new System.Drawing.Point(593, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 403);
            this.panel3.TabIndex = 10;
            // 
            // btnRClear
            // 
            this.btnRClear.BackColor = System.Drawing.Color.DimGray;
            this.btnRClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRClear.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRClear.ForeColor = System.Drawing.Color.White;
            this.btnRClear.Location = new System.Drawing.Point(0, 228);
            this.btnRClear.Name = "btnRClear";
            this.btnRClear.Size = new System.Drawing.Size(103, 32);
            this.btnRClear.TabIndex = 13;
            this.btnRClear.Text = "Clear";
            this.btnRClear.UseVisualStyleBackColor = false;
            this.btnRClear.Click += new System.EventHandler(this.btnRClear_Click);
            // 
            // btnRDelete
            // 
            this.btnRDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnRDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRDelete.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRDelete.ForeColor = System.Drawing.Color.White;
            this.btnRDelete.Location = new System.Drawing.Point(1, 190);
            this.btnRDelete.Name = "btnRDelete";
            this.btnRDelete.Size = new System.Drawing.Size(103, 32);
            this.btnRDelete.TabIndex = 12;
            this.btnRDelete.Text = "Delete";
            this.btnRDelete.UseVisualStyleBackColor = false;
            this.btnRDelete.Click += new System.EventHandler(this.btnRDelete_Click);
            // 
            // btnRUpdate
            // 
            this.btnRUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnRUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRUpdate.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRUpdate.ForeColor = System.Drawing.Color.White;
            this.btnRUpdate.Location = new System.Drawing.Point(1, 152);
            this.btnRUpdate.Name = "btnRUpdate";
            this.btnRUpdate.Size = new System.Drawing.Size(103, 32);
            this.btnRUpdate.TabIndex = 11;
            this.btnRUpdate.Text = "Update";
            this.btnRUpdate.UseVisualStyleBackColor = false;
            this.btnRUpdate.Click += new System.EventHandler(this.btnRUpdate_Click);
            // 
            // btnRInsert
            // 
            this.btnRInsert.BackColor = System.Drawing.Color.DimGray;
            this.btnRInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRInsert.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRInsert.ForeColor = System.Drawing.Color.White;
            this.btnRInsert.Location = new System.Drawing.Point(1, 114);
            this.btnRInsert.Name = "btnRInsert";
            this.btnRInsert.Size = new System.Drawing.Size(103, 32);
            this.btnRInsert.TabIndex = 10;
            this.btnRInsert.Text = "Insert";
            this.btnRInsert.UseVisualStyleBackColor = false;
            this.btnRInsert.Click += new System.EventHandler(this.btnRInsert_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 437);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 348);
            this.label1.TabIndex = 0;
            this.label1.Text = "R\r\ne\r\nn\r\nt\r\n\r\nV\r\ne\r\nh\r\ni\r\nc\r\na\r\nl";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AyuboNew.Properties.Resources.SGN_09_21_2022_1663705436108;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 82);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(718, 666);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Rent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnRClear;
        private System.Windows.Forms.Button btnRDelete;
        private System.Windows.Forms.Button btnRUpdate;
        private System.Windows.Forms.Button btnRInsert;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblRentID;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.Label lblRentDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblTotalRent;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.ComboBox cmbVehicleNo;
        private System.Windows.Forms.TextBox txtTotalRent;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.RadioButton rdbWithoutDriver;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.RadioButton rdbWithDriver;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtDriverCharge;
        private System.Windows.Forms.TextBox txtDailyRent;
        private System.Windows.Forms.TextBox txtWeeklyRent;
        private System.Windows.Forms.TextBox txtMonthlyRent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}