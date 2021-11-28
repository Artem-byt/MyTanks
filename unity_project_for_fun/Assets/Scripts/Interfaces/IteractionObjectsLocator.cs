using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun
{
    public static class IteractionObjectsLocator
    {
        private static List<IIteractionPlayer> _players = new List<IIteractionPlayer>(8);
        private static List<IIteractionEnemy> _enemies = new List<IIteractionEnemy>(8);


        public static List<IIteractionPlayer> GetPlayers { get => _players; }
        public static List<IIteractionEnemy> GetEnemies { get => _enemies; }

        public static void Add(IIteraction iteraction)
        {
            if(iteraction is IIteractionPlayer)
            {
                var iteractionPlayer = iteraction as IIteractionPlayer;
                _players.Add(iteractionPlayer);
            }
            if(iteraction is IIteractionEnemy)
            {
                var iteractionEnemy = iteraction as IIteractionEnemy;
                _enemies.Add(iteractionEnemy);
            }
            
        }

        public static void Remove(IIteraction iteraction)
        {
            if (iteraction is IIteractionPlayer)
            {
                var iteractionPlayer = iteraction as IIteractionPlayer;
                _players.Remove(iteractionPlayer);
            }
            if (iteraction is IIteractionEnemy)
            {
                var iteractionEnemy = iteraction as IIteractionEnemy;
                _enemies.Remove(iteractionEnemy);
            }
        }


    }
}

