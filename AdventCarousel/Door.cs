using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;

namespace AdventCarousel
{
    public class Door
    {
        public string DoorNo { get; set; }

        public string Character { get; set; }

        public string ImageSource { get; set; }

        public string SoundFile { get; set; }
        public Color BgColor { get; set; }

    }

    public static class AdventDoors
    {
        public static List<Door> GetDoorList()
        {
            int idx = 1;
            var dict = new Dictionary<int, (string Pic, string Char, string Sound, Color Bg)>
            {
                [idx++] = ("Gogeta.jpg", "Gogeta", "gogeta.mp3", Color.LightBlue),
                [idx++] = ("RickMorty.jpg", "Rick and Morty", "shwifty.mp3", Color.LightGreen),
                [idx++] = ("myXmasAcedemia.jpg", "All Might", "Allmight.mp3", Color.Red),
                [idx++] = ("baku.jpg", "Bakugo", "bakugo.mp3", Color.Blue),
                [idx++] = ("andrew.jpg", "Xmas Cat", "CATT.mp3", Color.DeepPink),
                [idx++] = ("bleachxmas.jpg", "Ichigo", "Ichigo.mp3", Color.Fuchsia),
                [idx++] = ("cayde.jpg", "Cayde-6", "caydeaud.mp3", Color.MediumPurple),
                [idx++] = ("commodore64.jpg", "Commodore 64", "commodoresound.mp3", Color.AliceBlue),
                [idx++] = ("GOKU.jpg", "Son Goku", "Goku.mp3", Color.LightGreen),
                [idx++] = ("gokusanta.jpg", "Goku Santa", "InstantTransmission.mp3", Color.LightSalmon),
                [idx++] = ("goldenfreiza.jpg", "Freiza", "friezahoho.mp3", Color.Gold),
                [idx++] = ("Harrypotter.jpg", "Harry Potter", "Harry.mp3", Color.DarkRed),
                [idx++] = ("hellkittyxmas.jpg", "Hello Kitty", "Kittyhello.mp3", Color.LightSalmon),
                [idx++] = ("homerXmas.jpg", "Homer Simpson", "Homer.mp3", Color.Yellow),
                [idx++] = ("naruto.jpg", "Naruto", "narutojustsu.mp3", Color.RosyBrown),
                [idx++] = ("onepiece.jpg", "Luffy", "luffygear2.mp3", Color.PeachPuff),
                [idx++] = ("RamsayReindeer.jpg", "Gordon Ramsay", "wheresthelamsauce.mp3", Color.SeaGreen),
                [idx++] = ("Saitamaxmas.jpg", "Saitama", "Saitama.mp3", Color.Gold),
                [idx++] = ("scoobyxmas.jpg", "Scooby Doo", "scooby.mp3", Color.BlueViolet),
                [idx++] = ("sinclairspectrum.jpg", "Sinclair Spectrum", "spectrumsound1.mp3", Color.Green),
                [idx++] = ("sonicxmas.jpg", "Sonic", "sonic.mp3", Color.Blue),
                [idx++] = ("VegetaHat.jpg", "Vegeta", "Vegeta.mp3", Color.AliceBlue),
                [idx++] = ("XmasDeku.jpg", "Midoriya", "Deku.mp3", Color.Teal),
                [idx++] = ("xmaspickchu.jpg", "Pikachu", "Pikachu.mp3", Color.Gold),
                [idx++] = ("amstradcpc64.jpg", "Amstrad CPC 64", "amstradsound.mp3", Color.Red),
                [idx++] = ("","","",Color.Transparent),
            };

            return dict.Select(kvp => new Door
            {
                DoorNo = kvp.Key.ToString(),
                ImageSource = kvp.Value.Pic,
                Character = kvp.Value.Char,
                SoundFile = kvp.Value.Sound,
                BgColor = kvp.Value.Bg
            }).ToList();

        }
    }
}
