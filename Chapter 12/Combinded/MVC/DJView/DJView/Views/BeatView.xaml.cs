/*
 * MVC 패턴의 동작 방식을 알아보기 위한 Demo용 코드 입니다.
 * Xamarin 을 이용한 코드를 작성하실 경우 Xamarin 에서 제공 해주는 
 * 강력한 Data Binding 기능 및 MVVM 패턴을 이용 하시면 
 * 더 유연한 코드를 작성 하실 수 있습니다.
 */
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using DJView.Controllers;
using DJView.Helpers;
using DJView.Interfaces;
using Xamarin.Forms;

namespace DJView.Views
{
    public partial class BeatView : ContentView, IBeatView, IBMPObserver
    {
        IBeatController controller;
        CancellationTokenSource cancellationToken;

        public BeatView()
        {
            InitializeComponent();
        }

        public void SetController(IBeatController controller)
        {
            this.controller = controller;
        }

        public void UpdateBPM(int bpm)
        {
            
            currentBPM.Text = bpm.ToString();
            //타이머 스탑후 재시작
            progressActiveCancle();

            if (bpm > 0)
            {
                Task.Delay(100).ContinueWith(
                    async (arg) => await progressActiveAsync(bpm), 
                    TaskScheduler.FromCurrentSynchronizationContext()
                );
            }
        }

        /*
         * 데모용 코드 입니다. 성능상의 문제가 있을 수 있습니다.
         * 소스 참조 : https://github.com/acaliaro/TestThread/blob/master/TestThread/TestThread.cs
         */
        private async Task progressActiveAsync(int bpm)
        {
            var interval = SimpleBPMCalculator.GetMiliSeconds(bpm);

            cancellationToken = new CancellationTokenSource();

            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    cancellationToken.Token.ThrowIfCancellationRequested();
                    await Task.Delay(TimeSpan.FromMilliseconds(interval), cancellationToken.Token).ContinueWith((arg) =>
                   {

                       if (!cancellationToken.Token.IsCancellationRequested)
                       {
                           cancellationToken.Token.ThrowIfCancellationRequested();
                           /*
                            * HERE YOU CAN DO YOUR ACTION
                            */

                           Device.BeginInvokeOnMainThread( async () =>
                           {
                                //put here your code which updates the view
                                var halfInterval = (uint)interval / 2;
                                await beatBar.ProgressTo(1.0, halfInterval, Easing.Linear);
                                await beatBar.ProgressTo(0.0, halfInterval, Easing.Linear);
                           });
                           Debug.WriteLine("TimerRunning " + interval.ToString());
                       }
                   });

                }
                catch (Exception ex)
                {
                    Debug.WriteLine("EX 1: " + ex.Message);
                }
            }

        }

        private void progressActiveCancle()
        {
            if (cancellationToken != null)
            {
                cancellationToken.Cancel();
            }
            beatBar.Progress = 0;
        }
    }
}