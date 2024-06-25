using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
    }
}
