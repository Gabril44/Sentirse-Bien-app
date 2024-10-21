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
    public partial class SeleccionAPagar : Form
    {
        private Usuario usuario;
        private ConexionMysql conexionMysql;
        public SeleccionAPagar(Usuario usuario)
        {
            this.usuario = usuario;
            conexionMysql = new ConexionMysql();
            InitializeComponent();
        }

        private void RellenarCheckBox() 
        {
            checkedListBox1.Items.Clear();
            string QUERY = "SELECT nombre,numServicio  FROM pagos";
        }
    }
}
