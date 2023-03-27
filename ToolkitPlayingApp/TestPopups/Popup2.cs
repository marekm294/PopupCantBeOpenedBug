using CommunityToolkit.Maui.Views;

namespace ToolkitPlayingApp.TestPopups;
class Popup2 : Popup
{
    public Popup2()
    {
        var button = new Button();
        button.Text = "Popup2";
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
        Close(Enum2.Two);
    }
}
