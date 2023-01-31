namespace HomeRentalAppDotNet
{
    partial class FormAddToCart
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEnergyConsum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRentalPeriod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRentalPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(173, 21);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(209, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(173, 59);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.ReadOnly = true;
            this.txtBrand.Size = new System.Drawing.Size(209, 22);
            this.txtBrand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(173, 99);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(209, 22);
            this.txtModel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dimension";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDimension
            // 
            this.txtDimension.Location = new System.Drawing.Point(173, 136);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.ReadOnly = true;
            this.txtDimension.Size = new System.Drawing.Size(209, 22);
            this.txtDimension.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(173, 173);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(209, 97);
            this.txtDescription.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Energy Consumption";
            // 
            // txtEnergyConsum
            // 
            this.txtEnergyConsum.Location = new System.Drawing.Point(200, 296);
            this.txtEnergyConsum.Name = "txtEnergyConsum";
            this.txtEnergyConsum.ReadOnly = true;
            this.txtEnergyConsum.Size = new System.Drawing.Size(182, 22);
            this.txtEnergyConsum.TabIndex = 3;
            this.txtEnergyConsum.TextChanged += new System.EventHandler(this.txtEnergyConsum_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Monthly Fees";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(200, 335);
            this.txtFees.Name = "txtFees";
            this.txtFees.ReadOnly = true;
            this.txtFees.Size = new System.Drawing.Size(182, 22);
            this.txtFees.TabIndex = 3;
            this.txtFees.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Rental Period (Month)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtRentalPeriod
            // 
            this.txtRentalPeriod.Location = new System.Drawing.Point(200, 372);
            this.txtRentalPeriod.Name = "txtRentalPeriod";
            this.txtRentalPeriod.Size = new System.Drawing.Size(182, 22);
            this.txtRentalPeriod.TabIndex = 3;
            this.txtRentalPeriod.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Rental Price";
            this.label9.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtRentalPrice
            // 
            this.txtRentalPrice.Location = new System.Drawing.Point(200, 410);
            this.txtRentalPrice.Name = "txtRentalPrice";
            this.txtRentalPrice.ReadOnly = true;
            this.txtRentalPrice.Size = new System.Drawing.Size(182, 22);
            this.txtRentalPrice.TabIndex = 3;
            this.txtRentalPrice.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRentalPeriod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRentalPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEnergyConsum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDimension);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddToCart";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add to Cart";
            this.Load += new System.EventHandler(this.FormAddToCart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDimension;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEnergyConsum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRentalPeriod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRentalPrice;
        private System.Windows.Forms.Button button1;
    }
}