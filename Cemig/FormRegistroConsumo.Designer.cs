namespace Cemig
{
    partial class FormRegistroConsumo
    {
        private System.ComponentModel.IContainer components = null;

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

            btnRegistrar.BackColor = Color.FromArgb(0, 122, 204);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(210, 220);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(130, 40);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
 
            btnVoltar.BackColor = Color.FromArgb(0, 122, 204);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(70, 220);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(130, 40);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
      
            cbConta.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbConta.FormattingEnabled = true;
            cbConta.Location = new Point(100, 90);
            cbConta.Name = "cbConta";
            cbConta.Size = new Size(200, 24);
            cbConta.TabIndex = 2;
            cbConta.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 20);
            label1.Name = "label1";
            label1.Size = new Size(234, 24);
            label1.TabIndex = 3;
            label1.Text = "REGISTRO DE CONSUMO";
      
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(100, 70);
            label2.Name = "label2";
            label2.Size = new Size(91, 16);
            label2.TabIndex = 4;
            label2.Text = "Tipo de Conta";
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 140);
            label3.Name = "label3";
            label3.Size = new Size(91, 16);
            label3.TabIndex = 5;
            label3.Text = "Leitura Atual";

            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(220, 140);
            label4.Name = "label4";
            label4.Size = new Size(106, 16);
            label4.TabIndex = 6;
            label4.Text = "Leitura Anterior";
    
            tbLeituraAtual.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbLeituraAtual.Location = new Point(70, 160);
            tbLeituraAtual.Name = "tbLeituraAtual";
            tbLeituraAtual.Size = new Size(120, 23);
            tbLeituraAtual.TabIndex = 7;
            tbLeituraAtual.TextChanged += tbLeituraAtual_TextChanged;
    
            tbLeituraAnterior.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbLeituraAnterior.Location = new Point(220, 160);
            tbLeituraAnterior.Name = "tbLeituraAnterior";
            tbLeituraAnterior.Size = new Size(120, 23);
            tbLeituraAnterior.TabIndex = 8;
            tbLeituraAnterior.TextChanged += tbLeituraAnterior_TextChanged;
 
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
            Text = "Registro de Consumo";
            ResumeLayout(false);
            PerformLayout();
        }

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
