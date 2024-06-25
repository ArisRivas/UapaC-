using System.Data.SqlClient;

namespace uniuapall
{
    public partial class RegistrarCarrera : Form
    {
        public RegistrarCarrera()
        {
            InitializeComponent();
        }

        private async void Registrar_Click(object sender, EventArgs e)
        {
            string carrera = tbCarrera.Text;
            int trimestre;
            int duration;
            string escuela = tbEscuela.Text;

            if (string.IsNullOrEmpty(carrera) || string.IsNullOrEmpty(tbTrimestres.Text) || string.IsNullOrEmpty(tbDuracion.Text) || string.IsNullOrEmpty(escuela))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK);
                return;
            }

            if (!int.TryParse(tbTrimestres.Text, out trimestre) || !int.TryParse(tbDuracion.Text, out duration))
            {
                MessageBox.Show("La cantidad de trimestres y la duración deben ser números válidos", "Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    await conn.OpenAsync();
                    string query = "INSERT INTO carrerasuapa (nombrecarrera, cantidadtrimestre, duracion, escuela) VALUES (@nombrecarrera, @cantidadtrimestre, @duracion, @escuela)";
                    
                    ////using SqlCommand cmd = new SqlCommand(query, conn);
                    using SqlCommand cmd = new (query, conn);

                    cmd.Parameters.AddWithValue("@nombrecarrera", carrera);
                    cmd.Parameters.AddWithValue("@cantidadtrimestre", trimestre);
                    cmd.Parameters.AddWithValue("@duracion", duration);
                    cmd.Parameters.AddWithValue("@escuela", escuela);
                    await cmd.ExecuteNonQueryAsync();
                }

                MessageBox.Show("La carrera ha sido registrada exitosamente", "Éxito", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
