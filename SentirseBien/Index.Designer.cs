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
            menuStrip1 = new MenuStrip();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            turnosToolStripMenuItem = new ToolStripMenuItem();
            pagosToolStripMenuItem = new ToolStripMenuItem();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            colePalmerToolStripMenuItem = new ToolStripMenuItem();
            comeCarneeToolStripMenuItem = new ToolStripMenuItem();
            bueeeeToolStripMenuItem = new ToolStripMenuItem();
            welcome_label = new Label();
            label1 = new Label();
            rol_label = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, turnosToolStripMenuItem, pagosToolStripMenuItem, perfilToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(81, 450);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(68, 24);
            clienteToolStripMenuItem.Text = "Clientes";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // turnosToolStripMenuItem
            // 
            turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            turnosToolStripMenuItem.Size = new Size(68, 24);
            turnosToolStripMenuItem.Text = "Turnos";
            turnosToolStripMenuItem.Click += turnosToolStripMenuItem_Click;
            // 
            // pagosToolStripMenuItem
            // 
            pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            pagosToolStripMenuItem.Size = new Size(68, 24);
            pagosToolStripMenuItem.Text = "Pagos";
            // 
            // perfilToolStripMenuItem
            // 
            perfilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesiónToolStripMenuItem, editarToolStripMenuItem, colePalmerToolStripMenuItem });
            perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            perfilToolStripMenuItem.Size = new Size(68, 24);
            perfilToolStripMenuItem.Text = "Perfil";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(177, 26);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(177, 26);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // colePalmerToolStripMenuItem
            // 
            colePalmerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { comeCarneeToolStripMenuItem });
            colePalmerToolStripMenuItem.Name = "colePalmerToolStripMenuItem";
            colePalmerToolStripMenuItem.Size = new Size(177, 26);
            colePalmerToolStripMenuItem.Text = "Cole Palmer";
            // 
            // comeCarneeToolStripMenuItem
            // 
            comeCarneeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bueeeeToolStripMenuItem });
            comeCarneeToolStripMenuItem.Name = "comeCarneeToolStripMenuItem";
            comeCarneeToolStripMenuItem.Size = new Size(177, 26);
            comeCarneeToolStripMenuItem.Text = "come carnee";
            // 
            // bueeeeToolStripMenuItem
            // 
            bueeeeToolStripMenuItem.Name = "bueeeeToolStripMenuItem";
            bueeeeToolStripMenuItem.Size = new Size(141, 26);
            bueeeeToolStripMenuItem.Text = "bueeee";
            // 
            // welcome_label
            // 
            welcome_label.AutoSize = true;
            welcome_label.Location = new Point(870, 0);
            welcome_label.Name = "welcome_label";
            welcome_label.Size = new Size(50, 20);
            welcome_label.TabIndex = 1;
            welcome_label.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(830, 50);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 2;
            label1.Text = "Rol:";
            // 
            // rol_label
            // 
            rol_label.AutoSize = true;
            rol_label.Location = new Point(870, 50);
            rol_label.Name = "rol_label";
            rol_label.Size = new Size(50, 20);
            rol_label.TabIndex = 3;
            rol_label.Text = "label2";
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 137, 121);
            ClientSize = new Size(931, 450);
            Controls.Add(rol_label);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(welcome_label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Index";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem turnosToolStripMenuItem;
        private ToolStripMenuItem pagosToolStripMenuItem;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem colePalmerToolStripMenuItem;
        private Label bienvenido_label;
        private Label welcome_label;
        private Label label1;
        private Label rol_label;
        private ToolStripMenuItem comeCarneeToolStripMenuItem;
        private ToolStripMenuItem bueeeeToolStripMenuItem;
    }
}