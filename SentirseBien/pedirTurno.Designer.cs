namespace SentirseBien
{
    partial class pedirTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pedirTurno));
            tableLayoutPanel1 = new TableLayoutPanel();
            titulo_label = new Label();
            aceptar_button = new Button();
            cancelar_button = new Button();
            hora_combobox = new ComboBox();
            minutoscombobox = new ComboBox();
            servicios_combobox = new ComboBox();
            profesional_combobox = new ComboBox();
            panel2 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            fecha_button = new Button();
            labelfecha = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.55692F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.44308F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 258F));
            tableLayoutPanel1.Controls.Add(titulo_label, 1, 0);
            tableLayoutPanel1.Controls.Add(aceptar_button, 2, 6);
            tableLayoutPanel1.Controls.Add(cancelar_button, 0, 6);
            tableLayoutPanel1.Controls.Add(hora_combobox, 1, 3);
            tableLayoutPanel1.Controls.Add(minutoscombobox, 2, 3);
            tableLayoutPanel1.Controls.Add(servicios_combobox, 1, 5);
            tableLayoutPanel1.Controls.Add(profesional_combobox, 1, 4);
            tableLayoutPanel1.Controls.Add(panel2, 0, 3);
            tableLayoutPanel1.Controls.Add(panel3, 0, 4);
            tableLayoutPanel1.Controls.Add(panel4, 0, 5);
            tableLayoutPanel1.Controls.Add(panel5, 0, 2);
            tableLayoutPanel1.Controls.Add(fecha_button, 1, 2);
            tableLayoutPanel1.Controls.Add(labelfecha, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.36842F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.63158F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 159F));
            tableLayoutPanel1.Size = new Size(800, 452);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // titulo_label
            // 
            titulo_label.Anchor = AnchorStyles.None;
            titulo_label.AutoSize = true;
            titulo_label.ForeColor = SystemColors.ControlLightLight;
            titulo_label.Location = new Point(334, 3);
            titulo_label.Name = "titulo_label";
            titulo_label.Size = new Size(102, 20);
            titulo_label.TabIndex = 5;
            titulo_label.Text = "PEDIR TURNO";
            // 
            // aceptar_button
            // 
            aceptar_button.Anchor = AnchorStyles.None;
            aceptar_button.Location = new Point(559, 350);
            aceptar_button.Name = "aceptar_button";
            aceptar_button.Size = new Size(223, 44);
            aceptar_button.TabIndex = 4;
            aceptar_button.Text = "Aceptar";
            aceptar_button.UseVisualStyleBackColor = true;
            aceptar_button.Click += aceptar_button_Click;
            // 
            // cancelar_button
            // 
            cancelar_button.Anchor = AnchorStyles.None;
            cancelar_button.Location = new Point(13, 350);
            cancelar_button.Name = "cancelar_button";
            cancelar_button.Size = new Size(204, 43);
            cancelar_button.TabIndex = 19;
            cancelar_button.Text = "Cancelar";
            cancelar_button.UseVisualStyleBackColor = true;
            cancelar_button.Click += cancelar_button_Click;
            // 
            // hora_combobox
            // 
            hora_combobox.Anchor = AnchorStyles.None;
            hora_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            hora_combobox.FormattingEnabled = true;
            hora_combobox.Location = new Point(233, 131);
            hora_combobox.Name = "hora_combobox";
            hora_combobox.Size = new Size(305, 28);
            hora_combobox.TabIndex = 18;
            // 
            // minutoscombobox
            // 
            minutoscombobox.Anchor = AnchorStyles.None;
            minutoscombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            minutoscombobox.FormattingEnabled = true;
            minutoscombobox.Location = new Point(544, 131);
            minutoscombobox.Name = "minutoscombobox";
            minutoscombobox.Size = new Size(253, 28);
            minutoscombobox.TabIndex = 17;
            // 
            // servicios_combobox
            // 
            servicios_combobox.Anchor = AnchorStyles.None;
            servicios_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            servicios_combobox.FormattingEnabled = true;
            servicios_combobox.Location = new Point(233, 249);
            servicios_combobox.Name = "servicios_combobox";
            servicios_combobox.Size = new Size(305, 28);
            servicios_combobox.TabIndex = 12;
            // 
            // profesional_combobox
            // 
            profesional_combobox.Anchor = AnchorStyles.None;
            profesional_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            profesional_combobox.FormattingEnabled = true;
            profesional_combobox.Items.AddRange(new object[] { "Dr Manuel", "Dr Pablinka", "Dra Felicidad", "Dr Tristeza" });
            profesional_combobox.Location = new Point(233, 190);
            profesional_combobox.Name = "profesional_combobox";
            profesional_combobox.Size = new Size(305, 28);
            profesional_combobox.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 59, 52);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 52);
            panel2.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(74, 11);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 16;
            label4.Text = "Horario";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 59, 52);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 177);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 53);
            panel3.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(64, 15);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 7;
            label2.Text = "Profesional";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 59, 52);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(3, 237);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 52);
            panel4.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(74, 14);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 6;
            label1.Text = "Servicio";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 59, 52);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 61);
            panel5.Name = "panel5";
            panel5.Size = new Size(224, 52);
            panel5.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(78, 11);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 8;
            label3.Text = "Fecha";
            // 
            // fecha_button
            // 
            fecha_button.Anchor = AnchorStyles.None;
            fecha_button.Location = new Point(233, 69);
            fecha_button.Name = "fecha_button";
            fecha_button.Size = new Size(305, 36);
            fecha_button.TabIndex = 13;
            fecha_button.Text = "Elegir Fecha";
            fecha_button.UseVisualStyleBackColor = true;
            fecha_button.Click += fecha_button_Click;
            // 
            // labelfecha
            // 
            labelfecha.AutoSize = true;
            labelfecha.ForeColor = SystemColors.ControlLightLight;
            labelfecha.Location = new Point(544, 58);
            labelfecha.Name = "labelfecha";
            labelfecha.Size = new Size(148, 20);
            labelfecha.TabIndex = 14;
            labelfecha.Text = "Seleccione una fecha";
            labelfecha.Visible = false;
            // 
            // pedirTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 115, 100);
            ClientSize = new Size(800, 452);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "pedirTurno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sentirse Bien";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button aceptar_button;
        private Label titulo_label;
        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip servicios;
        private ToolStripMenuItem seleccioneUnServicioToolStripMenuItem;
        private ToolStripMenuItem masajeToolStripMenuItem;
        private ToolStripMenuItem opcion2ToolStripMenuItem;
        private ToolStripMenuItem opcion3ToolStripMenuItem;
        private ToolStripMenuItem opcion4ToolStripMenuItem;
        private ComboBox profesional_combobox;
        private ComboBox servicios_combobox;
        private Button fecha_button;
        private Label labelfecha;
        private Label label4;
        private ComboBox minutoscombobox;
        private ComboBox hora_combobox;
        private Button cancelar_button;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}