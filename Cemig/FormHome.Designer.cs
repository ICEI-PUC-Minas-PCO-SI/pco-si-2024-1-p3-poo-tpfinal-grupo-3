namespace Cemig
{
    partial class FormHome
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewAccounts;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnRegisterConsumption;
        private System.Windows.Forms.Button btnConsultAccounts;
        private System.Windows.Forms.PictureBox editUser;
        private System.Windows.Forms.Label label1;

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
            dataGridViewAccounts = new DataGridView();
            btnAddAccount = new Button();
            btnRegisterConsumption = new Button();
            btnConsultAccounts = new Button();
            editUser = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editUser).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAccounts
            // 
            dataGridViewAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccounts.Location = new Point(12, 12);
            dataGridViewAccounts.Name = "dataGridViewAccounts";
            dataGridViewAccounts.Size = new Size(460, 200);
            dataGridViewAccounts.TabIndex = 0;
            dataGridViewAccounts.CellContentClick += dataGridViewAccounts_CellContentClick;
            // 
            // btnAddAccount
            // 
            btnAddAccount.BackColor = Color.FromArgb(0, 122, 204);
            btnAddAccount.FlatStyle = FlatStyle.Flat;
            btnAddAccount.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddAccount.ForeColor = Color.White;
            btnAddAccount.Location = new Point(12, 230);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(140, 40);
            btnAddAccount.TabIndex = 1;
            btnAddAccount.Text = "Adicionar Conta";
            btnAddAccount.UseVisualStyleBackColor = false;
            btnAddAccount.Click += BtnAddAccount_Click;
            // 
            // btnRegisterConsumption
            // 
            btnRegisterConsumption.BackColor = Color.FromArgb(0, 122, 204);
            btnRegisterConsumption.FlatStyle = FlatStyle.Flat;
            btnRegisterConsumption.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegisterConsumption.ForeColor = Color.White;
            btnRegisterConsumption.Location = new Point(166, 230);
            btnRegisterConsumption.Name = "btnRegisterConsumption";
            btnRegisterConsumption.Size = new Size(140, 40);
            btnRegisterConsumption.TabIndex = 2;
            btnRegisterConsumption.Text = "Registrar Consumo";
            btnRegisterConsumption.UseVisualStyleBackColor = false;
            btnRegisterConsumption.Click += BtnRegisterConsumption_Click;
            // 
            // btnConsultAccounts
            // 
            btnConsultAccounts.BackColor = Color.FromArgb(0, 122, 204);
            btnConsultAccounts.FlatStyle = FlatStyle.Flat;
            btnConsultAccounts.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultAccounts.ForeColor = Color.White;
            btnConsultAccounts.Location = new Point(320, 230);
            btnConsultAccounts.Name = "btnConsultAccounts";
            btnConsultAccounts.Size = new Size(140, 40);
            btnConsultAccounts.TabIndex = 3;
            btnConsultAccounts.Text = "Consultar Contas";
            btnConsultAccounts.UseVisualStyleBackColor = false;
            btnConsultAccounts.Click += BtnConsultAccounts_Click;
            // 
            // editUser
            // 
            editUser.BackgroundImage = Properties.Resources.edit;
            editUser.BackgroundImageLayout = ImageLayout.Stretch;
            editUser.Location = new Point(506, 12);
            editUser.Name = "editUser";
            editUser.Size = new Size(44, 35);
            editUser.TabIndex = 4;
            editUser.TabStop = false;
            editUser.Click += editUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(492, 50);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "Editar Usuario";
            // 
            // FormHome
            // 
            ClientSize = new Size(575, 281);
            Controls.Add(label1);
            Controls.Add(editUser);
            Controls.Add(btnConsultAccounts);
            Controls.Add(btnRegisterConsumption);
            Controls.Add(btnAddAccount);
            Controls.Add(dataGridViewAccounts);
            Name = "FormHome";
            Text = "Tela Principal do Consumidor";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)editUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
