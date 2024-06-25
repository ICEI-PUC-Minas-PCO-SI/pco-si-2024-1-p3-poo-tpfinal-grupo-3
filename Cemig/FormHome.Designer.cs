namespace ConsumerApp
{
    partial class FormHome
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewAccounts;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnRegisterConsumption;
        private System.Windows.Forms.Button btnConsultAccounts;

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
            this.dataGridViewAccounts = new System.Windows.Forms.DataGridView();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnRegisterConsumption = new System.Windows.Forms.Button();
            this.btnConsultAccounts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
            this.SuspendLayout();

            this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccounts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAccounts.Name = "dataGridViewAccounts";
            this.dataGridViewAccounts.Size = new System.Drawing.Size(460, 200);
            this.dataGridViewAccounts.TabIndex = 0;

            this.btnAddAccount.Location = new System.Drawing.Point(12, 230);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(140, 30);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Adicionar Conta";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.BtnAddAccount_Click);

            this.btnRegisterConsumption.Location = new System.Drawing.Point(166, 230);
            this.btnRegisterConsumption.Name = "btnRegisterConsumption";
            this.btnRegisterConsumption.Size = new System.Drawing.Size(140, 30);
            this.btnRegisterConsumption.TabIndex = 2;
            this.btnRegisterConsumption.Text = "Registrar Consumo";
            this.btnRegisterConsumption.UseVisualStyleBackColor = true;
            this.btnRegisterConsumption.Click += new System.EventHandler(this.BtnRegisterConsumption_Click);

            this.btnConsultAccounts.Location = new System.Drawing.Point(320, 230);
            this.btnConsultAccounts.Name = "btnConsultAccounts";
            this.btnConsultAccounts.Size = new System.Drawing.Size(140, 30);
            this.btnConsultAccounts.TabIndex = 3;
            this.btnConsultAccounts.Text = "Consultar Contas";
            this.btnConsultAccounts.UseVisualStyleBackColor = true;
            this.btnConsultAccounts.Click += new System.EventHandler(this.BtnConsultAccounts_Click);

            this.ClientSize = new System.Drawing.Size(484, 281);
            this.Controls.Add(this.btnConsultAccounts);
            this.Controls.Add(this.btnRegisterConsumption);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.dataGridViewAccounts);
            this.Name = "FormHome";
            this.Text = "Tela Principal do Consumidor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
