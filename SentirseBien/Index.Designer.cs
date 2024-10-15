namespace SentirseBien
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            PanelMenu = new Panel();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            labelcerrar = new Label();
            panelPerfil = new Panel();
            labelPerfil = new Label();
            panelPagos = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            PanelButtomClientes = new Panel();
            label2 = new Label();
            panelPerfilEditar = new Panel();
            labelPerfilEditar = new Label();
            label6 = new Label();
            panelPerfilCerrar = new Panel();
            labelPerfilCerrar = new Label();
            panelMenuPerfil = new Panel();
            panelContenedor = new Panel();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panelPerfil.SuspendLayout();
            panelPagos.SuspendLayout();
            panel2.SuspendLayout();
            PanelButtomClientes.SuspendLayout();
            panelPerfilEditar.SuspendLayout();
            panelPerfilCerrar.SuspendLayout();
            panelMenuPerfil.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(36, 82, 71);
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(panel5);
            PanelMenu.Controls.Add(panelPerfil);
            PanelMenu.Controls.Add(panelPagos);
            PanelMenu.Controls.Add(panel2);
            PanelMenu.Controls.Add(PanelButtomClientes);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Margin = new Padding(4);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(255, 1068);
            PanelMenu.TabIndex = 4;
            PanelMenu.Click += index_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(36, 18);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(labelcerrar);
            panel5.Cursor = Cursors.Hand;
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 977);
            panel5.Margin = new Padding(2, 2, 2, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(255, 91);
            panel5.TabIndex = 7;
            panel5.MouseClick += panelCerrar_Click;
            // 
            // labelcerrar
            // 
            labelcerrar.AutoSize = true;
            labelcerrar.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcerrar.Location = new Point(68, 16);
            labelcerrar.Margin = new Padding(2, 2, 2, 30);
            labelcerrar.Name = "labelcerrar";
            labelcerrar.Size = new Size(113, 43);
            labelcerrar.TabIndex = 0;
            labelcerrar.Text = "Cerrar";
            labelcerrar.MouseClick += panelCerrar_Click;
            // 
            // panelPerfil
            // 
            panelPerfil.AutoSize = true;
            panelPerfil.BorderStyle = BorderStyle.FixedSingle;
            panelPerfil.Controls.Add(labelPerfil);
            panelPerfil.Cursor = Cursors.Hand;
            panelPerfil.Location = new Point(2, 418);
            panelPerfil.Margin = new Padding(4);
            panelPerfil.Name = "panelPerfil";
            panelPerfil.Size = new Size(254, 83);
            panelPerfil.TabIndex = 6;
            panelPerfil.ContextMenuStripChanged += cerrarSesiónToolStripMenuItem_Click;
            panelPerfil.MouseClick += PanelPerfil_Click;
            // 
            // labelPerfil
            // 
            labelPerfil.AutoSize = true;
            labelPerfil.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPerfil.Location = new Point(69, 16);
            labelPerfil.Margin = new Padding(4, 0, 4, 0);
            labelPerfil.Name = "labelPerfil";
            labelPerfil.Size = new Size(92, 43);
            labelPerfil.TabIndex = 0;
            labelPerfil.Text = "Perfil";
            labelPerfil.MouseClick += PanelPerfil_Click;
            // 
            // panelPagos
            // 
            panelPagos.AutoSize = true;
            panelPagos.BorderStyle = BorderStyle.FixedSingle;
            panelPagos.Controls.Add(label5);
            panelPagos.Cursor = Cursors.Hand;
            panelPagos.Location = new Point(0, 330);
            panelPagos.Margin = new Padding(4);
            panelPagos.Name = "panelPagos";
            panelPagos.Size = new Size(254, 82);
            panelPagos.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(63, 15);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 43);
            label5.TabIndex = 0;
            label5.Text = "Pagos";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(0, 242);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 83);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint_1;
            panel2.MouseClick += turnosToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 16);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 43);
            label3.TabIndex = 0;
            label3.Text = "Turnos";
            label3.MouseClick += turnosToolStripMenuItem_Click;
            // 
            // PanelButtomClientes
            // 
            PanelButtomClientes.AutoSize = true;
            PanelButtomClientes.BorderStyle = BorderStyle.FixedSingle;
            PanelButtomClientes.Controls.Add(label2);
            PanelButtomClientes.Cursor = Cursors.Hand;
            PanelButtomClientes.Location = new Point(0, 153);
            PanelButtomClientes.Margin = new Padding(4);
            PanelButtomClientes.Name = "PanelButtomClientes";
            PanelButtomClientes.Size = new Size(260, 84);
            PanelButtomClientes.TabIndex = 0;
            PanelButtomClientes.Paint += panel2_Paint;
            PanelButtomClientes.MouseClick += clienteToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(51, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 43);
            label2.TabIndex = 0;
            label2.Text = "Clientes";
            label2.Click += label2_Click;
            label2.MouseClick += clienteToolStripMenuItem_Click;
            // 
            // panelPerfilEditar
            // 
            panelPerfilEditar.AutoSize = true;
            panelPerfilEditar.BackColor = Color.FromArgb(36, 82, 71);
            panelPerfilEditar.BorderStyle = BorderStyle.FixedSingle;
            panelPerfilEditar.Controls.Add(labelPerfilEditar);
            panelPerfilEditar.Controls.Add(label6);
            panelPerfilEditar.Cursor = Cursors.Hand;
            panelPerfilEditar.Location = new Point(7, 4);
            panelPerfilEditar.Margin = new Padding(4);
            panelPerfilEditar.Name = "panelPerfilEditar";
            panelPerfilEditar.Size = new Size(249, 52);
            panelPerfilEditar.TabIndex = 7;
            panelPerfilEditar.Paint += panel1_Paint;
            // 
            // labelPerfilEditar
            // 
            labelPerfilEditar.AutoSize = true;
            labelPerfilEditar.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPerfilEditar.Location = new Point(73, 4);
            labelPerfilEditar.Margin = new Padding(4, 0, 4, 0);
            labelPerfilEditar.Name = "labelPerfilEditar";
            labelPerfilEditar.Size = new Size(105, 43);
            labelPerfilEditar.TabIndex = 1;
            labelPerfilEditar.Text = "Editar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(75, 2);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 43);
            label6.TabIndex = 0;
            // 
            // panelPerfilCerrar
            // 
            panelPerfilCerrar.AutoSize = true;
            panelPerfilCerrar.BackColor = Color.FromArgb(36, 82, 71);
            panelPerfilCerrar.BorderStyle = BorderStyle.FixedSingle;
            panelPerfilCerrar.Controls.Add(labelPerfilCerrar);
            panelPerfilCerrar.Location = new Point(5, 64);
            panelPerfilCerrar.Margin = new Padding(4);
            panelPerfilCerrar.Name = "panelPerfilCerrar";
            panelPerfilCerrar.Size = new Size(254, 58);
            panelPerfilCerrar.TabIndex = 8;
            panelPerfilCerrar.MouseClick += cerrarSesiónToolStripMenuItem_Click;
            // 
            // labelPerfilCerrar
            // 
            labelPerfilCerrar.AutoSize = true;
            labelPerfilCerrar.Cursor = Cursors.Hand;
            labelPerfilCerrar.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPerfilCerrar.Location = new Point(10, 5);
            labelPerfilCerrar.Margin = new Padding(4, 0, 4, 0);
            labelPerfilCerrar.Name = "labelPerfilCerrar";
            labelPerfilCerrar.Size = new Size(231, 43);
            labelPerfilCerrar.TabIndex = 0;
            labelPerfilCerrar.Text = "Cerrrar Sesión";
            labelPerfilCerrar.MouseClick += cerrarSesiónToolStripMenuItem_Click;
            // 
            // panelMenuPerfil
            // 
            panelMenuPerfil.AutoSize = true;
            panelMenuPerfil.BackColor = Color.FromArgb(56, 115, 100);
            panelMenuPerfil.Controls.Add(panelPerfilEditar);
            panelMenuPerfil.Controls.Add(panelPerfilCerrar);
            panelMenuPerfil.Location = new Point(266, 404);
            panelMenuPerfil.Margin = new Padding(4);
            panelMenuPerfil.Name = "panelMenuPerfil";
            panelMenuPerfil.Size = new Size(267, 129);
            panelMenuPerfil.TabIndex = 9;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(56, 115, 100);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(255, 0);
            panelContenedor.Margin = new Padding(4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1632, 1068);
            panelContenedor.TabIndex = 10;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 137, 121);
            ClientSize = new Size(1887, 1068);
            Controls.Add(panelMenuPerfil);
            Controls.Add(panelContenedor);
            Controls.Add(PanelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Index";
            WindowState = FormWindowState.Maximized;
            Load += Index_Load;
            MouseClick += index_Click;
            PanelMenu.ResumeLayout(false);
            PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelPerfil.ResumeLayout(false);
            panelPerfil.PerformLayout();
            panelPagos.ResumeLayout(false);
            panelPagos.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            PanelButtomClientes.ResumeLayout(false);
            PanelButtomClientes.PerformLayout();
            panelPerfilEditar.ResumeLayout(false);
            panelPerfilEditar.PerformLayout();
            panelPerfilCerrar.ResumeLayout(false);
            panelPerfilCerrar.PerformLayout();
            panelMenuPerfil.ResumeLayout(false);
            panelMenuPerfil.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label bienvenido_label;
        private Panel PanelMenu;
        private Panel PanelButtomClientes;
        private Label label2;
        private Panel panelPerfil;
        private Label labelPerfil;
        private Panel panel2;
        private Label label3;
        private Panel panelPagos;
        private Label label5;
        private Panel panel5;
        private Label labelcerrar;
        private PictureBox pictureBox1;
        private Panel panelPerfilEditar;
        private Label label6;
        private Panel panelPerfilCerrar;
        private Label labelPerfilCerrar;
        private Label labelPerfilEditar;
        private Panel panelMenuPerfil;
        private Panel panelContenedor;
    }
}