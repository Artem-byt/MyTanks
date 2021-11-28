using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Fun
{
    public class PlayerModel
    {
        private GameObject _playerOnScene;
        private int _maxHP;
        private PLayerView _pLayerView;

        public GameObject GetPlayerOnScene { get => _playerOnScene; }
        public int GetMaxHP { get => _maxHP; }
        public PLayerView GetPlayerView { get => _pLayerView; }

        public PlayerModel(PlayerInfo playerInfo, int idOfPlayer)
        {
            _playerOnScene = Object.Instantiate(playerInfo.GetPlayers().Item1[idOfPlayer]); ;
            _maxHP = playerInfo.GetPlayers().Item5[idOfPlayer];
            _pLayerView = _playerOnScene.GetComponentInChildren<PLayerView>();
        }
    }
}

