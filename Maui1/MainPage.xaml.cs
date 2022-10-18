namespace Maui1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void ContentPage_SizeChanged(System.Object sender, System.EventArgs e)
    {
        if (CounterBtn.Width <= 0)
            throw new Exception("Exception2: Component's width -1 in SizeChanged event");
    }

    void ContentPage_Loaded(System.Object sender, System.EventArgs e)
    {
        if (CounterBtn.Width <= 0)
            throw new Exception("Exception1: Component's width -1 in Loaded event");
    }
}