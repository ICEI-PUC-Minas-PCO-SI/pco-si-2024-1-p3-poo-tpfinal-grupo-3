namespace ConsumerApp
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
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblConsumption = new System.Windows.Forms.Label();
            this.txtConsumption = new System.Windows.Forms.TextBox();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.txtTotalValue = new System.Windows.Forms.TextBox();
            this.lblValueWithoutTaxes = new System.Windows.Forms.Label();
            this.txtValueWithoutTaxes = new System.Windows.Forms.TextBox();
            this.btnConsult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(12, 15);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(85, 13);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Número da Conta";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(150, 12);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(200, 20);
            this.txtAccountNumber.TabIndex = 1;
            // 
            // lblConsumption
            // 
            this.lblConsumption.AutoSize = true;
            this.lblConsumption.Location = new System.Drawing.Point(12, 50);
            this.lblConsumption.Name = "lblConsumption";
            this.lblConsumption.Size = new System.Drawing.Size(55, 13);
            this.lblConsumption.TabIndex = 2;
            this.lblConsumption.Text = "Consumo";
            // 
            // txtConsumption
            // 
            this.txtConsumption.Location = new System.Drawing.Point(150, 47);
            this.txtConsumption.Name = "txtConsumption";
            this.txtConsumption.ReadOnly = true;
            this.txtConsumption.Size = new System.Drawing.Size(200, 20);
            this.txtConsumption.TabIndex = 3;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(12, 85);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(54, 13);
            this.lblTotalValue.TabIndex = 4;
            this.lblTotalValue.Text = "Valor Total";
            // 
            // txtTotalValue
            // 
            this.txtTotalValue.Location = new System.Drawing.Point(150, 82);
            this.txtTotalValue.Name = "txtTotalValue";
            this.txtTotalValue.ReadOnly = true;
            this.txtTotalValue.Size = new System.Drawing.Size(200, 20);
            this.txtTotalValue.TabIndex = 5;
            // 
            // lblValueWithoutTaxes
            // 
            this.lblValueWithoutTaxes.AutoSize = true;
            this.lblValueWithoutTaxes.Location = new System.Drawing.Point(12, 120);
            this.lblValueWithoutTaxes.Name = "lblValueWithoutTaxes";
            this.lblValueWithoutTaxes.Size = new System.Drawing.Size(97, 13);
            this.lblValueWithoutTaxes.TabIndex = 6;
            this.lblValueWithoutTaxes.Text = "Valor sem Impostos";
            // 
            // txtValueWithoutTaxes
            // 
            this.txtValueWithoutTaxes.Location = new System.Drawing.Point(150, 117);
            this.txtValueWithoutTaxes.Name = "txtValueWithoutTaxes";
            this.txtValueWithoutTaxes.ReadOnly = true;
            this.txtValueWithoutTaxes.Size = new System.Drawing.Size(200, 20);
            this.txtValueWithoutTaxes.TabIndex = 7;
            // 
            // btnConsult
            // 
            this.btnConsult.Location = new System.Drawing.Point(150, 160);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(200, 30);
            this.btnConsult.TabIndex = 8;
            this.btnConsult.Text = "Consultar";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.BtnConsult_Click);
            // 
            // FormsConsultaConta
            // 
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.txtValueWithoutTaxes);
            this.Controls.Add(this.lblValueWithoutTaxes);
            this.Controls.Add(this.txtTotalValue);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.txtConsumption);
            this.Controls.Add(this.lblConsumption);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Name = "FormsConsultaConta";
            this.Text = "Consulta de Conta";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
