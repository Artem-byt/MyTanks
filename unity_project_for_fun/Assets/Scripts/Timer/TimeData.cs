using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace Fun
{
    public class TimeData : IDisposable
    {

        public event Action OnTimerEnd = delegate() { };


        private readonly float _startTime;
        private readonly float _deltaTime;

        public float GetStartTime { get => _startTime; }
        public float GetDeltaTime { get => _deltaTime; }

        public TimeData(float deltaTime)
        {
            _startTime = Time.time;
            _deltaTime = deltaTime;
        }


        public void InvokeTimerEnd()
        {
            OnTimerEnd.Invoke();
        }

        public void Dispose()
        {
            OnTimerEnd = null;
        }
    }
}

