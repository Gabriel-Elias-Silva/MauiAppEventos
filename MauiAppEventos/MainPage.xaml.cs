using MauiAppEventos.Views;
using MauiAppEventos.Models;



namespace MauiAppEventos
{
    public partial class MainPage : ContentPage
    {
        private Evento _evento;

        public MainPage()
        {
            InitializeComponent();

            _evento = new Evento
            {
                DataInicio = DateTime.Today,
                DataTermino = DateTime.Today
            };

            BindingContext = _evento;
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ResumoEventoPage(_evento));
        }
    }
}
