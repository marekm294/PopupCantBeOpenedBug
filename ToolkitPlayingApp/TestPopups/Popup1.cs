namespace ToolkitPlayingApp.TestPopups;

using CommunityToolkit.Maui.Views;

public class Popup1 : Popup
{
    public Popup1()
    {
        var button = new Button();
        button.Text = "Popup1";
        button.HeightRequest = 75;
        button.WidthRequest = 75;
        button.Clicked += Button_Clicked;


        Content = new VerticalStackLayout()
        {
            HeightRequest = 200,
            WidthRequest = 200,
            Children =
            {
                button,
            }
        };
    }

    void Button_Clicked(object? sender, EventArgs e)
    {
        Close(Enum1.One);
    }
}
