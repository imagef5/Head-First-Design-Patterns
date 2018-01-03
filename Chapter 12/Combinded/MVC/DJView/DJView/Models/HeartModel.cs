/*
 * MVC 패턴의 동작 방식을 알아보기 위한 Demo용 코드 입니다.
 * Xamarin 을 이용한 코드를 작성하실 경우 Xamarin 에서 제공 해주는 
 * 강력한 Data Binding 기능 및 MVVM 패턴을 이용 하시면 
 * 더 유연한 코드를 작성 하실 수 있습니다.
 */
using System;
using System.Collections.Generic;
using DJView.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace DJView.Models
{
    public class HeartModel : IHeartModel
    {
        int time = 1000;
        //int bpm = 90;
        CancellationTokenSource cancellationToken;
        List<IBMPObserver> observers = new List<IBMPObserver>();
        Random random = new Random(DateTime.Now.Millisecond);

        public HeartModel()
        {
            Task.Delay(0).ContinueWith( 
                    async (arg) => await Init(),
                    TaskScheduler.FromCurrentSynchronizationContext());
        }

        #region Private Method Area
        /*
         * 데모용 코드 입니다.성능상의 문제가 있을 수 있습니다.
         */
        private async Task Init()
        {
            cancellationToken = new CancellationTokenSource();
            int lastrate = -1;
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    cancellationToken.Token.ThrowIfCancellationRequested();

                    int change = random.Next(10);
                    if (random.Next(2) == 0)
                    {
                        change = 0 - change;
                    }
                    int rate = 60000 / (time + change);
                    if (rate < 120 && rate > 50)
                    {
                        time += change;
                        NotifyObservers();
                        if (rate != lastrate)
                        {
                            lastrate = rate;
                            NotifyObservers();
                        }
                    }

                    await Task.Delay(TimeSpan.FromMilliseconds(time), cancellationToken.Token);

                }
                catch (Exception ex)
                {
                    Debug.WriteLine("EX 1: " + ex.Message);
                }
            }
        }
        #endregion

        #region Implement IHeartModel Interface
        public int HeartRate =>  60000 / time ;

        public void RegisterObserver(IBMPObserver o)
        {
            if (!observers.Contains(o))
            {
                observers.Add(o);
            }
        }

        public void RemoveObserver(IBMPObserver o)
        {
            if (observers.Contains(o))
            {
                observers.Remove(o);
            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.UpdateBPM(HeartRate);
            }
        }
        #endregion
    }
}
