/*
 * MVC 패턴의 동작 방식을 알아보기 위한 Demo용 코드 입니다.
 * Xamarin 을 이용한 코드를 작성하실 경우 Xamarin 에서 제공 해주는 
 * 강력한 Data Binding 기능 및 MVVM 패턴을 이용 하시면 
 * 더 유연한 코드를 작성 하실 수 있습니다.
 * 
 * 소스 참조 : https://stackoverflow.com/questions/32304766/how-can-i-cancel-from-device-starttimer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace DJView.Helpers
{
    public class DeviceTimer
    {
        readonly Action _Task;
        readonly List<TaskWrapper> _Tasks = new List<TaskWrapper>();
        readonly TimeSpan _interval;
        public bool IsRecurring { get; }
        public bool IsRunning => _Tasks.Any(t => t.IsRunning);

        public DeviceTimer(TimeSpan interval, Action task, 
          bool isRecurring = false, bool start = false)
        {
            _Task = task;
            _interval = interval;
            IsRecurring = isRecurring;
            if (start)
                Start();
        }

        public void Restart()
        {
            Stop();
            Start();
        }

        public void Start()
        {
            if (IsRunning)
                // Already Running
                return;

            var wrapper = new TaskWrapper(_Task, IsRecurring, true);
            _Tasks.Add(wrapper);

            Device.StartTimer(_interval, wrapper.RunTask);
        }

        public void Stop()
        {
            foreach (var task in _Tasks)
                task.IsRunning = false;
            _Tasks.Clear();
        }


        class TaskWrapper
        {
            public bool IsRunning { get; set; }
            bool _IsRecurring;
            Action _Task;
            public TaskWrapper(Action task, bool isRecurring, bool isRunning)
            {
                _Task = task;
                _IsRecurring = isRecurring;
                IsRunning = isRunning;
            }

            public bool RunTask()
            {
                if (IsRunning)
                {
                    _Task();
                    if (_IsRecurring)
                        return true;
                }

                // No longer need to recur. Stop
                return IsRunning = false;
            }
        }
    }
}