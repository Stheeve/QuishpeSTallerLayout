namespace QuishpeSTallerLayout;

public partial class Absolute : ContentPage
{
	public Absolute()
	{
		InitializeComponent();
	}

    private void BotonIrGrid_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Demo());
    }
}