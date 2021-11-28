using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun
{
    public class EnemyFactory
    {
        public Enemy CreateEnemy(int idOfEnemy)
        {
            return new Enemy(Resources.Load<EnemyInfo>("EnemyInfo"), idOfEnemy);
        }
    }
}

