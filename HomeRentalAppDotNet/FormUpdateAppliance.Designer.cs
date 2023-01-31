namespace HomeRentalAppDotNet
{
    partial class FormUpdateAppliance
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numFees = new System.Windows.Forms.NumericUpDown();
            this.numEnergyConsum = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxApplianceTypes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdateAppliance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnergyConsum)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Wh";
            // 
            // numFees
            // 
            this.numFees.Location = new System.Drawing.Point(209, 379);
            this.numFees.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numFees.Name = "numFees";
            this.numFees.Size = new System.Drawing.Size(196, 22);
            this.numFees.TabIndex = 24;
            // 
            // numEnergyConsum
            // 
            this.numEnergyConsum.Location = new System.Drawing.Point(209, 339);
            this.numEnergyConsum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numEnergyConsum.Name = "numEnergyConsum";
            this.numEnergyConsum.Size = new System.Drawing.Size(196, 22);
            this.numEnergyConsum.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Type";
            // 
            // comboBoxApplianceTypes
            // 
            this.comboBoxApplianceTypes.FormattingEnabled = true;
            this.comboBoxApplianceTypes.Location = new System.Drawing.Point(209, 68);
            this.comboBoxApplianceTypes.Name = "comboBoxApplianceTypes";
            this.comboBoxApplianceTypes.Size = new System.Drawing.Size(233, 24);
            this.comboBoxApplianceTypes.TabIndex = 15;
            this.comboBoxApplianceTypes.Text = "Please Select Appliance Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Monthly Fees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Energy Consumption";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Dimension";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(209, 247);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(233, 73);
            this.txtDescription.TabIndex = 20;
            // 
            // txtDimension
            // 
            this.txtDimension.Location = new System.Drawing.Point(209, 205);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(233, 22);
            this.txtDimension.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(209, 159);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(233, 22);
            this.txtModel.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Brand";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(209, 110);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(233, 22);
            this.txtBrand.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(209, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 22);
            this.txtName.TabIndex = 13;
            // 
            // btnUpdateAppliance
            // 
            this.btnUpdateAppliance.Location = new System.Drawing.Point(209, 444);
            this.btnUpdateAppliance.Name = "btnUpdateAppliance";
            this.btnUpdateAppliance.Size = new System.Drawing.Size(233, 45);
            this.btnUpdateAppliance.TabIndex = 28;
            this.btnUpdateAppliance.Text = "Update Appliance";
            this.btnUpdateAppliance.UseVisualStyleBackColor = true;
            this.btnUpdateAppliance.Click += new System.EventHandler(this.btnUpdateAppliance_Click);
            // 
            // FormUpdateAppliance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 526);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numFees);
            this.Controls.Add(this.numEnergyConsum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxApplianceTypes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDimension);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnUpdateAppliance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormUpdateAppliance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Rental App | Update";
            this.Load += new System.EventHandler(this.FormUpdateAppliance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnergyConsum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numFees;
        private System.Windows.Forms.NumericUpDown numEnergyConsum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxApplianceTypes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDimension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdateAppliance;
    }
}