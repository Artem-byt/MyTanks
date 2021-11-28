using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fun
{
    public class TimerController : IExecute
    {


        public void RemoveTimeData(TimeData timeData)
        {
            TimerModel.Timers.Remove(timeData);
            
        }

        public void Execute()
        {
            for (int i = 0; i < TimerModel.Timers.Count; i++)
            {
                var deltaTimerTime = (Time.time - TimerModel.Timers[i].GetStartTime);
                if (deltaTimerTime >= TimerModel.Timers[i].GetDeltaTime)
                {
                    TimerModel.Timers[i].InvokeTimerEnd();
                    TimerModel.Timers[i].Dispose();
                    RemoveTimeData(TimerModel.Timers[i]);
                }
            }
        }
    }
}

