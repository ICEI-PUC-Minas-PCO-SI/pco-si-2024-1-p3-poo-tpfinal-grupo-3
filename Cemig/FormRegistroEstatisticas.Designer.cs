namespace Cemig
{
    partial class FormRegistroEstatisticas
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
            label2.Location = new Point(159, 58);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 13;
            label2.Text = "Selecionar Período";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(83, 21);
            label1.Name = "label1";
            label1.Size = new Size(251, 28);
            label1.TabIndex = 12;
            label1.Text = "RELÁTORIO E ESTATÍSTICAS";
            // 
            // cbPeriodo
            // 
            cbPeriodo.FormattingEnabled = true;
            cbPeriodo.Location = new Point(146, 76);
            cbPeriodo.Name = "cbPeriodo";
            cbPeriodo.Size = new Size(121, 23);
            cbPeriodo.TabIndex = 11;
            cbPeriodo.SelectedIndexChanged += cbPeriodo_SelectedIndexChanged;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(259, 273);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(94, 273);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "ATUALIZAR";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // dataGridViewConsumo
            // 
            dataGridViewConsumo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsumo.Location = new Point(94, 105);
            dataGridViewConsumo.Name = "dataGridViewConsumo";
            dataGridViewConsumo.Size = new Size(240, 150);
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
            Text = "FormRegistroEstatisticas";
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