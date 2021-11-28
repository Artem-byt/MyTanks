using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun
{
    public class PlayerFactory
    {
        public Player CreatePlayer(int idOfPlayer)
        {
            return new Player(Resources.Load<PlayerInfo>("PlayerInfo"), idOfPlayer);
        }
    }
}

