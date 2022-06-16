using Plugin.SimpleAudioPlayer;
using System.Windows.Input;
using Xamarin.Forms;
namespace AdventCalendar

{
    public partial class MainPage : ContentPage
    {
        private string captionText;
        public string CaptionText
        {
            get
            {
                return captionText;
            }
            set
            {
                captionText = value;
                OnPropertyChanged();
            }
        }
        public ICommand SinclairImgCommand { get; private set; }
        public ICommand CommodoreImgCommand { get; private set; }
        public ICommand AmstradImgCommand { get; private set; }
        public ICommand VegetaImgCommand { get; private set; }
        public ICommand XmasDekuImgCommand { get; private set; }
        public ICommand AcedemiaImgCommand { get; private set; }

        public ICommand homerImgCommand { get; private set; }

        public ICommand RamsayImgCommand { get; private set; }

        public ICommand GOKUImgCommand { get; private set; }

        public ICommand bleachImgCommand { get; private set; }

        public ICommand saitamaImgCommand { get; private set; }

        public ICommand pikaImgCommand { get; private set; }

        public ICommand gokusantaImgCommand { get; private set; }

        public ICommand oncepieceImgCommand { get; private set; }

        public ICommand narutoImgCommand { get; private set; }

        public ICommand caydeImgCommand { get; private set; }

        public ICommand shwiftmasImgCommand { get; private set; }

        public ICommand harrypotterImgCommand { get; private set; }

        public ICommand bakuImgCommand { get; private set; }

        public ICommand friezaImgCommand { get; private set; }

        public ICommand scoobyImgCommand { get; private set; }

        public ICommand sonicImgCommand { get; private set; }

        public ICommand gogetaImgCommand { get; private set; }

        public ICommand andrewImgCommand { get; private set; }

        public ICommand kittyImgCommand { get; private set; }

        private ISimpleAudioPlayer Player { get; }
        public MainPage()
        {
            BindingContext = this;
            this.Player = CrossSimpleAudioPlayer.Current;
            SinclairImgCommand = new Command(() =>
            {
                this.CaptionText = "1. Sinclair Spectrum";
                this.Player.Load("spectrumsound.mp3");
                this.Player.Play();
            });
            AmstradImgCommand = new Command(() =>
            {
                this.CaptionText = "2. Amstrad CPC464";
                this.Player.Load("amstradsound.mp3");
                this.Player.Play();
            });
            CommodoreImgCommand = new Command(() =>
            {
                this.CaptionText = "3. Commodore C64";
                this.Player.Load("commodoresound.mp3");
                this.Player.Play();
            });
            VegetaImgCommand = new Command(() =>
            {
                this.CaptionText = "4. Vegeta";
                this.Player.Load("Vegeta.mp3");
                this.Player.Play();
            });
            XmasDekuImgCommand = new Command(() =>
            {
                this.CaptionText = "5. Midoriya";
                this.Player.Load("Deku.mp3");
                this.Player.Play();
            });
            AcedemiaImgCommand = new Command(() =>
            {
                this.CaptionText = "11. Boku No Hero";
                this.Player.Load("Allmight.mp3");
                this.Player.Play();
            });
            homerImgCommand = new Command(() =>
            {
                this.CaptionText = "6. Homer";
                this.Player.Load("Homer.mp3");
                this.Player.Play();
            });
            RamsayImgCommand = new Command(() =>
            {
                this.CaptionText = "7. Ramsay";
                this.Player.Load("wheresthelamsauce.mp3");
                this.Player.Play();
            });
            GOKUImgCommand = new Command(() =>
            {
                this.CaptionText = "10. Son Goku";
                this.Player.Load("Goku.mp3");
                this.Player.Play();
            });
            bleachImgCommand = new Command(() =>
            {
                this.CaptionText = "24. Ichigo";
                this.Player.Load("Ichigo.mp3");
                this.Player.Play();
            });
            saitamaImgCommand = new Command(() =>
            {
                this.CaptionText = "21. Saitama";
                this.Player.Load("Saitama.mp3");
                this.Player.Play();
            });
            gokusantaImgCommand = new Command(() =>
            {
                this.CaptionText = "15. Santa Goku";
                this.Player.Load("InstantTransmission.mp3");
                this.Player.Play();
            });
            pikaImgCommand = new Command(() =>
            {
                this.CaptionText = "19. Pikachu";
                this.Player.Load("Pikachu.mp3");
                this.Player.Play();
            });
            oncepieceImgCommand = new Command(() =>
            {
                this.CaptionText = "8. One Piece";
                this.Player.Load("luffygear2.mp3");
                this.Player.Play();
            });
            narutoImgCommand = new Command(() =>
            {
                this.CaptionText = "9. Naruto";
                this.Player.Load("narutojustsu.mp3");
                this.Player.Play();
            });
            caydeImgCommand = new Command(() =>
            {
                this.CaptionText = "18. Cayde-6";
                this.Player.Load("caydeaud.mp3");
                this.Player.Play();
            });
            shwiftmasImgCommand = new Command(() =>
            {
                this.CaptionText = "25. Rick and Morty";
                this.Player.Load("shwifty.mp3");
                this.Player.Play();
            });
            harrypotterImgCommand = new Command(() =>
            {
                this.CaptionText = "23. Harry Potter";
                this.Player.Load("Harry.mp3");
                this.Player.Play();
            });
            bakuImgCommand = new Command(() =>
            {
                this.CaptionText = "14. Bakugo";
                this.Player.Load("bakugo.mp3");
                this.Player.Play();
            });
            friezaImgCommand = new Command(() =>
            {
                this.CaptionText = "20. Freiza";
                this.Player.Load("friezahoho.mp3");
                this.Player.Play();
            });
            scoobyImgCommand = new Command(() =>
            {
                this.CaptionText = "16. Scoody Doo";
                this.Player.Load("scooby.mp3");
                this.Player.Play();
            });
            sonicImgCommand = new Command(() =>
            {
                this.CaptionText = "22. Sonic";
                this.Player.Load("sonic.mp3");
                this.Player.Play();
            });
            gogetaImgCommand = new Command(() =>
            {
                this.CaptionText = "13. Gogeta";
                this.Player.Load("gogeta.mp3");
                this.Player.Play();
            });
            andrewImgCommand = new Command(() =>
            {
                this.CaptionText = "12. Mario Cat";
                this.Player.Load("CATT.mp3");
                this.Player.Play();
            });
            kittyImgCommand = new Command(() =>
            {
                this.CaptionText = "17. Hello Kitty";
                this.Player.Load("Kittyhello.mp3");
                this.Player.Play();
            });
            this.CaptionText = "Advent Calendar 2020!" + " " +
                "Touch an image to hear a sound!";
            InitializeComponent();
        }
    }
}