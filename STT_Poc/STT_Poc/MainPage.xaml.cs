using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace STT_Poc
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnError1.Clicked += BtnError1_Clicked;
            btnError.Clicked += BtnError_Clicked;
            btnEvents.Clicked += BtnEvents_Clicked;
            btnEvents1.Clicked += BtnEvents1_Clicked;
        }

        private void BtnError1_Clicked(object sender, EventArgs e)
        {
            Crashes.GenerateTestCrash();
        }

        private void BtnEvents1_Clicked(object sender, EventArgs e)
        {
            var properties = new Dictionary<string, string> {
                { "Category", "Music" },
                { "Wifi", "On" }
              };
            Analytics.TrackEvent("Evento2", properties);

            this.DisplayAlert("Poc", "Evento 2", "Ok");
        }

        private void BtnEvents_Clicked(object sender, EventArgs e)
        {
            var properties = new Dictionary<string, string> {
                { "Category", "Music" },
                { "Wifi", "On" }
              };
            Analytics.TrackEvent("Evento1", properties);
            this.DisplayAlert("Poc", "Evento 1", "Ok");
        }

        private void BtnError_Clicked(object sender, EventArgs e)
        {
            var properties = new Dictionary<string, string> {
                { "Category", "Music" },
                { "Wifi", "On" }
              };
            Crashes.TrackError(new Exception("Invalid Operation"), properties);
            this.DisplayAlert("Poc", "Erro", "Ok");
        }
    }
}
