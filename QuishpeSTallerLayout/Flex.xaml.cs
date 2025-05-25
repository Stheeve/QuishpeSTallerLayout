namespace QuishpeSTallerLayout;

public partial class Flex : ContentPage
{
	public Flex()
	{
		InitializeComponent();
	}

    private void BotonIrAbsolute_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Absolute());
    }
}