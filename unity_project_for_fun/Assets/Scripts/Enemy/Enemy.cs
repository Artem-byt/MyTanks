using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Fun
{
    public class Enemy: IIteractionEnemy
    {
        private EnemyModel _enemyModel;

        public EnemyModel GetEnemyModel { get => _enemyModel; }

        public Enemy(EnemyInfo enemyInfo, int idOfEnemy)
        {
            _enemyModel = new EnemyModel(enemyInfo, idOfEnemy);
            _enemyModel.GetEnemyOnScene.transform.position = enemyInfo.GetEnemies().Item3[idOfEnemy];
            _enemyModel.GetEnemyOnScene.transform.rotation.SetEulerAngles(enemyInfo.GetEnemies().Item4[idOfEnemy]);
        }
    }
}

