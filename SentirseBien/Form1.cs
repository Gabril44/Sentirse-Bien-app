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
            this.Size = new Size(1077, 712);
            InitializeComponent();
            this.usuario = usuario;
            turnos = new List<Turno>();
            turnoConsultas = new TurnoConsultas();
            if (usuario.rol != 1)
            {
                CargarTurnosCliente();
            }
            else 
            {
                if (usuario.correo == "test@gmail.com")
                {
                    cargarTurnos();
                }
                else 
                {
                    CargarTurnosDoctor();
                }
            }
            centerDataGrid();
            
            getRol(usuario);
        }

        private void getRol(Usuario usuario) 
        {
            if (usuario.correo == "test@gmail.com") 
            {
                cancelar_turno_button.Visible = true;
            }
        }

        private void CargarTurnosCliente(string filtro ="") 
        {
            try
            {
                // Mostrar el cursor de espera
                Cursor.Current = Cursors.WaitCursor;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                turnos.Clear();
                turnos = turnoConsultas.getTurno(filtro);

                for (int i = 0; i < turnos.Count; i++)
                {
                    if (turnos[i].nombre_usuario == usuario.nombre)
                    {
                        dataGridView1.RowTemplate.Height = 50;
                        dataGridView1.Rows.Add(
                            turnos[i].idturnos,
                            turnos[i].nombre_usuario,
                            turnos[i].fecha,
                            turnos[i].servicio,
                            turnos[i].profesional
                            );
                    }
                }
            }
            finally
            {
                // Asegurarse de restaurar el cursor normal
                Cursor.Current = Cursors.Default;
            }
        }

        private void centerDataGrid()
        {
            dataGridView1.Left = (this.ClientSize.Width - dataGridView1.Width) / 2;
            dataGridView1.Top = (this.ClientSize.Height - dataGridView1.Height) / 2;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            centerDataGrid();
        }
        private void CargarTurnosDoctor(string filtro = "") 
        {
            try
            {
                // Mostrar el cursor de espera
                Cursor.Current = Cursors.WaitCursor;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                turnos.Clear();
                turnos = turnoConsultas.getTurno(filtro);

                for (int i = 0; i < turnos.Count; i++)
                {
                    if (turnos[i].profesional == usuario.nombre)
                    {
                        dataGridView1.RowTemplate.Height = 50;
                        dataGridView1.Rows.Add(
                            turnos[i].idturnos,
                            turnos[i].nombre_usuario,
                            turnos[i].fecha,
                            turnos[i].servicio,
                            turnos[i].profesional
                            );
                    }
                }
            }
            finally
            {
                // Asegurarse de restaurar el cursor normal
                Cursor.Current = Cursors.Default;
            }
        }

        private void cargarTurnos(string filtro = "")
        {
            try
            {
                // Mostrar el cursor de espera
                Cursor.Current = Cursors.WaitCursor;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                turnos.Clear();
                turnos = turnoConsultas.getTurno(filtro);

                for (int i = 0; i < turnos.Count; i++)
                {
                    dataGridView1.RowTemplate.Height = 50;
                    dataGridView1.Rows.Add(
                        turnos[i].idturnos,
                        turnos[i].nombre_usuario,
                        turnos[i].fecha,
                        turnos[i].servicio,
                        turnos[i].profesional
                        );
                }
            } 
            finally 
            {
                // Asegurarse de restaurar el cursor normal
                Cursor.Current = Cursors.Default;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pedir_turno_cliente_Click(object sender, EventArgs e)
        {
            //this.Opacity = 0.7;
            pedirTurno pedirTurno = new pedirTurno(usuario);
            pedirTurno.ShowDialog();
            //this.Opacity = 1.0;
            cargarTurnos();
        }
    }
}
