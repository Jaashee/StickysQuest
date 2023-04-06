using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Enemy_Attack
    {
        public double EnemyAttackID { get; set; }
        public string EnemyAttackName { get; set; }
        public string EnemyAttackDesc { get; set; }
        public double EnemyAttackDamage { get; set; }




        public Enemy_Attack()
        {

            this.EnemyAttackID = 1;
            this.EnemyAttackName = "tackle";
            this.EnemyAttackDesc = "The enemy throws themselves at you!";
            this.EnemyAttackDamage = 10;
        }

        public Enemy_Attack(int EnemyAttackID, string EnemyAttackName, string EnemyAttackDesc, double EnemyAttackDamage)
        {
            this.EnemyAttackID = EnemyAttackID;
            this.EnemyAttackName = EnemyAttackName;
            this.EnemyAttackDesc = EnemyAttackDesc;
            this.EnemyAttackDamage = EnemyAttackDamage;


        }
    }
}