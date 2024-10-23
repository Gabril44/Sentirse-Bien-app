using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentirseBien
{
    public partial class TextoForm : Form
    {
        public string texto { get; set; }
        public TextoForm()
        {
            InitializeComponent();
        }

        private void aceptar_button_Click(object sender, EventArgs e)
        {
            texto = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
