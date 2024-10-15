namespace SentirseBien
{
    partial class PagosForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            Nro_Pago = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            nombre_cliente = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.9884167F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.01158F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.27907F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.72093F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 59, 52);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nro_Pago, monto, nombre_cliente, fecha });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(121, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(573, 315);
            dataGridView1.TabIndex = 0;
            // 
            // Nro_Pago
            // 
            Nro_Pago.HeaderText = "Nro Pago";
            Nro_Pago.MinimumWidth = 6;
            Nro_Pago.Name = "Nro_Pago";
            // 
            // monto
            // 
            monto.HeaderText = "Monto";
            monto.MinimumWidth = 6;
            monto.Name = "monto";
            // 
            // nombre_cliente
            // 
            nombre_cliente.HeaderText = "Nombre del Cliente";
            nombre_cliente.MinimumWidth = 6;
            nombre_cliente.Name = "nombre_cliente";
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            // 
            // PagosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 115, 100);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "PagosForm";
            Text = "PagosForm";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nro_Pago;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewTextBoxColumn nombre_cliente;
        private DataGridViewTextBoxColumn fecha;
    }
}