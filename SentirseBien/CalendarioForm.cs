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
        public string fechalimite { get; set; }
        public CalendarioForm()
        {
            InitializeComponent();
        }

        private void aceptar_button_Click(object sender, EventArgs e)
        {
            DateTime fechaseleccionada = monthCalendar1.SelectionStart;
            fecha =  fechaseleccionada.ToString("dd/MM/yyyy");
            fechalimite = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
