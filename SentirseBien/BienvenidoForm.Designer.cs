namespace SentirseBien
{
    partial class BienvenidoForm
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
            bienvenido_label = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // bienvenido_label
            // 
            bienvenido_label.AutoSize = true;
            bienvenido_label.Font = new Font("Segoe UI", 25F);
            bienvenido_label.ForeColor = Color.FromArgb(29, 56, 49);
            bienvenido_label.Location = new Point(3, 0);
            bienvenido_label.Name = "bienvenido_label";
            bienvenido_label.Size = new Size(232, 57);
            bienvenido_label.TabIndex = 0;
            bienvenido_label.Text = "bienvenido";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 296F));
            tableLayoutPanel1.Controls.Add(bienvenido_label, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 184F));
            tableLayoutPanel1.Size = new Size(1085, 582);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // BienvenidoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 137, 121);
            ClientSize = new Size(1085, 582);
            Controls.Add(tableLayoutPanel1);
            Name = "BienvenidoForm";
            Text = "BienvenidoForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label bienvenido_label;
        private TableLayoutPanel tableLayoutPanel1;
    }
}