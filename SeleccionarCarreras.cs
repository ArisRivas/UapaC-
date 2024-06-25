using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uniuapall
{
    public partial class SeleccionarCarreras : Form
    {
        public SeleccionarCarreras()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            var cells = DataGridCarreras.CurrentRow.Cells;

            DataGridCarrerasAgregadas.Rows.Add(cells[0].Value, cells[1].Value, cells[2].Value, cells[3].Value);
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (DataGridCarrerasAgregadas.Rows.Count > 1)
            {
                int index = DataGridCarrerasAgregadas.CurrentRow.Index;
                DataGridCarrerasAgregadas.Rows.RemoveAt(index);
            }

        }

        private async void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn = new(DatabaseConfig.ConnectionString);
                await conn.OpenAsync();
                string query = "INSERT INTO seleccionparticipante (nombre, matricula, asignatura) VALUES (@nombre, @matricula, @asignatura)";

                using SqlCommand cmd = new(query, conn);

                SqlParameter nombreParam = cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100);
                SqlParameter matriculaParam = cmd.Parameters.Add("@matricula", SqlDbType.VarChar, 100);
                SqlParameter asignaturaParam = cmd.Parameters.Add("@asignatura", SqlDbType.VarChar, 100);



                for (int i = 0; i < DataGridCarrerasAgregadas.RowCount; i++)
                {
                    string asignatura = DataGridCarrerasAgregadas.Rows[i].Cells[0].Value.ToString();

                    cmd.Parameters[nombreParam.ParameterName].Value = nombre.Text.ToString();
                    cmd.Parameters[matriculaParam.ParameterName].Value = matricula.Text.ToString();
                    cmd.Parameters[asignaturaParam.ParameterName].Value = asignatura;

                    await cmd.ExecuteNonQueryAsync();
                }

                this.Close();
                MessageBox.Show("Se guardaron los cambios", "Exito", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }
    }
}