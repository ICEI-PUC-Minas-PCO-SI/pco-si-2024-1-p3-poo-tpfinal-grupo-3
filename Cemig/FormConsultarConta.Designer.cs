﻿namespace Cemig
{
    partial class FormsConsultaConta
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblConsumption;
        private System.Windows.Forms.TextBox txtConsumption;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.TextBox txtTotalValue;
        private System.Windows.Forms.Label lblValueWithoutTaxes;
        private System.Windows.Forms.TextBox txtValueWithoutTaxes;
        private System.Windows.Forms.Button btnConsult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblAccountNumber = new Label();
            txtAccountNumber = new TextBox();
            lblConsumption = new Label();
            txtConsumption = new TextBox();
            lblTotalValue = new Label();
            txtTotalValue = new TextBox();
            lblValueWithoutTaxes = new Label();
            txtValueWithoutTaxes = new TextBox();
            btnConsult = new Button();
            SuspendLayout();
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Location = new Point(12, 15);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(102, 15);
            lblAccountNumber.TabIndex = 0;
            lblAccountNumber.Text = "Número da Conta";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(150, 12);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(200, 23);
            txtAccountNumber.TabIndex = 1;
            // 
            // lblConsumption
            // 
            lblConsumption.AutoSize = true;
            lblConsumption.Location = new Point(12, 50);
            lblConsumption.Name = "lblConsumption";
            lblConsumption.Size = new Size(59, 15);
            lblConsumption.TabIndex = 2;
            lblConsumption.Text = "Consumo";
            // 
            // txtConsumption
            // 
            txtConsumption.Location = new Point(150, 47);
            txtConsumption.Name = "txtConsumption";
            txtConsumption.ReadOnly = true;
            txtConsumption.Size = new Size(200, 23);
            txtConsumption.TabIndex = 3;
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new Point(12, 85);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(61, 15);
            lblTotalValue.TabIndex = 4;
            lblTotalValue.Text = "Valor Total";
            // 
            // txtTotalValue
            // 
            txtTotalValue.Location = new Point(150, 82);
            txtTotalValue.Name = "txtTotalValue";
            txtTotalValue.ReadOnly = true;
            txtTotalValue.Size = new Size(200, 23);
            txtTotalValue.TabIndex = 5;
            // 
            // lblValueWithoutTaxes
            // 
            lblValueWithoutTaxes.AutoSize = true;
            lblValueWithoutTaxes.Location = new Point(12, 120);
            lblValueWithoutTaxes.Name = "lblValueWithoutTaxes";
            lblValueWithoutTaxes.Size = new Size(110, 15);
            lblValueWithoutTaxes.TabIndex = 6;
            lblValueWithoutTaxes.Text = "Valor sem Impostos";
            // 
            // txtValueWithoutTaxes
            // 
            txtValueWithoutTaxes.Location = new Point(150, 117);
            txtValueWithoutTaxes.Name = "txtValueWithoutTaxes";
            txtValueWithoutTaxes.ReadOnly = true;
            txtValueWithoutTaxes.Size = new Size(200, 23);
            txtValueWithoutTaxes.TabIndex = 7;
            // 
            // btnConsult
            // 
            btnConsult.Location = new Point(150, 160);
            btnConsult.Name = "btnConsult";
            btnConsult.Size = new Size(200, 30);
            btnConsult.TabIndex = 8;
            btnConsult.Text = "Consultar";
            btnConsult.UseVisualStyleBackColor = true;
            btnConsult.Click += BtnConsult_Click;
            // 
            // FormsConsultaConta
            // 
            ClientSize = new Size(384, 211);
            Controls.Add(btnConsult);
            Controls.Add(txtValueWithoutTaxes);
            Controls.Add(lblValueWithoutTaxes);
            Controls.Add(txtTotalValue);
            Controls.Add(lblTotalValue);
            Controls.Add(txtConsumption);
            Controls.Add(lblConsumption);
            Controls.Add(txtAccountNumber);
            Controls.Add(lblAccountNumber);
            Name = "FormsConsultaConta";
            Text = "Consulta de Conta";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}