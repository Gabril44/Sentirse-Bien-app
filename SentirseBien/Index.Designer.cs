﻿namespace SentirseBien
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
            panel_pagar = new Panel();
            label_turnosapagar = new Label();
            label_pagar = new Label();
            panelServicios = new Panel();
            label_servicios = new Label();
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
            panelContenedor = new Panel();
            PanelMenu.SuspendLayout();
            panel_pagar.SuspendLayout();
            panelServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panelPerfil.SuspendLayout();
            panelPagos.SuspendLayout();
            panel2.SuspendLayout();
            PanelButtomClientes.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(36, 82, 71);
            PanelMenu.Controls.Add(panel_pagar);
            PanelMenu.Controls.Add(panelServicios);
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(panel5);
            PanelMenu.Controls.Add(panelPerfil);
            PanelMenu.Controls.Add(panelPagos);
            PanelMenu.Controls.Add(panel2);
            PanelMenu.Controls.Add(PanelButtomClientes);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(170, 712);
            PanelMenu.TabIndex = 4;
            PanelMenu.Click += index_Click;
            // 
            // panel_pagar
            // 
            panel_pagar.BorderStyle = BorderStyle.FixedSingle;
            panel_pagar.Controls.Add(label_turnosapagar);
            panel_pagar.Controls.Add(label_pagar);
            panel_pagar.Cursor = Cursors.Hand;
            panel_pagar.Location = new Point(3, 343);
            panel_pagar.Name = "panel_pagar";
            panel_pagar.Size = new Size(164, 59);
            panel_pagar.TabIndex = 10;
            panel_pagar.MouseClick += ClickPagar;
            // 
            // label_turnosapagar
            // 
            label_turnosapagar.AutoSize = true;
            label_turnosapagar.Font = new Font("Microsoft YaHei UI Light", 13.8F);
            label_turnosapagar.ForeColor = Color.Red;
            label_turnosapagar.Location = new Point(103, 7);
            label_turnosapagar.Name = "label_turnosapagar";
            label_turnosapagar.Size = new Size(23, 30);
            label_turnosapagar.TabIndex = 1;
            label_turnosapagar.Text = "*";
            label_turnosapagar.Visible = false;
            label_turnosapagar.MouseClick += ClickPagar;
            // 
            // label_pagar
            // 
            label_pagar.AutoSize = true;
            label_pagar.Font = new Font("Microsoft YaHei UI Light", 13.8F);
            label_pagar.ForeColor = SystemColors.ControlLightLight;
            label_pagar.Location = new Point(39, 13);
            label_pagar.Name = "label_pagar";
            label_pagar.Size = new Size(73, 30);
            label_pagar.TabIndex = 0;
            label_pagar.Text = "Pagar";
            label_pagar.MouseClick += ClickPagar;
            // 
            // panelServicios
            // 
            panelServicios.BorderStyle = BorderStyle.FixedSingle;
            panelServicios.Controls.Add(label_servicios);
            panelServicios.Cursor = Cursors.Hand;
            panelServicios.Location = new Point(3, 279);
            panelServicios.Name = "panelServicios";
            panelServicios.Size = new Size(164, 60);
            panelServicios.TabIndex = 9;
            panelServicios.Paint += panelServicios_Paint;
            panelServicios.MouseClick += serviciosClick;
            // 
            // label_servicios
            // 
            label_servicios.AutoSize = true;
            label_servicios.Font = new Font("Microsoft YaHei UI Light", 13.8F);
            label_servicios.ForeColor = SystemColors.ControlLightLight;
            label_servicios.Location = new Point(31, 12);
            label_servicios.Name = "label_servicios";
            label_servicios.Size = new Size(102, 30);
            label_servicios.TabIndex = 0;
            label_servicios.Text = "Servicios";
            label_servicios.MouseClick += serviciosClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 78);
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
            panel5.Location = new Point(0, 649);
            panel5.Margin = new Padding(1, 1, 1, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(170, 63);
            panel5.TabIndex = 7;
            panel5.MouseClick += panelCerrar_Click;
            // 
            // labelcerrar
            // 
            labelcerrar.AutoSize = true;
            labelcerrar.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcerrar.ForeColor = SystemColors.ControlLightLight;
            labelcerrar.Location = new Point(45, 11);
            labelcerrar.Margin = new Padding(1, 1, 1, 20);
            labelcerrar.Name = "labelcerrar";
            labelcerrar.Size = new Size(77, 30);
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
            panelPerfil.Location = new Point(0, 406);
            panelPerfil.Name = "panelPerfil";
            panelPerfil.Size = new Size(170, 56);
            panelPerfil.TabIndex = 6;
            panelPerfil.ContextMenuStripChanged += cerrarSesiónToolStripMenuItem_Click;
            panelPerfil.MouseClick += cerrarSesiónToolStripMenuItem_Click;
            // 
            // labelPerfil
            // 
            labelPerfil.AutoSize = true;
            labelPerfil.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPerfil.ForeColor = SystemColors.ControlLightLight;
            labelPerfil.Location = new Point(11, 12);
            labelPerfil.Name = "labelPerfil";
            labelPerfil.Size = new Size(151, 30);
            labelPerfil.TabIndex = 0;
            labelPerfil.Text = "Cerrar Sesión";
            labelPerfil.MouseClick += cerrarSesiónToolStripMenuItem_Click;
            // 
            // panelPagos
            // 
            panelPagos.AutoSize = true;
            panelPagos.BorderStyle = BorderStyle.FixedSingle;
            panelPagos.Controls.Add(label5);
            panelPagos.Cursor = Cursors.Hand;
            panelPagos.Location = new Point(0, 220);
            panelPagos.Name = "panelPagos";
            panelPagos.Size = new Size(170, 55);
            panelPagos.TabIndex = 5;
            panelPagos.MouseClick += Pagos_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(42, 10);
            label5.Name = "label5";
            label5.Size = new Size(77, 30);
            label5.TabIndex = 0;
            label5.Text = "Pagos";
            label5.MouseClick += Pagos_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(0, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 56);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint_1;
            panel2.MouseClick += turnosToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(40, 11);
            label3.Name = "label3";
            label3.Size = new Size(84, 30);
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
            PanelButtomClientes.Location = new Point(0, 102);
            PanelButtomClientes.Name = "PanelButtomClientes";
            PanelButtomClientes.Size = new Size(174, 57);
            PanelButtomClientes.TabIndex = 0;
            PanelButtomClientes.Paint += panel2_Paint;
            PanelButtomClientes.MouseClick += clienteToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(34, 12);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 0;
            label2.Text = "Clientes";
            label2.Click += label2_Click;
            label2.MouseClick += clienteToolStripMenuItem_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(56, 115, 100);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(170, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1088, 712);
            panelContenedor.TabIndex = 10;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 137, 121);
            ClientSize = new Size(1258, 712);
            Controls.Add(panelContenedor);
            Controls.Add(PanelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Index";
            WindowState = FormWindowState.Maximized;
            FormClosing += Index_Closing;
            Load += Index_Load;
            MouseClick += index_Click;
            PanelMenu.ResumeLayout(false);
            PanelMenu.PerformLayout();
            panel_pagar.ResumeLayout(false);
            panel_pagar.PerformLayout();
            panelServicios.ResumeLayout(false);
            panelServicios.PerformLayout();
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
            ResumeLayout(false);
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
        private Panel panelContenedor;
        private Panel panelServicios;
        private Label label_servicios;
        private Panel panel_pagar;
        private Label label_pagar;
        private Label label_turnosapagar;
    }
}