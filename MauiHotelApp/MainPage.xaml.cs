namespace MauiHotelApp;

public partial class MainPage : ContentPage
{
    int adultos = 1;
    int criancas = 3;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnIncreaseAdults(object sender, EventArgs e)
    {
        adultos++;
        AdultosCount.Text = adultos.ToString();
    }

    private void OnDecreaseAdults(object sender, EventArgs e)
    {
        if (adultos > 0) adultos--;
        AdultosCount.Text = adultos.ToString();
    }

    private void OnIncreaseChildren(object sender, EventArgs e)
    {
        criancas++;
        CriancasCount.Text = criancas.ToString();
    }

    private void OnDecreaseChildren(object sender, EventArgs e)
    {
        if (criancas > 0) criancas--;
        CriancasCount.Text = criancas.ToString();
    }

private void OnAvancarClicked(object sender,
                              EventArgs e)
{
    // Verifica se uma suíte foi escolhida
    if (SuitePicker.SelectedItem == null)
    {
        DisplayAlert("Erro", "Por favor, selecione uma suíte.", "OK");
        return;
    }

    // Verifica se a data foi escolhida
    if (PeriodoDatePicker.Date < DateTime.Today)
    {
        DisplayAlert("Erro", "Por favor, selecione uma data válida para a estadia.", "OK");
        return;
    }

    // Exibe mensagem de sucesso
    DisplayAlert("Sucesso", "Reserva feita com sucesso!", "OK");
}

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobrePage());
    }
}

