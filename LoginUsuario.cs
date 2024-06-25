using Microsoft.Win32;
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
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace uniuapall
{
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }

        private async void Entrar_Click(object sender, EventArgs e)
        {
            string nombre = tbUsuario.Text;
            string clave = tbClave.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                using SqlConnection conn = new(DatabaseConfig.ConnectionString);
                await conn.OpenAsync();

                string query = "SELECT id, nombre, matricula, usuario FROM usuariosparticipantes WHERE usuario=@usuario AND contrasena=@contrasena;";
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@usuario", nombre);
                cmd.Parameters.AddWithValue("@contrasena", clave);
                var data = cmd.ExecuteReader();

                if (data.HasRows)
                {
                    this.Close();
                    HomePage frmHome = new();

                    while (data.Read())
                    {
                        frmHome.nombreUsuario = data[1].ToString();
                        frmHome.matriculaUsuario = data[2].ToString();
                    }

                    frmHome.Show();
                }
                else
                {
                    MessageBox.Show("USUARIO Y/O CONTRASEÑA INCORRECTO", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
