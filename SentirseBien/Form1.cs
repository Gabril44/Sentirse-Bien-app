using System.Diagnostics.Eventing.Reader;

namespace SentirseBien
{
    public partial class Form1 : Form
    {
        private Usuario usuario;
        private List<Turno> turnos;
        private TurnoConsultas turnoConsultas;
        public Form1(Usuario usuario)
        {
            InitializeComponent();
            turnos = new List<Turno>();
            turnoConsultas = new TurnoConsultas();
            cargarTurnos();
            centerDataGrid();
            this.usuario = usuario;
        }

        private void centerDataGrid() 
        {
            dataGridView1.Left = (this.ClientSize.Width - dataGridView1.Width)/2;
            dataGridView1.Top = (this.ClientSize.Height - dataGridView1.Height) / 2;
        }

        private void Form1_Resize(object sender, EventArgs e) 
        {
            centerDataGrid();  
        }

        private void cargarTurnos(string filtro = "")
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            turnos.Clear();
            turnos = turnoConsultas.getTurno(filtro);

            for(int i = 0; i < turnos.Count; i++) 
            {
                dataGridView1.RowTemplate.Height = 50;
                dataGridView1.Rows.Add(
                    turnos[i].idturnos,
                    turnos[i].nombre_usuario,
                    turnos[i].fecha,
                    turnos[i].servicio,
                    turnos[i].profesional
                    ) ;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index index = new Index(usuario);
            index.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
