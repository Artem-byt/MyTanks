using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun 
{
    public class ChangingPlayerOnSceneInitialization
    {

        public ChangingPlayerOnSceneInitialization(ControllPlayerObject controllPlayerObject)
        {
            var players = IteractionObjectsLocator.GetPlayers;
            for (int i = 0; i< players.Count; i++)
            {
                players[i].GetPlayerModel.GetPlayerView.OnClickTank += delegate(GameObject gameObject)
                {
                    controllPlayerObject.PlayerToControl = AssosiationMapForGameObjectAndPlayerObjectTurret.AssosiationMapOfGameObjectAndPlayer[gameObject];
                    Debug.Log("Сущность изменена");
                };
            }
            
        }
    }
}


