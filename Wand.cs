using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TheGame
{
    public class Wand
    {
        public string WandName { get; set; }
        public string WandDesc { get; set; }
        public BitmapImage WandImage { get; set; }
        public BitmapImage WandSprite { get; set; }
        public string WandDamageType { get; set; }
        public double WandDamage { get; set; }
        public double SPCost { get; set; }
        public double MPCost { get; set; }



        public Wand()
        {


        }

        public Wand(string WandName, string WandDesc, string WandImage, string WandSprite, string WandDamageType, double WandDamage, double SPCost, double MPCost)
        {
            this.WandName = WandName;
            this.WandDesc = WandDesc;
            this.WandImage = new BitmapImage(new Uri("Images/" + WandImage + ".png", UriKind.Relative));
            this.WandSprite = new BitmapImage(new Uri("Images/" + WandSprite + ".png", UriKind.Relative));
            this.WandDamageType = WandDamageType;
            this.WandDamage = WandDamage;
            this.SPCost = SPCost;
            this.MPCost = MPCost;


        }
    }
}