using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TheGame
{
    public class Weapon  
    {
        public string WeaponName { get; set; }
        public string WeaponDesc { get; set; }
        public BitmapImage WeaponImage { get; set; }
        public BitmapImage WeaponSprite { get; set; }
        public string WeaponPDamageType { get; set; }
        public double WeaponPDamage { get; set; }
        public string WeaponSDamageType { get; set; }
        public double WeaponSDamage { get; set; }

        public double SPCost { get; set; }


        public Weapon()
        {
/*            this.WeaponName = "Dagger";
            this.WeaponDesc = "Short, but gets to the point";

            this.WeaponImage = "Images/Dagger.png";
            this.WeaponDamage = 15;
            this.SPCost = 10;*/

        }

        public Weapon(string WeaponName, string WeaponDesc, string WeaponImage, string WeaponSprite, string WeaponPDamageType, double WeaponPDamage, string WeaponSDamageType, double WeaponSDamage, double SPCost)
        {
            this.WeaponName = WeaponName;
            this.WeaponDesc = WeaponDesc;
            this.WeaponImage = new BitmapImage(new Uri("Images/" + WeaponImage + ".png", UriKind.Relative)); 
            this.WeaponSprite = new BitmapImage(new Uri("Images/" + WeaponSprite + ".png", UriKind.Relative));
            this.WeaponPDamageType = WeaponPDamageType;
            this.WeaponPDamage = WeaponPDamage;
            this.WeaponSDamageType = WeaponSDamageType;
            this.WeaponSDamage = WeaponSDamage;

            this.SPCost = SPCost;


        }
    }
}
