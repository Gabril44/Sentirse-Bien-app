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
        private Panel _panelMenuPerfil;
        private Usuario usuario;
        private List<Image> imagenes; // Lista de imágenes
        private int indiceActual = 0; // Índice de la imagen actual
        private System.Windows.Forms.Timer timer; // Temporizador para cambiar las imágenes automáticamente
        private String[] frases = new string[6];

        public BienvenidoForm(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            RellenarFrases();
            getBienvenida();
            IniciarCarrousel();
        }
        public BienvenidoForm(Usuario usuario, Panel panelMenuPerfil)
        {
            this.usuario = usuario;
            _panelMenuPerfil = panelMenuPerfil;
            InitializeComponent();
            RellenarFrases();
            getBienvenida();
            IniciarCarrousel();
        }

        private void RellenarFrases() 
        {
            frases[0] = "Salud y bienestar";
            frases[1] = "Facial Hidratante";
            frases[2] = "Hidroterapia";
            frases[3] = "Terapia y desconexión";
            frases[4] = "Revitalizar cuerpo y mente";
            frases[5] = "Mima tu piel con lo mejor";
        }

        private void BienvenidoForm_Click(object sender, MouseEventArgs e)
        {

            
        }

        private void IniciarCarrousel()
        {
            imagenes = new List<Image>()
        {
            Properties.Resources.imagen1,
            Properties.Resources.imagen2,
            Properties.Resources.pileta_interior_del_azur_real_hotel_boutique_entre_los_mejores_spa_del_mundo_1628212,
            Properties.Resources.Portadas,
            Properties.Resources.Couples_Escape,
            Properties.Resources.Day_Spa_Facials_SkinCare_Header_1920x1080,
            // Añade más imágenes según sea necesario
        };

            // Inicializar el PictureBox con la primera imagen
            carrousel_pb.Image = imagenes[indiceActual];
            carrousel_pb.SizeMode = PictureBoxSizeMode.StretchImage; // Ajustar el tamaño de la imagen
            pie_label.Text = frases[indiceActual];

            // Configurar el Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // Cambiar cada 2 segundos
            timer.Tick += new EventHandler(CambiarImagen);
            timer.Start(); // Iniciar el temporizador
        }

        private void CambiarImagen(object sender, EventArgs e)
        {
            // Cambiar al siguiente índice de la lista de imágenes
            indiceActual = (indiceActual + 1) % imagenes.Count;
            carrousel_pb.Image = imagenes[indiceActual];
            pie_label.Text = frases[indiceActual];

        }
        private void getBienvenida()
        {
            bienvenido_label.Text += " " + usuario.nombre;
        }

        private void BienvenidoForm_Click(object sender, EventArgs e)
        {
            if (_panelMenuPerfil.Visible)
            {
                _panelMenuPerfil.Visible = false;
            }

        }
    }
}
