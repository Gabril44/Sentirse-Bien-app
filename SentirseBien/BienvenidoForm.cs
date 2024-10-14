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
    public partial class BienvenidoForm : Form
    {
        private Usuario usuario;
        public BienvenidoForm(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            getBienvenida();
        } 

        private void getBienvenida() 
        {
            bienvenido_label.Text += " " + usuario.nombre;
        }
    }
}
