using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace STT_Poc
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            AppCenter.Start("android=0722a3e4-5805-4006-9cc1-44343a3b8656;" +
                            "ios={Your iOS App secret here}",
                            typeof(Analytics), typeof(Crashes));

            MainPage = new MainPage();
        }
    }
}
