namespace SentirseBien
{
    partial class PagoForm
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
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            label5 = new Label();
            label13 = new Label();
            label10 = new Label();
            panelAceptarPago = new Panel();
            labelAceptarPago = new Label();
            label6 = new Label();
            panel4 = new Panel();
            label11 = new Label();
            label12 = new Label();
            PagoForm_Nombre = new Panel();
            label7 = new Label();
            label1 = new Label();
            tarjeta_combox = new ComboBox();
            cuotas_combobox = new ComboBox();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panelAceptarPago.SuspendLayout();
            panel4.SuspendLayout();
            PagoForm_Nombre.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.3870964F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.6129036F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 263F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 0, 3);
            tableLayoutPanel1.Controls.Add(panel3, 1, 5);
            tableLayoutPanel1.Controls.Add(panel4, 0, 1);
            tableLayoutPanel1.Controls.Add(PagoForm_Nombre, 0, 4);
            tableLayoutPanel1.Controls.Add(tarjeta_combox, 1, 1);
            tableLayoutPanel1.Controls.Add(cuotas_combobox, 2, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.70731F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.2926826F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.tarjeta;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(262, 246);
            textBox2.Margin = new Padding(3, 13, 3, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(262, 294);
            textBox3.Margin = new Padding(3, 13, 3, 3);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(271, 27);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(262, 171);
            label4.Name = "label4";
            label4.Size = new Size(271, 20);
            label4.TabIndex = 7;
            label4.Text = "Por favor ingrese los datos de su tarjeta";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(36, 82, 71);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 236);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 42);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 1);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(78, 6);
            label8.Margin = new Padding(3);
            label8.Name = "label8";
            label8.Size = new Size(104, 25);
            label8.TabIndex = 1;
            label8.Text = "N° Tarjeta";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(36, 82, 71);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label9);
            panel2.Cursor = Cursors.Hand;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 284);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 41);
            panel2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 1);
            label3.Name = "label3";
            label3.Size = new Size(0, 30);
            label3.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(24, 8);
            label9.Margin = new Padding(3);
            label9.Name = "label9";
            label9.Size = new Size(212, 25);
            label9.TabIndex = 1;
            label9.Text = "Codigo de Seguridad";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = Color.FromArgb(56, 115, 100);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(panelAceptarPago);
            panel3.Cursor = Cursors.Hand;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(262, 372);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 41);
            panel3.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(36, 82, 71);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label13);
            panel5.Cursor = Cursors.Hand;
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(156, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(113, 39);
            panel5.TabIndex = 11;
            panel5.Click += cancelarBoton_click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 5);
            label5.Name = "label5";
            label5.Size = new Size(93, 27);
            label5.TabIndex = 1;
            label5.Text = "Cancelar";
            label5.Click += cancelarBoton_click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(50, 1);
            label13.Name = "label13";
            label13.Size = new Size(0, 30);
            label13.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(50, 1);
            label10.Name = "label10";
            label10.Size = new Size(0, 30);
            label10.TabIndex = 0;
            // 
            // panelAceptarPago
            // 
            panelAceptarPago.BackColor = Color.FromArgb(36, 82, 71);
            panelAceptarPago.BorderStyle = BorderStyle.FixedSingle;
            panelAceptarPago.Controls.Add(labelAceptarPago);
            panelAceptarPago.Controls.Add(label6);
            panelAceptarPago.Cursor = Cursors.Hand;
            panelAceptarPago.Dock = DockStyle.Left;
            panelAceptarPago.Location = new Point(0, 0);
            panelAceptarPago.Name = "panelAceptarPago";
            panelAceptarPago.Size = new Size(113, 39);
            panelAceptarPago.TabIndex = 10;
            panelAceptarPago.Click += aceptar_button_Click;
            // 
            // labelAceptarPago
            // 
            labelAceptarPago.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAceptarPago.AutoSize = true;
            labelAceptarPago.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAceptarPago.ForeColor = SystemColors.ControlLightLight;
            labelAceptarPago.Location = new Point(12, 5);
            labelAceptarPago.Name = "labelAceptarPago";
            labelAceptarPago.Size = new Size(86, 27);
            labelAceptarPago.TabIndex = 1;
            labelAceptarPago.Text = "Aceptar";
            labelAceptarPago.Click += aceptar_button_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(50, 1);
            label6.Name = "label6";
            label6.Size = new Size(0, 30);
            label6.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.BackColor = Color.FromArgb(36, 82, 71);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Cursor = Cursors.Hand;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 194);
            panel4.Name = "panel4";
            panel4.Size = new Size(253, 36);
            panel4.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(50, 1);
            label11.Name = "label11";
            label11.Size = new Size(0, 30);
            label11.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(50, 3);
            label12.Margin = new Padding(3);
            label12.Name = "label12";
            label12.Size = new Size(157, 25);
            label12.TabIndex = 1;
            label12.Text = "Medio de pago";
            label12.Click += label12_Click;
            // 
            // PagoForm_Nombre
            // 
            PagoForm_Nombre.AutoSize = true;
            PagoForm_Nombre.BackColor = Color.FromArgb(36, 82, 71);
            PagoForm_Nombre.BorderStyle = BorderStyle.FixedSingle;
            PagoForm_Nombre.Controls.Add(label7);
            PagoForm_Nombre.Controls.Add(label1);
            PagoForm_Nombre.Cursor = Cursors.Hand;
            PagoForm_Nombre.Dock = DockStyle.Fill;
            PagoForm_Nombre.Location = new Point(3, 331);
            PagoForm_Nombre.Name = "PagoForm_Nombre";
            PagoForm_Nombre.Size = new Size(253, 35);
            PagoForm_Nombre.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(50, 1);
            label7.Name = "label7";
            label7.Size = new Size(0, 30);
            label7.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(78, 3);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // tarjeta_combox
            // 
            tarjeta_combox.Dock = DockStyle.Fill;
            tarjeta_combox.DropDownStyle = ComboBoxStyle.DropDownList;
            tarjeta_combox.FormattingEnabled = true;
            tarjeta_combox.Items.AddRange(new object[] { "Crédito", "Débito" });
            tarjeta_combox.Location = new Point(262, 194);
            tarjeta_combox.Name = "tarjeta_combox";
            tarjeta_combox.Size = new Size(271, 28);
            tarjeta_combox.TabIndex = 15;
            tarjeta_combox.SelectedIndexChanged += tarjeta_combox_SelectedIndexChanged;
            // 
            // cuotas_combobox
            // 
            cuotas_combobox.Dock = DockStyle.Fill;
            cuotas_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            cuotas_combobox.FormattingEnabled = true;
            cuotas_combobox.Items.AddRange(new object[] { "Un pago", "3 Cuotas sin interés " });
            cuotas_combobox.Location = new Point(539, 194);
            cuotas_combobox.Name = "cuotas_combobox";
            cuotas_combobox.Size = new Size(258, 28);
            cuotas_combobox.TabIndex = 16;
            cuotas_combobox.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(264, 341);
            textBox1.Margin = new Padding(5, 13, 3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 27);
            textBox1.TabIndex = 4;
            // 
            // PagoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 115, 100);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "PagoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PagoForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelAceptarPago.ResumeLayout(false);
            panelAceptarPago.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            PagoForm_Nombre.ResumeLayout(false);
            PagoForm_Nombre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private Panel PagoForm_Nombre;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox3;
        private Panel panel1;
        private Label label2;
        private Label label8;
        private Panel panel2;
        private Label label3;
        private Label label9;
        private Panel panel3;
        private Label label10;
        private Panel panelAceptarPago;
        private Panel panel5;
        private Label label5;
        private Label label13;
        private Label labelAceptarPago;
        private Label label6;
        private ComboBox tarjeta_combox;
        private ComboBox cuotas_combobox;
        private Panel panel4;
        private Label label11;
        private Label label12;
    }
}