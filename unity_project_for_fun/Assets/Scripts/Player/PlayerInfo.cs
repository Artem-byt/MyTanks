using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun
{
    [CreateAssetMenu(menuName = "Gameplay/PlayerInfo", fileName = "Gameplay")]
    public class PlayerInfo : ScriptableObject
    {
        [Serializable]
        private struct PlayerInfoStruct
        {
            public GameObject PlayerPrefab;
            public int PlayerID;
            public Vector3 Position;
            public Vector3 Rotation;
            public int MaxHP;
        }

        [SerializeField]
        private List<PlayerInfoStruct> _players;

        public (GameObject[], int[], Vector3[], Vector3[], int[]) GetPlayers()
        {
            var (players, playersID, playersPosition, playersRotation, playersHP) =
                (new GameObject[_players.Count],
                new int[_players.Count],
                new Vector3[_players.Count],
                new Vector3[_players.Count],
                new int[_players.Count]);
            for (var i = 0; i < _players.Count; i++)
            {
                var player = _players[i];
                if (player.PlayerPrefab == null)
                {
                    throw new InvalidOperationException("Enemy prefab not found");
                }
                players[i] = player.PlayerPrefab;
                playersID[i] = player.PlayerID;
                playersPosition[i] = player.Position;
                playersRotation[i] = player.Rotation;
                playersHP[i] = player.MaxHP;
            }
            return (players, playersID, playersPosition, playersRotation, playersHP);
        }
    }
}

