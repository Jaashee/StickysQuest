using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TheGame
{
    public class Potion
    {
        public string PotionName { get; set; }
        public string PotionDesc { get; set; }
        public BitmapImage PotionImage { get; set; }
        public string PotionEffect { get; set; }




        public Potion()
        {


        }

        public Potion(string PotionName, string PotionDesc, string PotionImage, string PotionEffect)
        {
            this.PotionName = PotionName;
            this.PotionDesc = PotionDesc;
            this.PotionImage = new BitmapImage(new Uri("Images/" + PotionImage + ".png", UriKind.Relative));
            this.PotionEffect = PotionEffect;




        }
    }
}