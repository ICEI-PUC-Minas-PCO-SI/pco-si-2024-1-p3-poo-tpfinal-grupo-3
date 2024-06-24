namespace Cemig
{
    partial class FormRegistroConsumo
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
            btnRegistrar = new Button();
            btnVoltar = new Button();
            cbConta = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbLeituraAtual = new TextBox();
            tbLeituraAnterior = new TextBox();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(239, 219);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(86, 219);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // cbConta
            // 
            cbConta.FormattingEnabled = true;
            cbConta.Location = new Point(135, 80);
            cbConta.Name = "cbConta";
            cbConta.Size = new Size(121, 23);
            cbConta.TabIndex = 2;
            cbConta.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 28);
            label1.TabIndex = 3;
            label1.Text = "REGISTRO DE CONSUMO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 62);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 4;
            label2.Text = "Tipo de Conta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 143);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 5;
            label3.Text = "Conta Atual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 143);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 6;
            label4.Text = "Conta Anterior";
            // 
            // tbLeituraAtual
            // 
            tbLeituraAtual.Location = new Point(91, 161);
            tbLeituraAtual.Name = "tbLeituraAtual";
            tbLeituraAtual.Size = new Size(100, 23);
            tbLeituraAtual.TabIndex = 7;
            tbLeituraAtual.TextChanged += tbLeituraAtual_TextChanged;
            // 
            // tbLeituraAnterior
            // 
            tbLeituraAnterior.Location = new Point(214, 161);
            tbLeituraAnterior.Name = "tbLeituraAnterior";
            tbLeituraAnterior.Size = new Size(100, 23);
            tbLeituraAnterior.TabIndex = 8;
            tbLeituraAnterior.TextChanged += tbLeituraAnterior_TextChanged;
            // 
            // FormRegistroConsumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 278);
            Controls.Add(tbLeituraAnterior);
            Controls.Add(tbLeituraAtual);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbConta);
            Controls.Add(btnVoltar);
            Controls.Add(btnRegistrar);
            Name = "FormRegistroConsumo";
            Text = "FormRegistroConsumo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnVoltar;
        private ComboBox cbConta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbLeituraAtual;
        private TextBox tbLeituraAnterior;
    }
}