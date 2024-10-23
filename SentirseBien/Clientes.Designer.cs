namespace SentirseBien
{
    partial class Clientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            idusuario = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            user = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            filtro_nombre = new Button();
            filtro_correo = new Button();
            filtro_id = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 36F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(448, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 48);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 59, 52);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idusuario, nombre, correo, user });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Snow;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(104, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(884, 459);
            dataGridView1.TabIndex = 1;
            // 
            // idusuario
            // 
            idusuario.HeaderText = "idCliente";
            idusuario.MinimumWidth = 6;
            idusuario.Name = "idusuario";
            // 
            // nombre
            // 
            nombre.HeaderText = "nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            // 
            // correo
            // 
            correo.HeaderText = "correo";
            correo.MinimumWidth = 6;
            correo.Name = "correo";
            // 
            // user
            // 
            user.HeaderText = "user";
            user.MinimumWidth = 6;
            user.Name = "user";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(56, 115, 100);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.2105265F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.7894745F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(filtro_nombre, 1, 2);
            tableLayoutPanel1.Controls.Add(filtro_correo, 1, 3);
            tableLayoutPanel1.Controls.Add(filtro_id, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.430894F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.56911F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.Size = new Size(1077, 656);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // filtro_nombre
            // 
            filtro_nombre.Location = new Point(104, 516);
            filtro_nombre.Name = "filtro_nombre";
            filtro_nombre.Size = new Size(166, 29);
            filtro_nombre.TabIndex = 2;
            filtro_nombre.Text = "Filtrar por Nombre";
            filtro_nombre.UseVisualStyleBackColor = true;
            filtro_nombre.Click += FiltroNombreClick;
            // 
            // filtro_correo
            // 
            filtro_correo.Location = new Point(104, 566);
            filtro_correo.Name = "filtro_correo";
            filtro_correo.Size = new Size(166, 29);
            filtro_correo.TabIndex = 3;
            filtro_correo.Text = "Filtrar por correo";
            filtro_correo.UseVisualStyleBackColor = true;
            filtro_correo.Click += filtro_correo_Click;
            // 
            // filtro_id
            // 
            filtro_id.Location = new Point(104, 616);
            filtro_id.Name = "filtro_id";
            filtro_id.Size = new Size(166, 29);
            filtro_id.TabIndex = 4;
            filtro_id.Text = "Filtrar por Id";
            filtro_id.UseVisualStyleBackColor = true;
            filtro_id.Click += filtro_id_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 137, 121);
            ClientSize = new Size(1077, 656);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn idusuario;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn user;
        private Button filtro_nombre;
        private Button filtro_correo;
        private Button filtro_id;
    }
}