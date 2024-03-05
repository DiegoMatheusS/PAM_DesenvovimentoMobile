namespace Notes;

public partial class AboutPage : ContentPage
{
	string fileName = "";
	public AboutPage()
	{
		InitializeComponent();


	}
		private async void LearnMore_Clicked (object sender,EventArgs e)
	{
		await Launcher.Default.OpenAsync("https://youtube.com");
	}

}