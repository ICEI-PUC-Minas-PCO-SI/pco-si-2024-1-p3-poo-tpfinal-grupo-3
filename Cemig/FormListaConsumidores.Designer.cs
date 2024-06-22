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
            this.dataGridViewConsumers = new System.Windows.Forms.DataGridView();
            this.btnDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConsumers
            // 
            this.dataGridViewConsumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsumers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewConsumers.Name = "dataGridViewConsumers";
            this.dataGridViewConsumers.Size = new System.Drawing.Size(760, 400);
            this.dataGridViewConsumers.TabIndex = 0;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(12, 420);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(100, 30);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Ver Detalhes";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // FormListaConsumidores
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.dataGridViewConsumers);
            this.Name = "FormListaConsumidores";
            this.Text = "Listagem de Consumidores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumers)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
