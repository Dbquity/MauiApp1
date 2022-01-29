namespace MauiApp1;
using static MauiLib1.Class1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count = Shift(count);
		CounterLabel.Text = $"Current count: {count}{Environment.NewLine} on {Seed}";

		SemanticScreenReader.Announce(CounterLabel.Text);
	}
}

