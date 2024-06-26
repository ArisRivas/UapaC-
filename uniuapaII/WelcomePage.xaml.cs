using Microsoft.Maui.Controls;
using System;

namespace uniuapaII
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void OnSelectSubjectsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SelectSubjectsPage());
        }

        private async void OnPrintSelectionClicked(object sender, EventArgs e)
        {
            // Implement the functionality to print the selection
            await DisplayAlert("Info", "Funcionalidad para imprimir la selección", "OK");
        }
    }
}
