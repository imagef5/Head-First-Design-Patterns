/*
 * MVC 패턴의 동작 방식을 알아보기 위한 Demo용 코드 입니다.
 * Xamarin 을 이용한 코드를 작성하실 경우 Xamarin 에서 제공 해주는 
 * 강력한 Data Binding 기능 및 MVVM 패턴을 이용 하시면 
 * 더 유연한 코드를 작성 하실 수 있습니다.
 */
using DJView.Interfaces;
using DJView.Models;
using DJView.Views;

namespace DJView.Controllers
{
    public class DJController : IDJController
    {
        IDJControlView controlView;
        IBeatModel bpmModel;

        public DJController(IDJControlView controlView,IBeatModel bpmModel)
        {
            this.controlView = controlView;
            this.bpmModel = bpmModel;
            controlView.SetController(this);
            bpmModel.RegisterObserver((IBMPObserver)controlView);
        }

        #region Implement IBPMController Interface
        public void Start()
        {
            bpmModel.On();
            controlView.DisableStartButton();
        }

        public void Stop()
        {
            bpmModel.Off();
            controlView.DisableStopButton();
        }

        public void DecreaseBPM()
        {
            if (bpmModel.BPM > 0)
            {
                bpmModel.BPM--;
            }
            else
            {
                controlView.DisableStopButton();
            }
        }

        public void IncreaseBPM()
        {
            bpmModel.BPM++;
            controlView.DisableStartButton();
        }

        public void UpdateBPM(int bpm)
        {
            if(bpm > 0)
            {
                bpmModel.BPM = bpm;
            }
        }
        #endregion
    }
}
