using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun
{
    public class GameInitialization
    {
        public GameInitialization(Controllers controllers, ControllPlayerObject controllPlayerObject)
        {
            var timerController = new TimerController();
            var interactionObjectsInitialize = new InteractionObjectsInitializator();
            interactionObjectsInitialize.Initialize();
            var changePlayerController = new ChangingPlayerOnSceneInitialization(controllPlayerObject);
            var rotatePlayerController = new RotatePlayersController(controllPlayerObject);

            controllers.Add(timerController);
            
        }
    }
}

