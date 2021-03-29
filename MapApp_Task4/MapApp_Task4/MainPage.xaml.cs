using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
namespace MapApp_Task4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonCoords_Clicked(object sender, EventArgs e)
        {
            if(!double.TryParse(EntryLatitude.Text, out double lat))
            {
                return;
            }
            if (!double.TryParse(EntryLongitude.Text, out double lng))
            {
                return;
            }
            await Map.OpenAsync(lat, lng, new MapLaunchOptions
            {
                Name = EntryName.Text,
                NavigationMode = NavigationMode.None
            });
        }
    }
}
