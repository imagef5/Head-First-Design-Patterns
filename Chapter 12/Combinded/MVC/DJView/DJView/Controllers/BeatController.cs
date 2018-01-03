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
    public class BeatController : IBeatController
    {
        IBeatView beatView;
        IBeatModel bpmModel;

        public BeatController(IBeatView beatView, IBeatModel bpmModel)
        {
            this.beatView = beatView;
            this.bpmModel = bpmModel;
            beatView.SetController(this);
            bpmModel.RegisterObserver((IBMPObserver)beatView);
        }

        public void UpdateBeat(int beat)
        {
            if (beat > 0)
            {
                bpmModel.BPM = beat;
            }
        }
    }
}
