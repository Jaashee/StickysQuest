using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Wand
    {
        public string WandName { get; set; }
        public string WandDesc { get; set; }
        public string WandImage { get; set; }
        public int WandDamage { get; set; }
        public int SPCost { get; set; }
        public int MPCost { get; set; }



        public Wand()
        {


        }

        public Wand(string WandName, string WandDesc, string WandImage, int WandDamage, int SPCost, int MPCost)
        {
            this.WandName = WandName;
            this.WandDesc = WandDesc;
            this.WandImage = WandImage;
            this.WandDamage = WandDamage;
            this.SPCost = SPCost;
            this.MPCost = MPCost;


        }
    }
}