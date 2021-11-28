using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun
{
    public interface IIteractionEnemy : IIteraction
    {
        public EnemyModel GetEnemyModel { get; }
    }
}

