namespace SentirseBien
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            user_textbox = new TextBox();
            pass_textbox = new TextBox();
            aceptar_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 232);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido/a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 25);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Sentirse Bien";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(287, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // user_textbox
            // 
            user_textbox.Location = new Point(287, 297);
            user_textbox.Name = "user_textbox";
            user_textbox.Size = new Size(170, 27);
            user_textbox.TabIndex = 3;
            user_textbox.Text = "Nombre de usuario";
            user_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // pass_textbox
            // 
            pass_textbox.Location = new Point(287, 368);
            pass_textbox.Name = "pass_textbox";
            pass_textbox.PasswordChar = '*';
            pass_textbox.Size = new Size(170, 27);
            pass_textbox.TabIndex = 4;
            pass_textbox.Text = "Contraseña";
            pass_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // aceptar_button
            // 
            aceptar_button.ForeColor = Color.Black;
            aceptar_button.Location = new Point(287, 418);
            aceptar_button.Name = "aceptar_button";
            aceptar_button.Size = new Size(170, 35);
            aceptar_button.TabIndex = 5;
            aceptar_button.Text = "Aceptar";
            aceptar_button.UseVisualStyleBackColor = true;
            aceptar_button.Click += aceptar_button_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 137, 121);
            ClientSize = new Size(765, 465);
            Controls.Add(aceptar_button);
            Controls.Add(pass_textbox);
            Controls.Add(user_textbox);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(232, 235, 233);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox user_textbox;
        private TextBox pass_textbox;
        private Button aceptar_button;
    }
}