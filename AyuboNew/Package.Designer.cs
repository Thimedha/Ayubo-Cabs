namespace AyuboNew
{
    partial class Package
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPView = new System.Windows.Forms.Button();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.txtDriverOvernightRate = new System.Windows.Forms.TextBox();
            this.txtWaitOvernightRate = new System.Windows.Forms.TextBox();
            this.txtDriverCharge = new System.Windows.Forms.TextBox();
            this.txtMaxHours = new System.Windows.Forms.TextBox();
            this.txtWaitingCharge = new System.Windows.Forms.TextBox();
            this.txtExtraKmCharge = new System.Windows.Forms.TextBox();
            this.txtPackageID = new System.Windows.Forms.TextBox();
            this.txtBasicKmCharge = new System.Windows.Forms.TextBox();
            this.txtMaxKmLimit = new System.Windows.Forms.TextBox();
            this.lblPackageID = new System.Windows.Forms.Label();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lblWaitOvernightRate = new System.Windows.Forms.Label();
            this.lblMaxKmLimit = new System.Windows.Forms.Label();
            this.lblMaximumHours = new System.Windows.Forms.Label();
            this.lblDriverOvernightRate = new System.Windows.Forms.Label();
            this.lblExtraKmCharge = new System.Windows.Forms.Label();
            this.lblBasicKmCharge = new System.Windows.Forms.Label();
            this.lblWaitingCharge = new System.Windows.Forms.Label();
            this.lblDriverCharge = new System.Windows.Forms.Label();
            this.dgvPackage = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPMainMenu = new System.Windows.Forms.Button();
            this.btnPClear = new System.Windows.Forms.Button();
            this.btnPDelete = new System.Windows.Forms.Button();
            this.btnPUpdate = new System.Windows.Forms.Button();
            this.btnPInsert = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackage)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnPView);
            this.panel1.Controls.Add(this.txtPackage);
            this.panel1.Controls.Add(this.txtDriverOvernightRate);
            this.panel1.Controls.Add(this.txtWaitOvernightRate);
            this.panel1.Controls.Add(this.txtDriverCharge);
            this.panel1.Controls.Add(this.txtMaxHours);
            this.panel1.Controls.Add(this.txtWaitingCharge);
            this.panel1.Controls.Add(this.txtExtraKmCharge);
            this.panel1.Controls.Add(this.txtPackageID);
            this.panel1.Controls.Add(this.txtBasicKmCharge);
            this.panel1.Controls.Add(this.txtMaxKmLimit);
            this.panel1.Controls.Add(this.lblPackageID);
            this.panel1.Controls.Add(this.lblPackage);
            this.panel1.Controls.Add(this.lblWaitOvernightRate);
            this.panel1.Controls.Add(this.lblMaxKmLimit);
            this.panel1.Controls.Add(this.lblMaximumHours);
            this.panel1.Controls.Add(this.lblDriverOvernightRate);
            this.panel1.Controls.Add(this.lblExtraKmCharge);
            this.panel1.Controls.Add(this.lblBasicKmCharge);
            this.panel1.Controls.Add(this.lblWaitingCharge);
            this.panel1.Controls.Add(this.lblDriverCharge);
            this.panel1.Controls.Add(this.dgvPackage);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 729);
            this.panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(243, 457);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 22);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnPView
            // 
            this.btnPView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPView.Location = new System.Drawing.Point(511, 457);
            this.btnPView.Name = "btnPView";
            this.btnPView.Size = new System.Drawing.Size(107, 23);
            this.btnPView.TabIndex = 16;
            this.btnPView.Text = "View";
            this.btnPView.UseVisualStyleBackColor = true;
            this.btnPView.Click += new System.EventHandler(this.btnPView_Click);
            // 
            // txtPackage
            // 
            this.txtPackage.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackage.Location = new System.Drawing.Point(366, 62);
            this.txtPackage.Margin = new System.Windows.Forms.Padding(2);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.Size = new System.Drawing.Size(252, 23);
            this.txtPackage.TabIndex = 2;
            // 
            // txtDriverOvernightRate
            // 
            this.txtDriverOvernightRate.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverOvernightRate.Location = new System.Drawing.Point(366, 301);
            this.txtDriverOvernightRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDriverOvernightRate.Name = "txtDriverOvernightRate";
            this.txtDriverOvernightRate.Size = new System.Drawing.Size(252, 23);
            this.txtDriverOvernightRate.TabIndex = 9;
            // 
            // txtWaitOvernightRate
            // 
            this.txtWaitOvernightRate.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaitOvernightRate.Location = new System.Drawing.Point(366, 338);
            this.txtWaitOvernightRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtWaitOvernightRate.Name = "txtWaitOvernightRate";
            this.txtWaitOvernightRate.Size = new System.Drawing.Size(252, 23);
            this.txtWaitOvernightRate.TabIndex = 10;
            // 
            // txtDriverCharge
            // 
            this.txtDriverCharge.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverCharge.Location = new System.Drawing.Point(366, 265);
            this.txtDriverCharge.Margin = new System.Windows.Forms.Padding(2);
            this.txtDriverCharge.Name = "txtDriverCharge";
            this.txtDriverCharge.Size = new System.Drawing.Size(252, 23);
            this.txtDriverCharge.TabIndex = 8;
            // 
            // txtMaxHours
            // 
            this.txtMaxHours.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxHours.Location = new System.Drawing.Point(366, 125);
            this.txtMaxHours.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxHours.Name = "txtMaxHours";
            this.txtMaxHours.Size = new System.Drawing.Size(252, 23);
            this.txtMaxHours.TabIndex = 4;
            // 
            // txtWaitingCharge
            // 
            this.txtWaitingCharge.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaitingCharge.Location = new System.Drawing.Point(366, 232);
            this.txtWaitingCharge.Margin = new System.Windows.Forms.Padding(2);
            this.txtWaitingCharge.Name = "txtWaitingCharge";
            this.txtWaitingCharge.Size = new System.Drawing.Size(252, 23);
            this.txtWaitingCharge.TabIndex = 7;
            // 
            // txtExtraKmCharge
            // 
            this.txtExtraKmCharge.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraKmCharge.Location = new System.Drawing.Point(366, 158);
            this.txtExtraKmCharge.Margin = new System.Windows.Forms.Padding(2);
            this.txtExtraKmCharge.Name = "txtExtraKmCharge";
            this.txtExtraKmCharge.Size = new System.Drawing.Size(252, 23);
            this.txtExtraKmCharge.TabIndex = 5;
            // 
            // txtPackageID
            // 
            this.txtPackageID.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageID.Location = new System.Drawing.Point(366, 29);
            this.txtPackageID.Margin = new System.Windows.Forms.Padding(2);
            this.txtPackageID.Name = "txtPackageID";
            this.txtPackageID.Size = new System.Drawing.Size(252, 23);
            this.txtPackageID.TabIndex = 1;
            // 
            // txtBasicKmCharge
            // 
            this.txtBasicKmCharge.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasicKmCharge.Location = new System.Drawing.Point(366, 197);
            this.txtBasicKmCharge.Margin = new System.Windows.Forms.Padding(2);
            this.txtBasicKmCharge.Name = "txtBasicKmCharge";
            this.txtBasicKmCharge.Size = new System.Drawing.Size(252, 23);
            this.txtBasicKmCharge.TabIndex = 6;
            // 
            // txtMaxKmLimit
            // 
            this.txtMaxKmLimit.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxKmLimit.Location = new System.Drawing.Point(366, 92);
            this.txtMaxKmLimit.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxKmLimit.Name = "txtMaxKmLimit";
            this.txtMaxKmLimit.Size = new System.Drawing.Size(252, 23);
            this.txtMaxKmLimit.TabIndex = 3;
            // 
            // lblPackageID
            // 
            this.lblPackageID.AutoSize = true;
            this.lblPackageID.BackColor = System.Drawing.Color.Transparent;
            this.lblPackageID.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageID.ForeColor = System.Drawing.Color.White;
            this.lblPackageID.Location = new System.Drawing.Point(162, 28);
            this.lblPackageID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackageID.Name = "lblPackageID";
            this.lblPackageID.Size = new System.Drawing.Size(96, 19);
            this.lblPackageID.TabIndex = 17;
            this.lblPackageID.Text = "Package ID";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.BackColor = System.Drawing.Color.Transparent;
            this.lblPackage.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage.ForeColor = System.Drawing.Color.White;
            this.lblPackage.Location = new System.Drawing.Point(162, 61);
            this.lblPackage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(80, 19);
            this.lblPackage.TabIndex = 18;
            this.lblPackage.Text = "Packages";
            // 
            // lblWaitOvernightRate
            // 
            this.lblWaitOvernightRate.AutoSize = true;
            this.lblWaitOvernightRate.BackColor = System.Drawing.Color.Transparent;
            this.lblWaitOvernightRate.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitOvernightRate.ForeColor = System.Drawing.Color.White;
            this.lblWaitOvernightRate.Location = new System.Drawing.Point(162, 340);
            this.lblWaitOvernightRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWaitOvernightRate.Name = "lblWaitOvernightRate";
            this.lblWaitOvernightRate.Size = new System.Drawing.Size(164, 19);
            this.lblWaitOvernightRate.TabIndex = 26;
            this.lblWaitOvernightRate.Text = "Wait Overnight Rate";
            // 
            // lblMaxKmLimit
            // 
            this.lblMaxKmLimit.AutoSize = true;
            this.lblMaxKmLimit.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxKmLimit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxKmLimit.ForeColor = System.Drawing.Color.White;
            this.lblMaxKmLimit.Location = new System.Drawing.Point(162, 96);
            this.lblMaxKmLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxKmLimit.Name = "lblMaxKmLimit";
            this.lblMaxKmLimit.Size = new System.Drawing.Size(162, 19);
            this.lblMaxKmLimit.TabIndex = 19;
            this.lblMaxKmLimit.Text = "Maximum Km Limit";
            // 
            // lblMaximumHours
            // 
            this.lblMaximumHours.AutoSize = true;
            this.lblMaximumHours.BackColor = System.Drawing.Color.Transparent;
            this.lblMaximumHours.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximumHours.ForeColor = System.Drawing.Color.White;
            this.lblMaximumHours.Location = new System.Drawing.Point(162, 130);
            this.lblMaximumHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaximumHours.Name = "lblMaximumHours";
            this.lblMaximumHours.Size = new System.Drawing.Size(138, 19);
            this.lblMaximumHours.TabIndex = 20;
            this.lblMaximumHours.Text = "Maximum Hours";
            // 
            // lblDriverOvernightRate
            // 
            this.lblDriverOvernightRate.AutoSize = true;
            this.lblDriverOvernightRate.BackColor = System.Drawing.Color.Transparent;
            this.lblDriverOvernightRate.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverOvernightRate.ForeColor = System.Drawing.Color.White;
            this.lblDriverOvernightRate.Location = new System.Drawing.Point(162, 303);
            this.lblDriverOvernightRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDriverOvernightRate.Name = "lblDriverOvernightRate";
            this.lblDriverOvernightRate.Size = new System.Drawing.Size(177, 19);
            this.lblDriverOvernightRate.TabIndex = 25;
            this.lblDriverOvernightRate.Text = "Driver Overnight Rate";
            // 
            // lblExtraKmCharge
            // 
            this.lblExtraKmCharge.AutoSize = true;
            this.lblExtraKmCharge.BackColor = System.Drawing.Color.Transparent;
            this.lblExtraKmCharge.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraKmCharge.ForeColor = System.Drawing.Color.White;
            this.lblExtraKmCharge.Location = new System.Drawing.Point(162, 165);
            this.lblExtraKmCharge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtraKmCharge.Name = "lblExtraKmCharge";
            this.lblExtraKmCharge.Size = new System.Drawing.Size(140, 19);
            this.lblExtraKmCharge.TabIndex = 21;
            this.lblExtraKmCharge.Text = "Extra Km Charge";
            // 
            // lblBasicKmCharge
            // 
            this.lblBasicKmCharge.AutoSize = true;
            this.lblBasicKmCharge.BackColor = System.Drawing.Color.Transparent;
            this.lblBasicKmCharge.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicKmCharge.ForeColor = System.Drawing.Color.White;
            this.lblBasicKmCharge.Location = new System.Drawing.Point(162, 199);
            this.lblBasicKmCharge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBasicKmCharge.Name = "lblBasicKmCharge";
            this.lblBasicKmCharge.Size = new System.Drawing.Size(139, 19);
            this.lblBasicKmCharge.TabIndex = 22;
            this.lblBasicKmCharge.Text = "Basic Km Charge";
            // 
            // lblWaitingCharge
            // 
            this.lblWaitingCharge.AutoSize = true;
            this.lblWaitingCharge.BackColor = System.Drawing.Color.Transparent;
            this.lblWaitingCharge.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitingCharge.ForeColor = System.Drawing.Color.White;
            this.lblWaitingCharge.Location = new System.Drawing.Point(162, 234);
            this.lblWaitingCharge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWaitingCharge.Name = "lblWaitingCharge";
            this.lblWaitingCharge.Size = new System.Drawing.Size(127, 19);
            this.lblWaitingCharge.TabIndex = 23;
            this.lblWaitingCharge.Text = "Waiting Charge";
            // 
            // lblDriverCharge
            // 
            this.lblDriverCharge.AutoSize = true;
            this.lblDriverCharge.BackColor = System.Drawing.Color.Transparent;
            this.lblDriverCharge.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverCharge.ForeColor = System.Drawing.Color.White;
            this.lblDriverCharge.Location = new System.Drawing.Point(162, 268);
            this.lblDriverCharge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDriverCharge.Name = "lblDriverCharge";
            this.lblDriverCharge.Size = new System.Drawing.Size(116, 19);
            this.lblDriverCharge.TabIndex = 24;
            this.lblDriverCharge.Text = "Driver Charge";
            // 
            // dgvPackage
            // 
            this.dgvPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackage.Location = new System.Drawing.Point(7, 486);
            this.dgvPackage.Name = "dgvPackage";
            this.dgvPackage.Size = new System.Drawing.Size(781, 236);
            this.dgvPackage.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.btnPMainMenu);
            this.panel3.Controls.Add(this.btnPClear);
            this.panel3.Controls.Add(this.btnPDelete);
            this.panel3.Controls.Add(this.btnPUpdate);
            this.panel3.Controls.Add(this.btnPInsert);
            this.panel3.Location = new System.Drawing.Point(659, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 474);
            this.panel3.TabIndex = 11;
            // 
            // btnPMainMenu
            // 
            this.btnPMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPMainMenu.Location = new System.Drawing.Point(3, 431);
            this.btnPMainMenu.Name = "btnPMainMenu";
            this.btnPMainMenu.Size = new System.Drawing.Size(123, 40);
            this.btnPMainMenu.TabIndex = 17;
            this.btnPMainMenu.Text = "Main Menu";
            this.btnPMainMenu.UseVisualStyleBackColor = true;
            this.btnPMainMenu.Click += new System.EventHandler(this.btnPMainMenu_Click);
            // 
            // btnPClear
            // 
            this.btnPClear.BackColor = System.Drawing.Color.DimGray;
            this.btnPClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPClear.ForeColor = System.Drawing.Color.White;
            this.btnPClear.Location = new System.Drawing.Point(3, 239);
            this.btnPClear.Name = "btnPClear";
            this.btnPClear.Size = new System.Drawing.Size(123, 40);
            this.btnPClear.TabIndex = 14;
            this.btnPClear.Text = "Clear";
            this.btnPClear.UseVisualStyleBackColor = false;
            this.btnPClear.Click += new System.EventHandler(this.btnPClear_Click);
            // 
            // btnPDelete
            // 
            this.btnPDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnPDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDelete.ForeColor = System.Drawing.Color.White;
            this.btnPDelete.Location = new System.Drawing.Point(3, 193);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(123, 40);
            this.btnPDelete.TabIndex = 13;
            this.btnPDelete.Text = "Delete";
            this.btnPDelete.UseVisualStyleBackColor = false;
            this.btnPDelete.Click += new System.EventHandler(this.btnPDelete_Click);
            // 
            // btnPUpdate
            // 
            this.btnPUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnPUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPUpdate.ForeColor = System.Drawing.Color.White;
            this.btnPUpdate.Location = new System.Drawing.Point(3, 149);
            this.btnPUpdate.Name = "btnPUpdate";
            this.btnPUpdate.Size = new System.Drawing.Size(123, 40);
            this.btnPUpdate.TabIndex = 12;
            this.btnPUpdate.Text = "Update";
            this.btnPUpdate.UseVisualStyleBackColor = false;
            this.btnPUpdate.Click += new System.EventHandler(this.btnPUpdate_Click);
            // 
            // btnPInsert
            // 
            this.btnPInsert.BackColor = System.Drawing.Color.DimGray;
            this.btnPInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPInsert.ForeColor = System.Drawing.Color.White;
            this.btnPInsert.Location = new System.Drawing.Point(3, 103);
            this.btnPInsert.Name = "btnPInsert";
            this.btnPInsert.Size = new System.Drawing.Size(123, 40);
            this.btnPInsert.TabIndex = 11;
            this.btnPInsert.Text = "Insert";
            this.btnPInsert.UseVisualStyleBackColor = false;
            this.btnPInsert.Click += new System.EventHandler(this.btnPInsert_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 474);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 264);
            this.label1.TabIndex = 0;
            this.label1.Text = "P\r\na\r\nc\r\nk\r\na\r\ng\r\ne\r\ns";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AyuboNew.Properties.Resources.SGN_09_21_2022_1663705436108;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(806, 740);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Package";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPackageID;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblWaitOvernightRate;
        private System.Windows.Forms.Label lblMaxKmLimit;
        private System.Windows.Forms.Label lblMaximumHours;
        private System.Windows.Forms.Label lblDriverOvernightRate;
        private System.Windows.Forms.Label lblExtraKmCharge;
        private System.Windows.Forms.Label lblBasicKmCharge;
        private System.Windows.Forms.Label lblWaitingCharge;
        private System.Windows.Forms.Label lblDriverCharge;
        private System.Windows.Forms.DataGridView dgvPackage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPView;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.TextBox txtDriverOvernightRate;
        private System.Windows.Forms.TextBox txtWaitOvernightRate;
        private System.Windows.Forms.TextBox txtDriverCharge;
        private System.Windows.Forms.TextBox txtMaxHours;
        private System.Windows.Forms.TextBox txtWaitingCharge;
        private System.Windows.Forms.TextBox txtExtraKmCharge;
        private System.Windows.Forms.TextBox txtPackageID;
        private System.Windows.Forms.TextBox txtBasicKmCharge;
        private System.Windows.Forms.TextBox txtMaxKmLimit;
        private System.Windows.Forms.Button btnPMainMenu;
        private System.Windows.Forms.Button btnPClear;
        private System.Windows.Forms.Button btnPDelete;
        private System.Windows.Forms.Button btnPUpdate;
        private System.Windows.Forms.Button btnPInsert;
        private System.Windows.Forms.Label label1;
    }
}