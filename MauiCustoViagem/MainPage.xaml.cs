namespace MauiCustoViagem
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_criarPedagio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.AddPedagio());
        }

        private void btn_ListaPedagio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.ListaPedagio());
        }

        private async void btn_calcular_Clicked(object sender, EventArgs e)
        {
            if (txt_origem.Text == null)
            {
                await DisplayAlert("Erro", "Preencha o lugar de origem", "Ok");
                return;
            }
        }
    }

}
