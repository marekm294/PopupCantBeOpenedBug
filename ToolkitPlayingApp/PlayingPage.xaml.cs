using CommunityToolkit.Maui.Views;
using ToolkitPlayingApp.TestPopups;

namespace ToolkitPlayingApp;

public partial class PlayingPage : ContentPage
{
    public PlayingPage()
    {
        InitializeComponent();
    }

    async void Button_Clicked(object sender, EventArgs e)
    {
        var a = await this.ShowPopupAsync(new Popup1());

        //await Task.Delay(1000); // This is workaround
        var b = await this.ShowPopupAsync(new Popup2());
    }
}