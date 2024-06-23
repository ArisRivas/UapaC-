using Microsoft.Maui.Controls;

namespace uniuapaII
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
