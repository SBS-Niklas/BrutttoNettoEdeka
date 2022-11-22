
using Button = Microsoft.Maui.Controls.Button;
namespace BrutttoNettoEdeka;

public partial class MainPage : ContentPage
{
    Label label = new Label();
    Entry entry = new Entry();
    Button button = new Button();

    public MainPage()
	{
		InitializeComponent();

		label.Text = "Bruttolohn";
		entry.Placeholder = "Hier Bruttolohn eingeben";
		button.Text = "Berechnen";

		StackLayout views = new StackLayout();

		views.Add(label);
		views.Add(entry);
		views.Add(button);

		Content = views;

		button.Clicked += new EventHandler(btn_Clicked);
    }

    private void btn_Clicked(object sender, EventArgs e)
    {
        //double helper = double.Parse(entry.Text) * 0.55;
        //DisplayAlert(helper.ToString(), "Ihr Lohn nach den horenden Abzügen des Staates, FRECHHEIT ", "Okey", "Rage");
        DisplayAlert(Math.Round((double.Parse(entry.Text) * 0.55),2).ToString(), "Ihr Lohn nach den horenden Abzügen des Staates, FRECHHEIT ", "Okey", "Rage");
    }
}

