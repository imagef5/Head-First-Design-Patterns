/*
 * MVC 패턴의 동작 방식을 알아보기 위한 Demo용 코드 입니다.
 * Xamarin 을 이용한 코드를 작성하실 경우 Xamarin 에서 제공 해주는 
 * 강력한 Data Binding 기능 및 MVVM 패턴을 이용 하시면 
 * 더 유연한 코드를 작성 하실 수 있습니다.
 */
using System;
using DJView.Controllers;
using DJView.Interfaces;
using Xamarin.Forms;

namespace DJView.Views
{
    public partial class DJControlView : ContentView, IDJControlView, IBMPObserver
    {
        IDJController controller;

        public DJControlView()
        {
            InitializeComponent();
            InitView();
        }

        #region Implement IDJControlView Interface
        public void InitView()
        {
            DisableStopButton();
        }

        public void DisableStartButton()
        {
            startButton.IsEnabled = false;
            stopButton.IsEnabled = true;
        }

        public void DisableStopButton()
        {
            startButton.IsEnabled = true;
            stopButton.IsEnabled = false;
        }

        public void SetController(IDJController controller)
        {
            this.controller = controller;
        }
        #endregion

        #region Implement IBPMObserver Interface
        public void UpdateBPM(int bpm)
        {
            bpmEntry.Text = bpm.ToString();
        }
        #endregion

        #region Button Client event
        public void start_Clicked(object sender, EventArgs e)
        {
            controller.Start();
        }

        public void stop_Clicked(object sender, EventArgs e)
        {
            controller.Stop();
        }

        public void decrease_Clicked(object sender, EventArgs e)
        {
            controller.DecreaseBPM();
        }

        public void increase_Clicked(object sender, EventArgs e)
        {
            controller.IncreaseBPM();
        }

        public void set_Clicked(object sender, EventArgs e)
        {
            var val = string.IsNullOrEmpty(bpmEntry.Text) ? "0" : bpmEntry.Text.Trim();

            if (int.TryParse(val, out int i))
            {
                controller.UpdateBPM(i);
            }
        }
        #endregion
    }
}
