namespace InTenYears;

public partial class withSlider : ContentPage
{
	public int age;
	public withSlider()
	{
		InitializeComponent();
	}
    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        age = (int)Slider.Value;
        EntAge.Text = age.ToString();
        
        
    }
    private void Drag_Completed(object sender, EventArgs e)
    {
        Result.Text = "in the years " + EntName.Text + " will be " + (age + 10);
    }
}