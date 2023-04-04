using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TheGame
{
    public class Tower
    {
        public string TowerName { get; set; }
        public string TowerDesc { get; set; }
        public Enemy FirstEnemy { get; set; }
        public Enemy SecondEnemy { get; set; }
        public Enemy ThirdEnemy { get; set; }
        public Enemy FourthEnemy { get; set; }
        public Enemy Boss { get; set; }

        public Tower(string TowerName, string TowerDesc, Enemy FirstEnemy, Enemy SecondEnemy, Enemy ThirdEnemy, Enemy FourthEnemy, Enemy Boss)
        {
            this.TowerName = TowerName;
            this.TowerDesc = TowerDesc;
            this.FirstEnemy = FirstEnemy;
            this.SecondEnemy = SecondEnemy;
            this.ThirdEnemy = ThirdEnemy;
            this.FourthEnemy = FourthEnemy;
            this.Boss = Boss;


        }
    }
}


