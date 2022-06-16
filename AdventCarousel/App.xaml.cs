using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("MountainsofChristmas-Bold.ttf", Alias = "xmasB")]
[assembly: ExportFont("MountainsofChristmas-Regular.ttf", Alias = "xmasR")]

namespace AdventCarousel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[]
            {
                "CarouselView-Experimental", "Shapes_Experimental",
            });

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
