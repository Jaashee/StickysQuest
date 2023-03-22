using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Weapon
    {
        public string WeaponName { get; set; }
        public string WeaponDesc { get; set; }
        public string WeaponImage { get; set; }
        public int WeaponDamage { get; set; }
        public int SPCost { get; set; }



        public Weapon()
        {
            this.WeaponName = "Dagger";
            this.WeaponDesc = "Short, but gets to the point";

            this.WeaponImage = "Images/Dagger.png";
            this.WeaponDamage = 15;
            this.SPCost = 10;

        }

        public Weapon(string WeaponName, string WeaponDesc, string WeaponImage, int WeaponDamage, int SPCost)
        {
            this.WeaponName = WeaponName;
            this.WeaponDesc = WeaponDesc;
            this.WeaponImage = WeaponImage;
            this.WeaponDamage = WeaponDamage;
            this.SPCost = SPCost;


        }
    }
}
