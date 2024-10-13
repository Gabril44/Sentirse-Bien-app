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
            aceptar_button = new Button();
            titulo_label = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            profesional_combobox = new ComboBox();
            servicios_combobox = new ComboBox();
            fecha_button = new Button();
            labelfecha = new Label();
            test_label = new Label();
            label4 = new Label();
            minutoscombobox = new ComboBox();
            hora_combobox = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.55692F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.44308F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 258F));
            tableLayoutPanel1.Controls.Add(titulo_label, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(profesional_combobox, 1, 2);
            tableLayoutPanel1.Controls.Add(servicios_combobox, 1, 1);
            tableLayoutPanel1.Controls.Add(fecha_button, 1, 3);
            tableLayoutPanel1.Controls.Add(labelfecha, 1, 4);
            tableLayoutPanel1.Controls.Add(test_label, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 5);
            tableLayoutPanel1.Controls.Add(hora_combobox, 1, 5);
            tableLayoutPanel1.Controls.Add(aceptar_button, 2, 6);
            tableLayoutPanel1.Controls.Add(minutoscombobox, 2, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // aceptar_button
            // 
            aceptar_button.Location = new Point(544, 418);
            aceptar_button.Name = "aceptar_button";
            aceptar_button.Size = new Size(223, 29);
            aceptar_button.TabIndex = 4;
            aceptar_button.Text = "Aceptar";
            aceptar_button.UseVisualStyleBackColor = true;
            aceptar_button.Click += aceptar_button_Click;
            // 
            // titulo_label
            // 
            titulo_label.AutoSize = true;
            titulo_label.Dock = DockStyle.Bottom;
            titulo_label.ForeColor = SystemColors.ControlLightLight;
            titulo_label.Location = new Point(233, 19);
            titulo_label.Name = "titulo_label";
            titulo_label.Size = new Size(305, 20);
            titulo_label.TabIndex = 5;
            titulo_label.Text = "PEDIR TURNO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 95);
            label1.Name = "label1";
            label1.Size = new Size(224, 20);
            label1.TabIndex = 6;
            label1.Text = "servicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(3, 178);
            label2.Name = "label2";
            label2.Size = new Size(224, 20);
            label2.TabIndex = 7;
            label2.Text = "profesional";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(3, 274);
            label3.Name = "label3";
            label3.Size = new Size(224, 20);
            label3.TabIndex = 8;
            label3.Text = "fecha";
            // 
            // profesional_combobox
            // 
            profesional_combobox.Dock = DockStyle.Bottom;
            profesional_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            profesional_combobox.FormattingEnabled = true;
            profesional_combobox.Items.AddRange(new object[] { "Dr Manuel", "Dr Pablinka", "Dra Felicidad", "Dr Tristeza" });
            profesional_combobox.Location = new Point(233, 167);
            profesional_combobox.Name = "profesional_combobox";
            profesional_combobox.Size = new Size(305, 28);
            profesional_combobox.TabIndex = 10;
            // 
            // servicios_combobox
            // 
            servicios_combobox.Dock = DockStyle.Bottom;
            servicios_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            servicios_combobox.FormattingEnabled = true;
            servicios_combobox.Location = new Point(233, 84);
            servicios_combobox.Name = "servicios_combobox";
            servicios_combobox.Size = new Size(305, 28);
            servicios_combobox.TabIndex = 12;
            // 
            // fecha_button
            // 
            fecha_button.Dock = DockStyle.Bottom;
            fecha_button.Location = new Point(233, 262);
            fecha_button.Name = "fecha_button";
            fecha_button.Size = new Size(305, 29);
            fecha_button.TabIndex = 13;
            fecha_button.Text = "Elegir Fecha";
            fecha_button.UseVisualStyleBackColor = true;
            fecha_button.Click += fecha_button_Click;
            // 
            // labelfecha
            // 
            labelfecha.AutoSize = true;
            labelfecha.Dock = DockStyle.Bottom;
            labelfecha.ForeColor = SystemColors.ControlLightLight;
            labelfecha.Location = new Point(233, 361);
            labelfecha.Name = "labelfecha";
            labelfecha.Size = new Size(305, 20);
            labelfecha.TabIndex = 14;
            labelfecha.Text = "label4";
            // 
            // test_label
            // 
            test_label.AutoSize = true;
            test_label.Location = new Point(3, 294);
            test_label.Name = "test_label";
            test_label.Size = new Size(50, 20);
            test_label.TabIndex = 15;
            test_label.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(3, 395);
            label4.Name = "label4";
            label4.Size = new Size(224, 20);
            label4.TabIndex = 16;
            label4.Text = "horario";
            // 
            // minutoscombobox
            // 
            minutoscombobox.Dock = DockStyle.Bottom;
            minutoscombobox.FormattingEnabled = true;
            minutoscombobox.Location = new Point(544, 384);
            minutoscombobox.Name = "minutoscombobox";
            minutoscombobox.Size = new Size(253, 28);
            minutoscombobox.TabIndex = 17;
            // 
            // hora_combobox
            // 
            hora_combobox.Dock = DockStyle.Bottom;
            hora_combobox.FormattingEnabled = true;
            hora_combobox.Location = new Point(233, 384);
            hora_combobox.Name = "hora_combobox";
            hora_combobox.Size = new Size(305, 28);
            hora_combobox.TabIndex = 18;
            // 
            // pedirTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 137, 121);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "pedirTurno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sentirse Bien";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private Label test_label;
        private Label label4;
        private ComboBox minutoscombobox;
        private ComboBox hora_combobox;
    }
}