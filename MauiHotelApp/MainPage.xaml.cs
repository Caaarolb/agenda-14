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

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobrePage());
    }
}

