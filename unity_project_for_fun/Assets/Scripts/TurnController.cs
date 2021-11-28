using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun
{
    public static class TurnController
    {
        public static int NumberOfShootedPlayers = 0;

        public static void ChangeTurnToEnemyToShoot()
        {
            NumberOfShootedPlayers++;

            if (NumberOfShootedPlayers == IteractionObjectsLocator.GetPlayers.Count)
            {
                //StopPlayersTurn();
                StartEnemiesTurn();
                NumberOfShootedPlayers = 0;
            }
            
        }

        private static void StopPlayersTurn()
        {

        }

        private static void StartEnemiesTurn()
        {
            for (int i = 0; i < IteractionObjectsLocator.GetEnemies.Count; i++)
            {
                var timer = new TimeData(2f * i);
                timer.OnTimerEnd += ActionOnEnemy;
                TimerModel.Timers.Add(timer);
            }

        }

        private static void ActionOnEnemy()
        {
            Debug.Log("Враг типо выстрелил");
        }
    }
}

