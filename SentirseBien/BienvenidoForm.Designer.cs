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
            pie_label = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carrousel_pb).BeginInit();
            SuspendLayout();
            // 
            // bienvenido_label
            // 
            bienvenido_label.Anchor = AnchorStyles.None;
            bienvenido_label.AutoSize = true;
            bienvenido_label.Font = new Font("Vladimir Script", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bienvenido_label.ForeColor = Color.FromArgb(232, 235, 233);
            bienvenido_label.Location = new Point(329, 2);
            bienvenido_label.Name = "bienvenido_label";
            bienvenido_label.Size = new Size(321, 90);
            bienvenido_label.TabIndex = 0;
            bienvenido_label.Text = "Bienvenido";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.615202F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.3847961F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 278F));
            tableLayoutPanel1.Controls.Add(carrousel_pb, 1, 1);
            tableLayoutPanel1.Controls.Add(pie_label, 1, 2);
            tableLayoutPanel1.Controls.Add(bienvenido_label, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.7251F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.2749F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Size = new Size(1085, 582);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Click += BienvenidoForm_Click;
            // 
            // carrousel_pb
            // 
            carrousel_pb.BorderStyle = BorderStyle.FixedSingle;
            carrousel_pb.Dock = DockStyle.Fill;
            carrousel_pb.Image = Properties.Resources.Day_Spa_Facials_SkinCare_Header_1920x1080;
            carrousel_pb.Location = new Point(177, 97);
            carrousel_pb.Name = "carrousel_pb";
            carrousel_pb.Size = new Size(626, 402);
            carrousel_pb.SizeMode = PictureBoxSizeMode.Zoom;
            carrousel_pb.TabIndex = 1;
            carrousel_pb.TabStop = false;
            carrousel_pb.Click += BienvenidoForm_Click;
            // 
            // pie_label
            // 
            pie_label.Anchor = AnchorStyles.Top;
            pie_label.AutoSize = true;
            pie_label.Font = new Font("Segoe UI", 18F);
            pie_label.ForeColor = Color.FromArgb(232, 235, 233);
            pie_label.Location = new Point(449, 502);
            pie_label.Name = "pie_label";
            pie_label.Size = new Size(81, 41);
            pie_label.TabIndex = 2;
            pie_label.Text = "label";
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
            Click += BienvenidoForm_Click;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carrousel_pb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label bienvenido_label;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox carrousel_pb;
        private Label pie_label;
    }
}