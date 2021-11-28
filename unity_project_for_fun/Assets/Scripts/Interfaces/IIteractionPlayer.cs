using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun
{
    public interface IIteractionPlayer : IIteraction
    {
        bool IsEndOfPlayerTurn { get; set; }
        public PlayerModel GetPlayerModel { get; }
    }
}

