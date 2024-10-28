namespace SentirseBien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            idturno = new DataGridViewTextBoxColumn();
            nombre_usuario = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            servicio = new DataGridViewTextBoxColumn();
            profesional = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            filtrar_servicio_panel = new Panel();
            filtrar_servicio = new Label();
            filtrar_profesional_panel = new Panel();
            filtrar_profesional = new Label();
            filtrar_fecha_panel = new Panel();
            filtrar_fecha = new Label();
            fecha_label = new Label();
            panel2 = new Panel();
            pedir_turno_panel = new Panel();
            pedir_turno_label = new Label();
            cancelar_turno_panel = new Panel();
            cancelar_turno_label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            filtrar_servicio_panel.SuspendLayout();
            filtrar_profesional_panel.SuspendLayout();
            filtrar_fecha_panel.SuspendLayout();
            panel2.SuspendLayout();
            pedir_turno_panel.SuspendLayout();
            cancelar_turno_panel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 36F);
            label1.ForeColor = Color.FromArgb(232, 235, 233);
            label1.Location = new Point(437, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 50);
            label1.TabIndex = 0;
            label1.Text = "Turnos";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 59, 52);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idturno, nombre_usuario, fecha, servicio, profesional });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(92, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(865, 412);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idturno
            // 
            idturno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idturno.HeaderText = "idturno";
            idturno.MinimumWidth = 6;
            idturno.Name = "idturno";
            // 
            // nombre_usuario
            // 
            nombre_usuario.HeaderText = "nombre_usuario";
            nombre_usuario.MinimumWidth = 6;
            nombre_usuario.Name = "nombre_usuario";
            // 
            // fecha
            // 
            fecha.HeaderText = "fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            // 
            // servicio
            // 
            servicio.HeaderText = "servicio";
            servicio.MinimumWidth = 6;
            servicio.Name = "servicio";
            // 
            // profesional
            // 
            profesional.HeaderText = "profesional";
            profesional.MinimumWidth = 6;
            profesional.Name = "profesional";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.270833F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.7291641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 2);
            tableLayoutPanel1.Controls.Add(fecha_label, 0, 3);
            tableLayoutPanel1.Controls.Add(panel2, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8614235F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.13858F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.Size = new Size(1067, 574);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(filtrar_servicio_panel);
            panel1.Controls.Add(filtrar_profesional_panel);
            panel1.Controls.Add(filtrar_fecha_panel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(92, 471);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 34);
            panel1.TabIndex = 10;
            // 
            // filtrar_servicio_panel
            // 
            filtrar_servicio_panel.BackColor = Color.FromArgb(30, 59, 52);
            filtrar_servicio_panel.Controls.Add(filtrar_servicio);
            filtrar_servicio_panel.Cursor = Cursors.Hand;
            filtrar_servicio_panel.Dock = DockStyle.Right;
            filtrar_servicio_panel.Location = new Point(615, 0);
            filtrar_servicio_panel.Name = "filtrar_servicio_panel";
            filtrar_servicio_panel.Size = new Size(250, 34);
            filtrar_servicio_panel.TabIndex = 2;
            filtrar_servicio_panel.Click += FiltrarServicioClick;
            // 
            // filtrar_servicio
            // 
            filtrar_servicio.Anchor = AnchorStyles.None;
            filtrar_servicio.AutoSize = true;
            filtrar_servicio.Cursor = Cursors.Hand;
            filtrar_servicio.ForeColor = SystemColors.ControlLightLight;
            filtrar_servicio.Location = new Point(61, 4);
            filtrar_servicio.Name = "filtrar_servicio";
            filtrar_servicio.Size = new Size(128, 20);
            filtrar_servicio.TabIndex = 0;
            filtrar_servicio.Text = "Filtrar por servicio";
            filtrar_servicio.Click += FiltrarServicioClick;
            // 
            // filtrar_profesional_panel
            // 
            filtrar_profesional_panel.BackColor = Color.FromArgb(30, 59, 52);
            filtrar_profesional_panel.Controls.Add(filtrar_profesional);
            filtrar_profesional_panel.Cursor = Cursors.Hand;
            filtrar_profesional_panel.Location = new Point(594, 0);
            filtrar_profesional_panel.Name = "filtrar_profesional_panel";
            filtrar_profesional_panel.Size = new Size(250, 34);
            filtrar_profesional_panel.TabIndex = 1;
            filtrar_profesional_panel.Click += FiltrarProfesionalClick;
            // 
            // filtrar_profesional
            // 
            filtrar_profesional.AutoSize = true;
            filtrar_profesional.ForeColor = SystemColors.ControlLightLight;
            filtrar_profesional.Location = new Point(52, 0);
            filtrar_profesional.Name = "filtrar_profesional";
            filtrar_profesional.Size = new Size(153, 20);
            filtrar_profesional.TabIndex = 0;
            filtrar_profesional.Text = "Filtrar por profesional";
            filtrar_profesional.Click += FiltrarProfesionalClick;
            // 
            // filtrar_fecha_panel
            // 
            filtrar_fecha_panel.BackColor = Color.FromArgb(30, 59, 52);
            filtrar_fecha_panel.Controls.Add(filtrar_fecha);
            filtrar_fecha_panel.Cursor = Cursors.Hand;
            filtrar_fecha_panel.Dock = DockStyle.Left;
            filtrar_fecha_panel.Location = new Point(0, 0);
            filtrar_fecha_panel.Name = "filtrar_fecha_panel";
            filtrar_fecha_panel.Size = new Size(231, 34);
            filtrar_fecha_panel.TabIndex = 0;
            filtrar_fecha_panel.Click += FiltrarFechaClick;
            // 
            // filtrar_fecha
            // 
            filtrar_fecha.AutoSize = true;
            filtrar_fecha.Cursor = Cursors.Hand;
            filtrar_fecha.ForeColor = SystemColors.ControlLightLight;
            filtrar_fecha.Location = new Point(53, 4);
            filtrar_fecha.Name = "filtrar_fecha";
            filtrar_fecha.Size = new Size(114, 20);
            filtrar_fecha.TabIndex = 0;
            filtrar_fecha.Text = "Filtrar por fecha";
            filtrar_fecha.Click += FiltrarFechaClick;
            // 
            // fecha_label
            // 
            fecha_label.AutoSize = true;
            fecha_label.ForeColor = SystemColors.ControlLightLight;
            fecha_label.Location = new Point(3, 508);
            fecha_label.Name = "fecha_label";
            fecha_label.Size = new Size(50, 20);
            fecha_label.TabIndex = 9;
            fecha_label.Text = "label2";
            fecha_label.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pedir_turno_panel);
            panel2.Controls.Add(cancelar_turno_panel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(92, 511);
            panel2.Name = "panel2";
            panel2.Size = new Size(865, 36);
            panel2.TabIndex = 11;
            // 
            // pedir_turno_panel
            // 
            pedir_turno_panel.BackColor = Color.FromArgb(30, 59, 52);
            pedir_turno_panel.Controls.Add(pedir_turno_label);
            pedir_turno_panel.Cursor = Cursors.Hand;
            pedir_turno_panel.Dock = DockStyle.Right;
            pedir_turno_panel.Location = new Point(615, 0);
            pedir_turno_panel.Name = "pedir_turno_panel";
            pedir_turno_panel.Size = new Size(250, 36);
            pedir_turno_panel.TabIndex = 1;
            pedir_turno_panel.Visible = false;
            pedir_turno_panel.Click += pedir_turno_cliente_Click;
            // 
            // pedir_turno_label
            // 
            pedir_turno_label.AutoSize = true;
            pedir_turno_label.ForeColor = SystemColors.ControlLightLight;
            pedir_turno_label.Location = new Point(80, 5);
            pedir_turno_label.Name = "pedir_turno_label";
            pedir_turno_label.Size = new Size(84, 20);
            pedir_turno_label.TabIndex = 0;
            pedir_turno_label.Text = "Pedir Turno";
            pedir_turno_label.Visible = false;
            pedir_turno_label.Click += pedir_turno_cliente_Click;
            // 
            // cancelar_turno_panel
            // 
            cancelar_turno_panel.BackColor = Color.FromArgb(30, 59, 52);
            cancelar_turno_panel.Controls.Add(cancelar_turno_label);
            cancelar_turno_panel.Cursor = Cursors.Hand;
            cancelar_turno_panel.Dock = DockStyle.Left;
            cancelar_turno_panel.Location = new Point(0, 0);
            cancelar_turno_panel.Name = "cancelar_turno_panel";
            cancelar_turno_panel.Size = new Size(231, 36);
            cancelar_turno_panel.TabIndex = 0;
            cancelar_turno_panel.Visible = false;
            cancelar_turno_panel.Click += cancelar_turno_button_Click;
            // 
            // cancelar_turno_label
            // 
            cancelar_turno_label.AutoSize = true;
            cancelar_turno_label.ForeColor = SystemColors.ControlLightLight;
            cancelar_turno_label.Location = new Point(57, 5);
            cancelar_turno_label.Name = "cancelar_turno_label";
            cancelar_turno_label.Size = new Size(105, 20);
            cancelar_turno_label.TabIndex = 0;
            cancelar_turno_label.Text = "Cancelar turno";
            cancelar_turno_label.Visible = false;
            cancelar_turno_label.Click += cancelar_turno_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 137, 121);
            ClientSize = new Size(1067, 574);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sentirse Bien";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            filtrar_servicio_panel.ResumeLayout(false);
            filtrar_servicio_panel.PerformLayout();
            filtrar_profesional_panel.ResumeLayout(false);
            filtrar_profesional_panel.PerformLayout();
            filtrar_fecha_panel.ResumeLayout(false);
            filtrar_fecha_panel.PerformLayout();
            panel2.ResumeLayout(false);
            pedir_turno_panel.ResumeLayout(false);
            pedir_turno_panel.PerformLayout();
            cancelar_turno_panel.ResumeLayout(false);
            cancelar_turno_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn idturno;
        private DataGridViewTextBoxColumn nombre_usuario;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn servicio;
        private DataGridViewTextBoxColumn profesional;
        private Label fecha_label;
        private Panel panel1;
        private Panel filtrar_fecha_panel;
        private Panel filtrar_servicio_panel;
        private Panel filtrar_profesional_panel;
        private Label filtrar_fecha;
        private Label filtrar_servicio;
        private Label filtrar_profesional;
        private Panel panel2;
        private Panel pedir_turno_panel;
        private Panel cancelar_turno_panel;
        private Label cancelar_turno_label;
        private Label pedir_turno_label;
    }
}
