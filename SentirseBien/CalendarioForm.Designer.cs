namespace SentirseBien
{
    partial class CalendarioForm
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
            monthCalendar1 = new MonthCalendar();
            aceptar_button = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(4, 4);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // aceptar_button
            // 
            aceptar_button.Location = new Point(4, 223);
            aceptar_button.Name = "aceptar_button";
            aceptar_button.Size = new Size(220, 35);
            aceptar_button.TabIndex = 1;
            aceptar_button.Text = "Seleccionar";
            aceptar_button.UseVisualStyleBackColor = true;
            aceptar_button.Click += aceptar_button_Click;
            // 
            // CalendarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 115, 100);
            ClientSize = new Size(229, 270);
            Controls.Add(aceptar_button);
            Controls.Add(monthCalendar1);
            Name = "CalendarioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalendarioForm";
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button aceptar_button;
    }
}