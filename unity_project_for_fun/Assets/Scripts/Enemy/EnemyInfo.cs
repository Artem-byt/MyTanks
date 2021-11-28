using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun
{
    [CreateAssetMenu(menuName = "Gameplay/EnemyInfo", fileName = "Gameplay")]
    public class EnemyInfo : ScriptableObject
    {
        [Serializable]
        private struct EnemyInfoStruct
        {
            public GameObject EnemyPrefab;
            public int enemyID;
            public Vector3 Position;
            public Vector3 Rotation;
            public int MaxHP;
        }

        [SerializeField]
        private List<EnemyInfoStruct> _enemies;

        public (GameObject[], int[], Vector3[], Vector3[], int[]) GetEnemies()
        {
            var (enemies, enemiesID, enemyPosition, enemyRotation, enemiesHP) =
                (new GameObject[_enemies.Count],
                new int[_enemies.Count],
                new Vector3[_enemies.Count],
                new Vector3[_enemies.Count],
                new int[_enemies.Count]);
            for (var i = 0; i < _enemies.Count; i++)
            {
                var enemy = _enemies[i];
                if (enemy.EnemyPrefab == null)
                {
                    throw new InvalidOperationException("Enemy prefab not found");
                }
                enemies[i] = enemy.EnemyPrefab;
                enemiesID[i] = enemy.enemyID;
                enemyPosition[i] = enemy.Position;
                enemyRotation[i] = enemy.Rotation;
                enemiesHP[i] = enemy.MaxHP;
            }
            return (enemies, enemiesID, enemyPosition, enemyRotation, enemiesHP);
        }
    }
}

