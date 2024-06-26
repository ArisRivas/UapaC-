using Microsoft.Maui.Controls;
using System;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace uniuapaII
{
    public partial class RegisterRacePage : ContentPage
    {
        public RegisterRacePage()
        {
            InitializeComponent();
        }

        private async void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            string raceName = RaceNameEntry.Text;
            int trimesterCount;
            int duration;
            string school = SchoolEntry.Text;

            if (string.IsNullOrEmpty(raceName) || string.IsNullOrEmpty(TrimesterCountEntry.Text) || string.IsNullOrEmpty(DurationEntry.Text) || string.IsNullOrEmpty(school))
            {
                await DisplayAlert("Error", "Todos los campos son obligatorios", "OK");
                return;
            }

            if (!int.TryParse(TrimesterCountEntry.Text, out trimesterCount) || !int.TryParse(DurationEntry.Text, out duration))
            {
                await DisplayAlert("Error", "La cantidad de trimestres y la duración deben ser números válidos", "OK");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    await conn.OpenAsync();
                    string query = "INSERT INTO carrerasuapa (Nombre, Trimestres, Duracion, Escuela) VALUES (@Nombre, @Trimestres, @Duracion, @Escuela)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", raceName);
                        cmd.Parameters.AddWithValue("@Trimestres", trimesterCount);
                        cmd.Parameters.AddWithValue("@Duracion", duration);
                        cmd.Parameters.AddWithValue("@Escuela", school);
                        await cmd.ExecuteNonQueryAsync();
                    }
                }

                await DisplayAlert("Éxito", "La carrera ha sido registrada exitosamente", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Ha ocurrido un error: {ex.Message}", "OK");
            }
        }
    }
}
