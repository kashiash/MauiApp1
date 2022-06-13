namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

    }

    private  void slider_ValueChanged(object sender, EventArgs e)
    {
        Color color = Color.FromRgb(sliderR.Value, sliderG.Value, sliderB.Value);
        rectangle.Fill = new SolidColorBrush(color);
    }


}

