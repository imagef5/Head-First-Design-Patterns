/*
 * MVC 패턴의 동작 방식을 알아보기 위한 Demo용 코드 입니다.
 * Xamarin 을 이용한 코드를 작성하실 경우 Xamarin 에서 제공 해주는 
 * 강력한 Data Binding 기능 및 MVVM 패턴을 이용 하시면 
 * 더 유연한 코드를 작성 하실 수 있습니다.
 */
using System.Collections.Generic;
using DJView.Interfaces;

namespace DJView.Models
{
    public class BeatModel : IBeatModel
    {
        
        int bpm = 60;
        List<IBMPObserver> observers = new List<IBMPObserver>();

        #region Implement IBPMModel Interface 
        public int BPM 
        { 
            get => bpm; 
            set  
            {
                bpm = value;
                NotifyObservers();
            }
        }

        public void Initialize()
        {
            //On();
        }

        public void On()
        {
            BPM = 60;
        }

        public void Off()
        {
            BPM = 0;
        }

        public void RegisterObserver(IBMPObserver o)
        {
            if(!observers.Contains(o))
            {
                observers.Add(o);
            }
        }


        public void RemoveObserver(IBMPObserver o)
        {
            if(observers.Contains(o))
            {
                observers.Remove(o);
            }
        }

        public void NotifyObservers()
        {
            foreach(var observer in observers)
            {
                observer.UpdateBPM(bpm);
            }
        }

        #endregion
    }
}
