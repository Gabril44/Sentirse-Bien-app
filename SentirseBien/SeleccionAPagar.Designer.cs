namespace SentirseBien
{
    partial class SeleccionAPagar
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
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            label_precio = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.7457886F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.25421F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            tableLayoutPanel1.Controls.Add(checkedListBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(label_precio, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6923084F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.30769F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.FromArgb(30, 59, 52);
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.Dock = DockStyle.Fill;
            checkedListBox1.Font = new Font("Segoe UI", 15F);
            checkedListBox1.ForeColor = SystemColors.ControlLightLight;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(143, 72);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(498, 279);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.ItemCheck += CheckedListBox1Changed;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(215, 17);
            label1.Name = "label1";
            label1.Size = new Size(353, 35);
            label1.TabIndex = 1;
            label1.Text = "Seleccione lo que desea pagar";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(567, 354);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 2;
            label2.Text = "Total: $";
            // 
            // label_precio
            // 
            label_precio.AutoSize = true;
            label_precio.Font = new Font("Segoe UI", 12F);
            label_precio.ForeColor = SystemColors.ControlLightLight;
            label_precio.Location = new Point(647, 354);
            label_precio.Name = "label_precio";
            label_precio.Size = new Size(34, 28);
            label_precio.TabIndex = 3;
            label_precio.Text = "00";
            // 
            // SeleccionAPagar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 115, 100);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "SeleccionAPagar";
            Text = "SeleccionAPagar";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CheckedListBox checkedListBox1;
        private Label label1;
        private Label label2;
        private Label label_precio;
    }
}