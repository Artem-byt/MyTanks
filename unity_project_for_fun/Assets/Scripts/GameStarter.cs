using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun
{
    public class GameStarter : MonoBehaviour
    {
        private ControllPlayerObject _controllPlayerObject;


        private Controllers _controllers;

        void Start()
        {
            _controllPlayerObject = new ControllPlayerObject();
            _controllers = new Controllers();
            new GameInitialization(_controllers, _controllPlayerObject);
            _controllers.Initialize();
        }


        void Update()
        {
            _controllers.Execute();
        }

        private void OnDestroy()
        {
            _controllers.CleanUp();
        }
    }
}

