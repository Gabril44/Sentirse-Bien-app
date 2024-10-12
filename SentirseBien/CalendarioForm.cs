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
    public partial class CalendarioForm : Form
    {
        public string fecha {  get; set; }
        public CalendarioForm()
        {
            InitializeComponent();
        }

        private void aceptar_button_Click(object sender, EventArgs e)
        {
            fecha =  ""+ monthCalendar1.SelectionStart;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
