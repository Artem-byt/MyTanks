using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun
{
    public class EnemyModel
    {
        private GameObject _enemyOnScene;
        private int _maxHP;
        private EnemyView _enemyView;

        public GameObject GetEnemyOnScene { get => _enemyOnScene; }
        public int GetMaxHP { get => _maxHP; }
        public EnemyView GetEnemyView { get => _enemyView; }

        public EnemyModel(EnemyInfo playerInfo, int idOfPlayer)
        {
            _enemyOnScene = Object.Instantiate(playerInfo.GetEnemies().Item1[idOfPlayer]); ;
            _maxHP = playerInfo.GetEnemies().Item5[idOfPlayer];
            _enemyView = _enemyOnScene.GetComponentInChildren<EnemyView>();
        }
    }
}

