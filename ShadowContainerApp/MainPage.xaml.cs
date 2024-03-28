namespace ShadowContainerApp;

public sealed partial class MainPage : Page
{
	public MainPage()
	{
		this.InitializeComponent();
	}

	private void Image_Tapped(object sender, Microsoft.UI.Xaml.Input.TappedRoutedEventArgs e)
	{
		MyShadowContainer.Shadows = MyShadowContainer.Shadows == AlternateShadows ? Shadows : AlternateShadows;
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Frame.Navigate(typeof(NeumorphicPage));
	}
}
