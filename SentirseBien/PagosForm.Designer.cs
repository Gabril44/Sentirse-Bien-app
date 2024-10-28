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
            Medio_Pago = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            id_usuario = new DataGridViewTextBoxColumn();
            fechalimite = new DataGridViewTextBoxColumn();
            servicio = new DataGridViewTextBoxColumn();
            profesional = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1 = new Panel();
            filtrar_profesional_panel = new Panel();
            filtrar_profesional_label = new Label();
            filtrar_fecha_panel = new Panel();
            filtrar_fecha_label = new Label();
            panel4 = new Panel();
            filtrar_mediodepago = new Panel();
            filtrar_mediodepago_label = new Label();
            filtrar_cliente_panel = new Panel();
            filtrar_cliente_label = new Label();
            descargar_informe_panel = new Panel();
            descargar_informe_label = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            filtrar_profesional_panel.SuspendLayout();
            filtrar_fecha_panel.SuspendLayout();
            panel4.SuspendLayout();
            filtrar_mediodepago.SuspendLayout();
            filtrar_cliente_panel.SuspendLayout();
            descargar_informe_panel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.478022F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.52198F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 2);
            tableLayoutPanel1.Controls.Add(panel4, 1, 3);
            tableLayoutPanel1.Controls.Add(descargar_informe_panel, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.27907F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.72093F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 59, 52);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nro_Pago, monto, nombre_cliente, fecha, Medio_Pago, estado, id_usuario, fechalimite, servicio, profesional });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(69, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(624, 272);
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
            // Medio_Pago
            // 
            Medio_Pago.HeaderText = "Medio de Pago";
            Medio_Pago.MinimumWidth = 6;
            Medio_Pago.Name = "Medio_Pago";
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            // 
            // id_usuario
            // 
            id_usuario.HeaderText = "Id_usuario";
            id_usuario.MinimumWidth = 6;
            id_usuario.Name = "id_usuario";
            // 
            // fechalimite
            // 
            fechalimite.HeaderText = "Fecha Limite";
            fechalimite.MinimumWidth = 6;
            fechalimite.Name = "fechalimite";
            // 
            // servicio
            // 
            servicio.HeaderText = "Servicio";
            servicio.MinimumWidth = 6;
            servicio.Name = "servicio";
            // 
            // profesional
            // 
            profesional.HeaderText = "Profesional";
            profesional.MinimumWidth = 6;
            profesional.Name = "profesional";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 36F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(305, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 54);
            label1.TabIndex = 2;
            label1.Text = "Pagos";
            // 
            // panel1
            // 
            panel1.Controls.Add(filtrar_profesional_panel);
            panel1.Controls.Add(filtrar_fecha_panel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(69, 335);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 35);
            panel1.TabIndex = 3;
            // 
            // filtrar_profesional_panel
            // 
            filtrar_profesional_panel.BackColor = Color.FromArgb(30, 59, 52);
            filtrar_profesional_panel.Controls.Add(filtrar_profesional_label);
            filtrar_profesional_panel.Cursor = Cursors.Hand;
            filtrar_profesional_panel.Dock = DockStyle.Right;
            filtrar_profesional_panel.Location = new Point(374, 0);
            filtrar_profesional_panel.Name = "filtrar_profesional_panel";
            filtrar_profesional_panel.Size = new Size(250, 35);
            filtrar_profesional_panel.TabIndex = 1;
            filtrar_profesional_panel.Click += FiltrarProfesionalClick;
            // 
            // filtrar_profesional_label
            // 
            filtrar_profesional_label.AutoSize = true;
            filtrar_profesional_label.ForeColor = SystemColors.ControlLightLight;
            filtrar_profesional_label.Location = new Point(53, 4);
            filtrar_profesional_label.Name = "filtrar_profesional_label";
            filtrar_profesional_label.Size = new Size(153, 20);
            filtrar_profesional_label.TabIndex = 0;
            filtrar_profesional_label.Text = "Filtrar por profesional";
            filtrar_profesional_label.Click += FiltrarProfesionalClick;
            // 
            // filtrar_fecha_panel
            // 
            filtrar_fecha_panel.BackColor = Color.FromArgb(30, 59, 52);
            filtrar_fecha_panel.Controls.Add(filtrar_fecha_label);
            filtrar_fecha_panel.Cursor = Cursors.Hand;
            filtrar_fecha_panel.Dock = DockStyle.Left;
            filtrar_fecha_panel.Location = new Point(0, 0);
            filtrar_fecha_panel.Name = "filtrar_fecha_panel";
            filtrar_fecha_panel.Size = new Size(250, 35);
            filtrar_fecha_panel.TabIndex = 0;
            filtrar_fecha_panel.Click += FiltrarFechaClick;
            // 
            // filtrar_fecha_label
            // 
            filtrar_fecha_label.AutoSize = true;
            filtrar_fecha_label.ForeColor = SystemColors.ControlLightLight;
            filtrar_fecha_label.Location = new Point(64, 4);
            filtrar_fecha_label.Name = "filtrar_fecha_label";
            filtrar_fecha_label.Size = new Size(116, 20);
            filtrar_fecha_label.TabIndex = 0;
            filtrar_fecha_label.Text = "Filtrar por Fecha";
            filtrar_fecha_label.Click += FiltrarFechaClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(filtrar_mediodepago);
            panel4.Controls.Add(filtrar_cliente_panel);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(69, 376);
            panel4.Name = "panel4";
            panel4.Size = new Size(624, 34);
            panel4.TabIndex = 4;
            // 
            // filtrar_mediodepago
            // 
            filtrar_mediodepago.BackColor = Color.FromArgb(30, 59, 52);
            filtrar_mediodepago.Controls.Add(filtrar_mediodepago_label);
            filtrar_mediodepago.Cursor = Cursors.Hand;
            filtrar_mediodepago.Dock = DockStyle.Right;
            filtrar_mediodepago.Location = new Point(374, 0);
            filtrar_mediodepago.Name = "filtrar_mediodepago";
            filtrar_mediodepago.Size = new Size(250, 34);
            filtrar_mediodepago.TabIndex = 1;
            filtrar_mediodepago.Click += MediodePagoClick;
            // 
            // filtrar_mediodepago_label
            // 
            filtrar_mediodepago_label.AutoSize = true;
            filtrar_mediodepago_label.Cursor = Cursors.Hand;
            filtrar_mediodepago_label.ForeColor = SystemColors.ControlLightLight;
            filtrar_mediodepago_label.Location = new Point(39, 8);
            filtrar_mediodepago_label.Name = "filtrar_mediodepago_label";
            filtrar_mediodepago_label.Size = new Size(179, 20);
            filtrar_mediodepago_label.TabIndex = 0;
            filtrar_mediodepago_label.Text = "Filtrar por Medio de Pago";
            filtrar_mediodepago_label.Click += MediodePagoClick;
            // 
            // filtrar_cliente_panel
            // 
            filtrar_cliente_panel.BackColor = Color.FromArgb(30, 59, 52);
            filtrar_cliente_panel.Controls.Add(filtrar_cliente_label);
            filtrar_cliente_panel.Cursor = Cursors.Hand;
            filtrar_cliente_panel.Dock = DockStyle.Left;
            filtrar_cliente_panel.Location = new Point(0, 0);
            filtrar_cliente_panel.Name = "filtrar_cliente_panel";
            filtrar_cliente_panel.Size = new Size(250, 34);
            filtrar_cliente_panel.TabIndex = 0;
            filtrar_cliente_panel.Click += FiltrarClienteClick;
            // 
            // filtrar_cliente_label
            // 
            filtrar_cliente_label.AutoSize = true;
            filtrar_cliente_label.Cursor = Cursors.Hand;
            filtrar_cliente_label.ForeColor = SystemColors.ControlLightLight;
            filtrar_cliente_label.Location = new Point(64, 8);
            filtrar_cliente_label.Name = "filtrar_cliente_label";
            filtrar_cliente_label.Size = new Size(122, 20);
            filtrar_cliente_label.TabIndex = 0;
            filtrar_cliente_label.Text = "Filtrar por cliente";
            filtrar_cliente_label.Click += FiltrarClienteClick;
            // 
            // descargar_informe_panel
            // 
            descargar_informe_panel.Anchor = AnchorStyles.None;
            descargar_informe_panel.BackColor = Color.FromArgb(30, 59, 52);
            descargar_informe_panel.Controls.Add(descargar_informe_label);
            descargar_informe_panel.Cursor = Cursors.Hand;
            descargar_informe_panel.Location = new Point(256, 416);
            descargar_informe_panel.Name = "descargar_informe_panel";
            descargar_informe_panel.Size = new Size(250, 31);
            descargar_informe_panel.TabIndex = 5;
            descargar_informe_panel.Click += imprimir_button_Click;
            // 
            // descargar_informe_label
            // 
            descargar_informe_label.AutoSize = true;
            descargar_informe_label.ForeColor = SystemColors.ControlLightLight;
            descargar_informe_label.Location = new Point(59, 5);
            descargar_informe_label.Name = "descargar_informe_label";
            descargar_informe_label.Size = new Size(132, 20);
            descargar_informe_label.TabIndex = 0;
            descargar_informe_label.Text = "Descargar Informe";
            descargar_informe_label.Click += imprimir_button_Click;
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
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            filtrar_profesional_panel.ResumeLayout(false);
            filtrar_profesional_panel.PerformLayout();
            filtrar_fecha_panel.ResumeLayout(false);
            filtrar_fecha_panel.PerformLayout();
            panel4.ResumeLayout(false);
            filtrar_mediodepago.ResumeLayout(false);
            filtrar_mediodepago.PerformLayout();
            filtrar_cliente_panel.ResumeLayout(false);
            filtrar_cliente_panel.PerformLayout();
            descargar_informe_panel.ResumeLayout(false);
            descargar_informe_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nro_Pago;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewTextBoxColumn nombre_cliente;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn Medio_Pago;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn id_usuario;
        private DataGridViewTextBoxColumn fechalimite;
        private DataGridViewTextBoxColumn servicio;
        private DataGridViewTextBoxColumn profesional;
        private Label label1;
        private Panel panel1;
        private Panel filtrar_profesional_panel;
        private Panel filtrar_fecha_panel;
        private Panel panel4;
        private Panel filtrar_cliente_panel;
        private Panel filtrar_mediodepago;
        private Panel descargar_informe_panel;
        private Label descargar_informe_label;
        private Label filtrar_profesional_label;
        private Label filtrar_fecha_label;
        private Label filtrar_mediodepago_label;
        private Label filtrar_cliente_label;
    }
}