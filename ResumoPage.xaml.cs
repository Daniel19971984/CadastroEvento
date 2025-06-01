using CadastroEvento.Models;

namespace CadastroEvento;

public partial class ResumoPage : ContentPage
{
    public ResumoPage(Evento evento)
    {
        InitializeComponent();
        BindingContext = evento;
    }
}
