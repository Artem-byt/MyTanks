using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun
{
    public class EnemyInitialization : IInitialize
    {
        private EnemyFactory _enemyFactory;

        public EnemyInitialization()
        {
            _enemyFactory = new EnemyFactory();
        }

        public void Initialize()
        {
            var enemies = Resources.Load<EnemyInfo>("EnemyInfo").GetEnemies().Item1;
            for (int i = 0; i < enemies.Length; i++)
            {
                IteractionObjectsLocator.Add(_enemyFactory.CreateEnemy(i));
            }

        }
    }
}

