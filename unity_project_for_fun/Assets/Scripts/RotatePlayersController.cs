using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun
{
    public class RotatePlayersController
    {


        public RotatePlayersController(ControllPlayerObject controllPlayerObject)
        {
            var enemies = IteractionObjectsLocator.GetEnemies;
            for(int i = 0; i< enemies.Count; i++)
            {
                enemies[i].GetEnemyModel.GetEnemyView.OnClickTank += delegate (GameObject gameObject)
                { 
                    var turret = controllPlayerObject.PlayerToControl.GetPlayerModel.GetPlayerView.gameObject;
                    turret.transform.LookAt(gameObject.transform);
                };
            }
        }
}
}

