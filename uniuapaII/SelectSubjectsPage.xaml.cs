using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace uniuapaII
{
    public partial class SelectSubjectsPage : ContentPage
    {
        public ObservableCollection<Subject> AvailableSubjects { get; set; } = new ObservableCollection<Subject>();
        public ObservableCollection<Subject> SelectedSubjects { get; set; } = new ObservableCollection<Subject>();
        private string participantName;
        private string participantMatricula;

        public SelectSubjectsPage()
        {
            InitializeComponent();
            BindingContext = this;
            LoadUserData();
            LoadAvailableSubjects();
        }

        private void LoadUserData()
        {
            // Assume we have participantName and participantMatricula from previous login
            participantName = "Nombre del Usuario"; // Get from login
            participantMatricula = "Matricula"; // Get from login
            UserInfoLabel.Text = $"Nombre: {participantName}, Matrícula: {participantMatricula}";
        }

        private async void LoadAvailableSubjects()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    await conn.OpenAsync();
                    string query = "SELECT * FROM carrerasuapa";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = await cmd.ExecuteReaderAsync();
                        while (await reader.ReadAsync())
                        {
                            AvailableSubjects.Add(new Subject
                            {
                                Name = reader["Nombre"].ToString(),
                                Trimesters = int.Parse(reader["Trimestres"].ToString()),
                                Duration = int.Parse(reader["Duracion"].ToString()),
                                School = reader["Escuela"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Error al cargar asignaturas: {ex.Message}", "OK");
            }
        }

        private void OnAddSubjectClicked(object sender, EventArgs e)
        {
            if (AvailableSubjectsCollectionView.SelectedItem is Subject selectedSubject)
            {
                if (!SelectedSubjects.Contains(selectedSubject))
                {
                    SelectedSubjects.Add(selectedSubject);
                }
                AvailableSubjectsCollectionView.SelectedItem = null; // Clear selection
            }
        }

        private async void OnSaveSelectionClicked(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    await conn.OpenAsync();
                    foreach (var subject in SelectedSubjects)
                    {
                        string query = "INSERT INTO seleccionparticipante (Nombre, Matricula, Asignatura) VALUES (@Nombre, @Matricula, @Asignatura)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nombre", participantName);
                            cmd.Parameters.AddWithValue("@Matricula", participantMatricula);
                            cmd.Parameters.AddWithValue("@Asignatura", subject.Name);
                            await cmd.ExecuteNonQueryAsync();
                        }
                    }
                }
                await DisplayAlert("Éxito", "Selección guardada exitosamente", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Error al guardar selección: {ex.Message}", "OK");
            }
        }
    }

    public class Subject
    {
        public string Name { get; set; }
        public int Trimesters { get; set; }
        public int Duration { get; set; }
        public string School { get; set; }
    }
}
