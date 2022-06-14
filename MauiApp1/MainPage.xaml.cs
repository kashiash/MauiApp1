namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;
    private bool updateGUI = true;
    public MainPage()
	{
		InitializeComponent();
        var color = Settings.Load();
        updateGUI = false;
        sliderR.Value = color.r;
        sliderG.Value = color.g;
        updateGUI = true;
        sliderB.Value = color.b;
    }

    private  void slider_ValueChanged(object sender, EventArgs e)
    {
        Color color = Color.FromRgb(sliderR.Value, sliderG.Value, sliderB.Value);
        rectangle.Fill = new SolidColorBrush(color);
        labelR.Text = Math.Round(255 * color.Red).ToString();
        labelG.Text = Math.Round(255 * color.Green).ToString();
        labelB.Text = Math.Round(255 * color.Blue).ToString();

        Settings.Save(
    sliderR.Value,
    sliderG.Value,
    sliderB.Value);
    }


}

