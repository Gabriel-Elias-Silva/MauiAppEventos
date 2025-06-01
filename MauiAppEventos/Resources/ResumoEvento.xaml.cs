
using MauiAppEventos.Models;

namespace MauiAppEventos.Views
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();
            BindingContext = evento;
        }

        
    }
}
