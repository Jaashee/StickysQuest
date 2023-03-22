using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Potion
    {
        public string PotionName { get; set; }
        public string PotionDesc { get; set; }
        public string PotionImage { get; set; }
        public string PotionEffect { get; set; }




        public Potion()
        {

            this.PotionName = "Red Potion";
            this.PotionDesc = "Heals 50 hp";
            this.PotionImage = "temp";
            this.PotionEffect = "heals 50 hp";
        }

        public Potion(string PotionName, string PotionDesc, string PotionImage, string PotionEffect)
        {
            this.PotionName = PotionName;
            this.PotionDesc = PotionDesc;
            this.PotionImage = PotionImage;
            this.PotionEffect = PotionEffect;




        }
    }
}