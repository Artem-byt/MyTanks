using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun
{
    public class PlayerInitialization : IInitialize
    {
        private PlayerFactory _playerFactory;

        public PlayerInitialization()
        {
            _playerFactory = new PlayerFactory();
        }

        public void Initialize()
        {
            var players = Resources.Load<PlayerInfo>("PlayerInfo").GetPlayers().Item1;
            for (int i = 0; i < players.Length; i++)
            {
                var player = _playerFactory.CreatePlayer(i);
                IteractionObjectsLocator.Add(player);
                var turret = player.GetPlayerModel.GetPlayerOnScene.GetComponentInChildren<PLayerView>().gameObject;
                AssosiationMapForGameObjectAndPlayerObjectTurret.AssosiationMapOfGameObjectAndPlayer[turret] = player;
            }

        }
    }
}

