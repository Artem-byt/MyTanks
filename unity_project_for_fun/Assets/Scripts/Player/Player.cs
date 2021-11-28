using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Fun
{
    public class Player : IIteractionPlayer
    {
        public event Action OnPlayerTurnCHangeOnEnemyTurn;

        private PlayerModel _playerModel;
        public bool IsEndOfPlayerTurn { get; set; }


        public PlayerModel GetPlayerModel { get => _playerModel; }
        public Player(PlayerInfo playerInfo, int idOfPlayer)
        {
            _playerModel = new PlayerModel(playerInfo, idOfPlayer);
            _playerModel.GetPlayerOnScene.transform.position = playerInfo.GetPlayers().Item3[idOfPlayer];
            _playerModel.GetPlayerOnScene.transform.rotation.SetEulerAngles(playerInfo.GetPlayers().Item4[idOfPlayer]);
            OnPlayerTurnCHangeOnEnemyTurn += TurnController.ChangeTurnToEnemyToShoot;
        }

        public void InvokeChangeTurn()
        {
            OnPlayerTurnCHangeOnEnemyTurn?.Invoke();
        }

        
    }
}

