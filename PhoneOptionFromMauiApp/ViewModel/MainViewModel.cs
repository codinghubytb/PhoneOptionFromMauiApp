using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneOptionFromMauiApp.ViewModel
{
    public class MainViewModel
    {
        public Command ClickFrameCommand { get; }
        public MainViewModel() 
        { 
            ClickFrameCommand = new Command<string>(OnClickFrame);
        }

        async void OnClickFrame(string text)
        {
            await App.Current.MainPage.DisplayAlert("Title", text, "ok");
        }
    }
}
