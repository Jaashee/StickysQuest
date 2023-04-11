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
        public List<Enemy> BossList { get; set; }
        public List<Enemy> EnemyList { get; set; }
        public Tower(string TowerName, string TowerDesc, List<Enemy> EnemyList, List <Enemy> BossList)
        {
            this.TowerName = TowerName;
            this.TowerDesc = TowerDesc;

            var random = new Random();
            int index;

            for (int i = 0; i < 4; i++)
            {
                random = new Random();
                index = random.Next(EnemyList.Count);
                if (i == 0)
                {
                    this.FirstEnemy = (EnemyList[index]);
                    EnemyList.RemoveAt(index);
                }else if (i == 1)
                {
                    this.SecondEnemy = (EnemyList[index]);
                    EnemyList.RemoveAt(index);
                }
                else if (i == 2)
                {
                    this.ThirdEnemy = (EnemyList[index]);
                    EnemyList.RemoveAt(index);
                }
                else if (i == 3)
                {
                    this.FourthEnemy = (EnemyList[index]);
                    EnemyList.RemoveAt(index);
                }
            }

            random = new Random();
            index = random.Next(BossList.Count);
            this.Boss = (BossList[index]);






        }
    }
}


