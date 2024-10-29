namespace Amount;

public partial class MainPage : ContentPage
{
    private bool IsDarkColorScheme = false;
    
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnRegularTipButtonClicked(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void OnGenerousTipButtonClicked(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void OnRoundDownClicked(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void OnRoundUpClicked(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void OnVanillaTipClicked(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void OnChangeColorClicked(object? sender, EventArgs e)
    {
        IsDarkColorScheme = !IsDarkColorScheme;
        Resources["BgColor"] = IsDarkColorScheme ? Colors.Grey : Colors.WhiteSmoke;
    }
}