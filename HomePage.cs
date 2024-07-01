using System.Data;
using System.Data.SqlClient;

namespace uniuapall
{
    public partial class HomePage : Form
    {
        public string nombreUsuario;
        public string matriculaUsuario;

        public HomePage()
        {
            InitializeComponent();
        }

        private async void Seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn = new(DatabaseConfig.ConnectionString);
                await conn.OpenAsync();

                string query = "SELECT nombrecarrera as Carrera, cantidadtrimestre as \" Cantidad de trimestre\", duracion as Duracion, escuela as Escuela FROM carrerasuapa;";
                using SqlDataAdapter dataAdapter = new(query, conn);

                SeleccionarCarreras seleccionarCarreras = new();
                DataTable dataTable = new();
                dataAdapter.Fill(dataTable);

                seleccionarCarreras.DataGridCarreras.DataSource = dataTable;
                seleccionarCarreras.nombre.Text = nombreUsuario;
                seleccionarCarreras.matricula.Text = matriculaUsuario;

                seleccionarCarreras.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private async void ImprimirSelecc_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn = new(DatabaseConfig.ConnectionString);
                await conn.OpenAsync();

                string query = "SELECT DISTINCT(asignatura) FROM seleccionparticipante sp where sp.nombre = @usuario;";
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@usuario", nombreUsuario);

                var data = cmd.ExecuteReader();

                if (data.HasRows)
                {
                    Imprimir frmImprimir = new();

                    while (data.Read())
                    {
                        frmImprimir.DataGridSeleccion.Rows.Add(data[0].ToString(), "Seleccionada");
                    }

                    frmImprimir.Estudiante.Text += nombreUsuario.ToString();
                    frmImprimir.Matricula.Text += matriculaUsuario.ToString();
                    frmImprimir.Show();
                }
                else
                {
                    MessageBox.Show("No hay selección para imprimir", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
