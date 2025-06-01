using CadastroEvento.Models;

namespace CadastroEvento;

public partial class MainPage : ContentPage
{
    public Evento Evento { get; set; }

    public MainPage()
    {
        InitializeComponent();

        Evento = new Evento
        {
            DataInicio = DateTime.Today,
            DataTermino = DateTime.Today.AddDays(1)
        };

        BindingContext = this;
    }

    private async void OnCadastrarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ResumoPage(Evento));
    }
}
