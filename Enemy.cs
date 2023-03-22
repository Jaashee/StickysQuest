using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Enemy
    {
        public int EnemyHealth { get; set; }

        public Enemy()
        {

        }
        public Enemy(int EnemyHealth)
        {
            this.EnemyHealth = EnemyHealth;
        }
    }
}
