namespace Cemig
{
    partial class FormListaConsumidores
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewConsumers;
        private System.Windows.Forms.Button btnDetails;

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
            dataGridViewConsumers = new DataGridView();
            btnDetails = new Button();
            resEst = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsumers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewConsumers
            // 
            dataGridViewConsumers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsumers.Location = new Point(12, 12);
            dataGridViewConsumers.Name = "dataGridViewConsumers";
            dataGridViewConsumers.Size = new Size(760, 400);
            dataGridViewConsumers.TabIndex = 0;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(12, 420);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(100, 30);
            btnDetails.TabIndex = 1;
            btnDetails.Text = "Ver Detalhes";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // resEst
            // 
            resEst.Location = new Point(637, 423);
            resEst.Name = "resEst";
            resEst.Size = new Size(135, 27);
            resEst.TabIndex = 2;
            resEst.Text = "Registro de Estatisticas";
            resEst.UseVisualStyleBackColor = true;
            resEst.Click += resEst_Click;
            // 
            // FormListaConsumidores
            // 
            ClientSize = new Size(784, 461);
            Controls.Add(resEst);
            Controls.Add(btnDetails);
            Controls.Add(dataGridViewConsumers);
            Name = "FormListaConsumidores";
            Text = "Listagem de Consumidores";
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsumers).EndInit();
            ResumeLayout(false);
        }

        private Button resEst;
    }
}
