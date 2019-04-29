namespace WindowsFormsApp1
{
    partial class frmCityPowerCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCityPowerCompany));
            this.pnlIndustrial = new System.Windows.Forms.Panel();
            this.lblOffPeak = new System.Windows.Forms.Label();
            this.lblOnPeak = new System.Windows.Forms.Label();
            this.txtOnPeak = new System.Windows.Forms.TextBox();
            this.txtOffPeak = new System.Windows.Forms.TextBox();
            this.grpCstType = new System.Windows.Forms.GroupBox();
            this.rdIndustrial = new System.Windows.Forms.RadioButton();
            this.rdCommercial = new System.Windows.Forms.RadioButton();
            this.rdResidential = new System.Windows.Forms.RadioButton();
            this.txtChargeAmt = new System.Windows.Forms.TextBox();
            this.txtKwh = new System.Windows.Forms.TextBox();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblkwh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListView();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtTotalCustomers = new System.Windows.Forms.TextBox();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.lblTotalCharge = new System.Windows.Forms.Label();
            this.txtTotalCharge = new System.Windows.Forms.TextBox();
            this.lblChargeAmtCustomer = new System.Windows.Forms.Label();
            this.txtResidentialType = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtCommercialType = new System.Windows.Forms.TextBox();
            this.txtIndutrialType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlIndustrial.SuspendLayout();
            this.grpCstType.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIndustrial
            // 
            this.pnlIndustrial.BackColor = System.Drawing.Color.Khaki;
            this.pnlIndustrial.Controls.Add(this.lblOffPeak);
            this.pnlIndustrial.Controls.Add(this.lblOnPeak);
            this.pnlIndustrial.Controls.Add(this.txtOnPeak);
            this.pnlIndustrial.Controls.Add(this.txtOffPeak);
            this.pnlIndustrial.Location = new System.Drawing.Point(362, 153);
            this.pnlIndustrial.Name = "pnlIndustrial";
            this.pnlIndustrial.Size = new System.Drawing.Size(433, 129);
            this.pnlIndustrial.TabIndex = 7;
            // 
            // lblOffPeak
            // 
            this.lblOffPeak.AutoSize = true;
            this.lblOffPeak.BackColor = System.Drawing.Color.BurlyWood;
            this.lblOffPeak.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffPeak.Location = new System.Drawing.Point(6, 84);
            this.lblOffPeak.Name = "lblOffPeak";
            this.lblOffPeak.Size = new System.Drawing.Size(256, 22);
            this.lblOffPeak.TabIndex = 2;
            this.lblOffPeak.Text = "Enter Off-Peak KWh Used:";
            // 
            // lblOnPeak
            // 
            this.lblOnPeak.AutoSize = true;
            this.lblOnPeak.BackColor = System.Drawing.Color.BurlyWood;
            this.lblOnPeak.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnPeak.Location = new System.Drawing.Point(9, 29);
            this.lblOnPeak.Name = "lblOnPeak";
            this.lblOnPeak.Size = new System.Drawing.Size(252, 22);
            this.lblOnPeak.TabIndex = 0;
            this.lblOnPeak.Text = "Enter On-Peak KWh Used:";
            // 
            // txtOnPeak
            // 
            this.txtOnPeak.Location = new System.Drawing.Point(277, 30);
            this.txtOnPeak.Name = "txtOnPeak";
            this.txtOnPeak.Size = new System.Drawing.Size(119, 22);
            this.txtOnPeak.TabIndex = 1;
            // 
            // txtOffPeak
            // 
            this.txtOffPeak.Location = new System.Drawing.Point(277, 78);
            this.txtOffPeak.Name = "txtOffPeak";
            this.txtOffPeak.Size = new System.Drawing.Size(119, 22);
            this.txtOffPeak.TabIndex = 3;
            // 
            // grpCstType
            // 
            this.grpCstType.BackColor = System.Drawing.Color.Khaki;
            this.grpCstType.Controls.Add(this.rdIndustrial);
            this.grpCstType.Controls.Add(this.rdCommercial);
            this.grpCstType.Controls.Add(this.rdResidential);
            this.grpCstType.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCstType.Location = new System.Drawing.Point(40, 205);
            this.grpCstType.Name = "grpCstType";
            this.grpCstType.Size = new System.Drawing.Size(216, 184);
            this.grpCstType.TabIndex = 1;
            this.grpCstType.TabStop = false;
            this.grpCstType.Text = "Select Customer Type";
            // 
            // rdIndustrial
            // 
            this.rdIndustrial.AutoSize = true;
            this.rdIndustrial.BackColor = System.Drawing.Color.NavajoWhite;
            this.rdIndustrial.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIndustrial.Location = new System.Drawing.Point(26, 135);
            this.rdIndustrial.Name = "rdIndustrial";
            this.rdIndustrial.Size = new System.Drawing.Size(122, 26);
            this.rdIndustrial.TabIndex = 2;
            this.rdIndustrial.TabStop = true;
            this.rdIndustrial.Text = "&Industrial";
            this.rdIndustrial.UseVisualStyleBackColor = false;
            this.rdIndustrial.CheckedChanged += new System.EventHandler(this.rdIndustrial_CheckedChanged);
            // 
            // rdCommercial
            // 
            this.rdCommercial.AutoSize = true;
            this.rdCommercial.BackColor = System.Drawing.Color.Wheat;
            this.rdCommercial.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCommercial.Location = new System.Drawing.Point(26, 93);
            this.rdCommercial.Name = "rdCommercial";
            this.rdCommercial.Size = new System.Drawing.Size(136, 26);
            this.rdCommercial.TabIndex = 1;
            this.rdCommercial.TabStop = true;
            this.rdCommercial.Text = "Commercial";
            this.rdCommercial.UseVisualStyleBackColor = false;
            this.rdCommercial.CheckedChanged += new System.EventHandler(this.rdCommercial_CheckedChanged);
            // 
            // rdResidential
            // 
            this.rdResidential.AutoSize = true;
            this.rdResidential.BackColor = System.Drawing.Color.FloralWhite;
            this.rdResidential.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdResidential.Location = new System.Drawing.Point(26, 50);
            this.rdResidential.Name = "rdResidential";
            this.rdResidential.Size = new System.Drawing.Size(133, 26);
            this.rdResidential.TabIndex = 0;
            this.rdResidential.TabStop = true;
            this.rdResidential.Text = "&Residential";
            this.rdResidential.UseVisualStyleBackColor = false;
            this.rdResidential.CheckedChanged += new System.EventHandler(this.rdResidential_CheckedChanged);
            // 
            // txtChargeAmt
            // 
            this.txtChargeAmt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtChargeAmt.Location = new System.Drawing.Point(629, 388);
            this.txtChargeAmt.Name = "txtChargeAmt";
            this.txtChargeAmt.Size = new System.Drawing.Size(119, 22);
            this.txtChargeAmt.TabIndex = 22;
            // 
            // txtKwh
            // 
            this.txtKwh.Location = new System.Drawing.Point(639, 113);
            this.txtKwh.Name = "txtKwh";
            this.txtKwh.Size = new System.Drawing.Size(119, 22);
            this.txtKwh.TabIndex = 6;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.BackColor = System.Drawing.Color.Khaki;
            this.lblBill.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBill.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBill.Location = new System.Drawing.Point(405, 385);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(176, 23);
            this.lblBill.TabIndex = 21;
            this.lblBill.Text = "Your Bill Amount:";
            // 
            // lblkwh
            // 
            this.lblkwh.AutoSize = true;
            this.lblkwh.BackColor = System.Drawing.Color.Khaki;
            this.lblkwh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkwh.Location = new System.Drawing.Point(415, 113);
            this.lblkwh.Name = "lblkwh";
            this.lblkwh.Size = new System.Drawing.Size(166, 22);
            this.lblkwh.TabIndex = 17;
            this.lblkwh.Text = "Enter KWh Used:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "Energy Bill Calculation";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(419, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 49);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "C&lear Input";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Khaki;
            this.lblCustomer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(876, 76);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(147, 22);
            this.lblCustomer.TabIndex = 14;
            this.lblCustomer.Text = "Customer Lists";
            // 
            // lstCustomers
            // 
            this.lstCustomers.Enabled = false;
            this.lstCustomers.Location = new System.Drawing.Point(827, 108);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(255, 241);
            this.lstCustomers.TabIndex = 13;
            this.lstCustomers.UseCompatibleStateImageBehavior = false;
            this.lstCustomers.View = System.Windows.Forms.View.List;
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.BackColor = System.Drawing.Color.Khaki;
            this.lblAccountNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNo.Location = new System.Drawing.Point(39, 107);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(122, 22);
            this.lblAccountNo.TabIndex = 4;
            this.lblAccountNo.Text = "Account No:";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(211, 108);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(100, 22);
            this.txtAccountNo.TabIndex = 2;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(211, 155);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(100, 22);
            this.txtCustName.TabIndex = 4;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Khaki;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(39, 155);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(163, 22);
            this.lblCustomerName.TabIndex = 12;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(530, 469);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 50);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "&Exit Application";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddCustomer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(892, 374);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(140, 49);
            this.btnAddCustomer.TabIndex = 9;
            this.btnAddCustomer.Text = "&ADD CUSTOMER";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtTotalCustomers
            // 
            this.txtTotalCustomers.Enabled = false;
            this.txtTotalCustomers.Location = new System.Drawing.Point(1332, 108);
            this.txtTotalCustomers.Name = "txtTotalCustomers";
            this.txtTotalCustomers.Size = new System.Drawing.Size(119, 22);
            this.txtTotalCustomers.TabIndex = 26;
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.BackColor = System.Drawing.Color.Khaki;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomers.Location = new System.Drawing.Point(1135, 107);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(166, 22);
            this.lblTotalCustomers.TabIndex = 27;
            this.lblTotalCustomers.Text = "Total Customers:";
            // 
            // lblTotalCharge
            // 
            this.lblTotalCharge.AutoSize = true;
            this.lblTotalCharge.BackColor = System.Drawing.Color.Khaki;
            this.lblTotalCharge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCharge.Location = new System.Drawing.Point(1096, 152);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Size = new System.Drawing.Size(205, 22);
            this.lblTotalCharge.TabIndex = 28;
            this.lblTotalCharge.Text = "Total Billing  Amount:";
            // 
            // txtTotalCharge
            // 
            this.txtTotalCharge.Enabled = false;
            this.txtTotalCharge.Location = new System.Drawing.Point(1332, 153);
            this.txtTotalCharge.Name = "txtTotalCharge";
            this.txtTotalCharge.Size = new System.Drawing.Size(119, 22);
            this.txtTotalCharge.TabIndex = 29;
            // 
            // lblChargeAmtCustomer
            // 
            this.lblChargeAmtCustomer.AutoSize = true;
            this.lblChargeAmtCustomer.BackColor = System.Drawing.Color.Khaki;
            this.lblChargeAmtCustomer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChargeAmtCustomer.Location = new System.Drawing.Point(1096, 205);
            this.lblChargeAmtCustomer.Name = "lblChargeAmtCustomer";
            this.lblChargeAmtCustomer.Size = new System.Drawing.Size(290, 22);
            this.lblChargeAmtCustomer.TabIndex = 30;
            this.lblChargeAmtCustomer.Text = "Total Billing Amt By Customer:";
            // 
            // txtResidentialType
            // 
            this.txtResidentialType.Enabled = false;
            this.txtResidentialType.Location = new System.Drawing.Point(1332, 263);
            this.txtResidentialType.Name = "txtResidentialType";
            this.txtResidentialType.Size = new System.Drawing.Size(119, 22);
            this.txtResidentialType.TabIndex = 31;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCalculate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(625, 300);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(109, 49);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtCommercialType
            // 
            this.txtCommercialType.Enabled = false;
            this.txtCommercialType.Location = new System.Drawing.Point(1332, 306);
            this.txtCommercialType.Name = "txtCommercialType";
            this.txtCommercialType.Size = new System.Drawing.Size(119, 22);
            this.txtCommercialType.TabIndex = 32;
            // 
            // txtIndutrialType
            // 
            this.txtIndutrialType.Enabled = false;
            this.txtIndutrialType.Location = new System.Drawing.Point(1332, 344);
            this.txtIndutrialType.Name = "txtIndutrialType";
            this.txtIndutrialType.Size = new System.Drawing.Size(119, 22);
            this.txtIndutrialType.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1135, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Residential";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1135, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Commercial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FloralWhite;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1135, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Industrial";
            // 
            // frmCityPowerCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1477, 531);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIndutrialType);
            this.Controls.Add(this.txtCommercialType);
            this.Controls.Add(this.txtResidentialType);
            this.Controls.Add(this.lblChargeAmtCustomer);
            this.Controls.Add(this.txtTotalCharge);
            this.Controls.Add(this.lblTotalCharge);
            this.Controls.Add(this.lblTotalCustomers);
            this.Controls.Add(this.txtTotalCustomers);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.pnlIndustrial);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.grpCstType);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.txtChargeAmt);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtKwh);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.lblkwh);
            this.DoubleBuffered = true;
            this.Name = "frmCityPowerCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Energy Bill Calc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCityPowerCompany_FormClosing);
            this.Load += new System.EventHandler(this.frmCityPowerCompany_Load);
            this.pnlIndustrial.ResumeLayout(false);
            this.pnlIndustrial.PerformLayout();
            this.grpCstType.ResumeLayout(false);
            this.grpCstType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlIndustrial;
        private System.Windows.Forms.Label lblOffPeak;
        private System.Windows.Forms.Label lblOnPeak;
        private System.Windows.Forms.TextBox txtOnPeak;
        private System.Windows.Forms.TextBox txtOffPeak;
        private System.Windows.Forms.GroupBox grpCstType;
        private System.Windows.Forms.RadioButton rdIndustrial;
        private System.Windows.Forms.RadioButton rdCommercial;
        private System.Windows.Forms.RadioButton rdResidential;
        private System.Windows.Forms.TextBox txtChargeAmt;
        private System.Windows.Forms.TextBox txtKwh;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblkwh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView lstCustomers;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtTotalCustomers;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label lblTotalCharge;
        private System.Windows.Forms.TextBox txtTotalCharge;
        private System.Windows.Forms.Label lblChargeAmtCustomer;
        private System.Windows.Forms.TextBox txtResidentialType;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtCommercialType;
        private System.Windows.Forms.TextBox txtIndutrialType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

