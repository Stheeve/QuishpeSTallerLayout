namespace QuishpeSTallerLayout;

public partial class Demo : ContentPage
{
	public Demo()
	{
		InitializeComponent();
	}

    

    private void BotonIrAStack_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Stack());
    }
}