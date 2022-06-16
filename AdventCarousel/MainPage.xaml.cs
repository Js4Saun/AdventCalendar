using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.SimpleAudioPlayer;
using Xamarin.Forms.Shapes;

namespace AdventCarousel
{
    public partial class MainPage : ContentPage

    {
        public double num = 1;

        public double Num 
        { 
            get
            {
                return this.num;
            }
            set
            {
                this.num = value;
                OnPropertyChanged();
            }           
        }

        private ISimpleAudioPlayer Player { get; }
        public MainPage()
        {
            BindingContext = this;
            this.Player = CrossSimpleAudioPlayer.Current;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CVDoors.ItemsSource = AdventDoors.GetDoorList();

        }
        

        public void Button_Clicked(object sender, System.EventArgs e)
        {
            this.Player.Stop();
            var buttonClicked = (Button)sender;
            var frameBtn = buttonClicked.FindByName("frameBtn") as Frame;
            var clickedDoor = (Door)((Button)sender).BindingContext;
            if (frameBtn.Opacity == 1)
            {
                this.Player.Load(clickedDoor.SoundFile);
                this.Player.Play();
                frameBtn.Opacity = 0;
            }
            else
            {
                frameBtn.Opacity = 1;
            }
                     
        }

        public void CVDoors_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            
            if (CVDoors.Position==25)
            {
                /////// IT JUST WORKS //////
                Navigation.PushAsync(new MainPage());
                
            }
        }

    }
}
