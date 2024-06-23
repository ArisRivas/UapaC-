using Microsoft.Maui.Controls;
using System;

namespace uniuapaII
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterRaceClicked(object sender, EventArgs e)
        {
            // Asegúrate de que RegisterRacePage existe y está en el espacio de nombres correcto
            await Navigation.PushAsync(new RegisterRacePage());
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            // Asegúrate de que LoginPage existe y está en el espacio de nombres correcto
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
