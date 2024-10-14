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
            carrousel_pb = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carrousel_pb).BeginInit();
            SuspendLayout();
            // 
            // bienvenido_label
            // 
            bienvenido_label.AutoSize = true;
            bienvenido_label.Font = new Font("Segoe UI", 25F);
            bienvenido_label.ForeColor = Color.FromArgb(29, 56, 49);
            bienvenido_label.Location = new Point(3, 0);
            bienvenido_label.Name = "bienvenido_label";
            bienvenido_label.Size = new Size(147, 94);
            bienvenido_label.TabIndex = 0;
            bienvenido_label.Text = "Bienvenido";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.615202F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.3847961F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 276F));
            tableLayoutPanel1.Controls.Add(bienvenido_label, 0, 0);
            tableLayoutPanel1.Controls.Add(carrousel_pb, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.7251F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.2749F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Size = new Size(1085, 582);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // carrousel_pb
            // 
            carrousel_pb.BorderStyle = BorderStyle.FixedSingle;
            carrousel_pb.Dock = DockStyle.Fill;
            carrousel_pb.Image = Properties.Resources.Day_Spa_Facials_SkinCare_Header_1920x1080;
            carrousel_pb.Location = new Point(177, 97);
            carrousel_pb.Name = "carrousel_pb";
            carrousel_pb.Size = new Size(628, 402);
            carrousel_pb.SizeMode = PictureBoxSizeMode.Zoom;
            carrousel_pb.TabIndex = 1;
            carrousel_pb.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)carrousel_pb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label bienvenido_label;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox carrousel_pb;
    }
}