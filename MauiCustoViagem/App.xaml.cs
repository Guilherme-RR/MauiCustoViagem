using System.Globalization;

namespace MauiCustoViagem
{
    public partial class App : Application
    {
         
        public App()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            MainPage = new AppShell();
        }
    }
}
