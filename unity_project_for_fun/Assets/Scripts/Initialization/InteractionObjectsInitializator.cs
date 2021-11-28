using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun
{
    public class InteractionObjectsInitializator: IInitialize
    {
        private PlayerInitialization _playerInitialization;
        private EnemyInitialization _enemyInitialization;


        public PlayerInitialization GetPlayerInitialize { get => _playerInitialization; }
        public EnemyInitialization GetEnemyInitialization { get => _enemyInitialization; }

        public InteractionObjectsInitializator()
        {
            _playerInitialization = new PlayerInitialization(); ;
            _enemyInitialization = new EnemyInitialization();
        }

        public void Initialize()
        {
            _playerInitialization.Initialize();
            _enemyInitialization.Initialize();
        }
    }
}

