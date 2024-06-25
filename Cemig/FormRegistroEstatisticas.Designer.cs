namespace Cemig
{
    partial class FormRegistroEstatisticas
    {
        private System.ComponentModel.IContainer components = null;

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
            label2 = new Label();
            label1 = new Label();
            cbPeriodo = new ComboBox();
            btnVoltar = new Button();
            btnAtualizar = new Button();
            dataGridViewConsumo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsumo).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new Point(140, 58);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 13;
            label2.Text = "Selecionar Período";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(83, 21);
            label1.Name = "label1";
            label1.Size = new Size(251, 28);
            label1.TabIndex = 12;
            label1.Text = "RELATÓRIO E ESTATÍSTICAS";
            // 
            // cbPeriodo
            // 
            cbPeriodo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            cbPeriodo.FormattingEnabled = true;
            cbPeriodo.Location = new Point(100, 100);
            cbPeriodo.Name = "cbPeriodo";
            cbPeriodo.Size = new Size(200, 29);
            cbPeriodo.TabIndex = 11;
            cbPeriodo.SelectedIndexChanged += cbPeriodo_SelectedIndexChanged;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(220, 270);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(100, 30);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(80, 270);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(100, 30);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "ATUALIZAR";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // dataGridViewConsumo
            // 
            dataGridViewConsumo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsumo.Location = new Point(80, 140);
            dataGridViewConsumo.Name = "dataGridViewConsumo";
            dataGridViewConsumo.Size = new Size(240, 100);
            dataGridViewConsumo.TabIndex = 14;
            dataGridViewConsumo.CellContentClick += dataGridViewConsumo_CellContentClick;
            // 
            // FormRegistroEstatisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 350);
            Controls.Add(dataGridViewConsumo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbPeriodo);
            Controls.Add(btnVoltar);
            Controls.Add(btnAtualizar);
            Name = "FormRegistroEstatisticas";
            Text = "RELATÓRIO E ESTATÍSTICAS";
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsumo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ComboBox cbPeriodo;
        private Button btnVoltar;
        private Button btnAtualizar;
        private DataGridView dataGridViewConsumo;
    }
}
