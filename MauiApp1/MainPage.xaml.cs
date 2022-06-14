using MauiApp1.Model;


namespace MauiApp1;

public partial class MainPage : ContentPage
{
    int count = 0;
    private bool updateGUI = true;
    public MainPage()
    {
        InitializeComponent();
        Model.Color color = Settings.Load();
        updateGUI = false;
        sliderR.Value = color.R;
        sliderG.Value = color.G;
        updateGUI = true;
        sliderB.Value = color.B;
    }

    private void slider_ValueChanged(object sender, EventArgs e)
    {
        Model.Color color = new Model.Color(sliderR.Value, sliderG.Value, sliderB.Value);
        rectangle.Fill = new SolidColorBrush(color.ToMauiColor());
        labelR.Text = Math.Round(255 * color.R).ToString();
        labelG.Text = Math.Round(255 * color.G).ToString();
        labelB.Text = Math.Round(255 * color.B).ToString();

        Settings.Save(color);
    }


}
static class ColorExtenstion
{
    public static Microsoft.Maui.Graphics.Color ToMauiColor(
        this Model.Color color)
    {
        return new Microsoft.Maui.Graphics.Color(
            (float)color.R, (float)color.G, (float)color.B);
    }
}

