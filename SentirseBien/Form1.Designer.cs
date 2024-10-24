﻿namespace SentirseBien
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
            pedir_turno_cliente = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            cancelar_turno_button = new Button();
            filtrar_fecha_button = new Button();
            filtrar_servicio_button = new Button();
            fecha_label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            label1.Size = new Size(174, 46);
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
            dataGridView1.Location = new Point(92, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(865, 377);
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
            // pedir_turno_cliente
            // 
            pedir_turno_cliente.Location = new Point(963, 537);
            pedir_turno_cliente.Name = "pedir_turno_cliente";
            pedir_turno_cliente.Size = new Size(94, 29);
            pedir_turno_cliente.TabIndex = 5;
            pedir_turno_cliente.Text = "Pedir turno";
            pedir_turno_cliente.UseVisualStyleBackColor = true;
            pedir_turno_cliente.Click += pedir_turno_cliente_Click;
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
            tableLayoutPanel1.Controls.Add(pedir_turno_cliente, 2, 5);
            tableLayoutPanel1.Controls.Add(cancelar_turno_button, 1, 5);
            tableLayoutPanel1.Controls.Add(filtrar_fecha_button, 1, 3);
            tableLayoutPanel1.Controls.Add(filtrar_servicio_button, 1, 2);
            tableLayoutPanel1.Controls.Add(fecha_label, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8614235F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.13858F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.Size = new Size(1067, 574);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // cancelar_turno_button
            // 
            cancelar_turno_button.Location = new Point(92, 537);
            cancelar_turno_button.Name = "cancelar_turno_button";
            cancelar_turno_button.Size = new Size(113, 29);
            cancelar_turno_button.TabIndex = 6;
            cancelar_turno_button.Text = "Cancelar turno";
            cancelar_turno_button.UseVisualStyleBackColor = true;
            cancelar_turno_button.Visible = false;
            cancelar_turno_button.Click += cancelar_turno_button_Click;
            // 
            // filtrar_fecha_button
            // 
            filtrar_fecha_button.Location = new Point(92, 465);
            filtrar_fecha_button.Name = "filtrar_fecha_button";
            filtrar_fecha_button.Size = new Size(176, 29);
            filtrar_fecha_button.TabIndex = 7;
            filtrar_fecha_button.Text = "Filtrar por fecha";
            filtrar_fecha_button.UseVisualStyleBackColor = true;
            filtrar_fecha_button.Click += FiltrarFechaClick;
            // 
            // filtrar_servicio_button
            // 
            filtrar_servicio_button.Location = new Point(92, 432);
            filtrar_servicio_button.Name = "filtrar_servicio_button";
            filtrar_servicio_button.Size = new Size(176, 27);
            filtrar_servicio_button.TabIndex = 8;
            filtrar_servicio_button.Text = "Filtrar por servicio";
            filtrar_servicio_button.UseVisualStyleBackColor = true;
            filtrar_servicio_button.Click += button2_Click;
            // 
            // fecha_label
            // 
            fecha_label.AutoSize = true;
            fecha_label.ForeColor = SystemColors.ControlLightLight;
            fecha_label.Location = new Point(92, 500);
            fecha_label.Name = "fecha_label";
            fecha_label.Size = new Size(50, 20);
            fecha_label.TabIndex = 9;
            fecha_label.Text = "label2";
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
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button pedir_turno_cliente;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn idturno;
        private DataGridViewTextBoxColumn nombre_usuario;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn servicio;
        private DataGridViewTextBoxColumn profesional;
        private Button cancelar_turno_button;
        private Button filtrar_fecha_button;
        private Button filtrar_servicio_button;
        private Label fecha_label;
    }
}
