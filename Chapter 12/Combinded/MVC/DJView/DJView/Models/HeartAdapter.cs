﻿/*
 * MVC 패턴의 동작 방식을 알아보기 위한 Demo용 코드 입니다.
 * Xamarin 을 이용한 코드를 작성하실 경우 Xamarin 에서 제공 해주는 
 * 강력한 Data Binding 기능 및 MVVM 패턴을 이용 하시면 
 * 더 유연한 코드를 작성 하실 수 있습니다.
 */
using DJView.Interfaces;

namespace DJView.Models
{
    public class HeartAdapter : IBeatModel
    {
        IHeartModel heart;

        public HeartAdapter(IHeartModel heart)
        {
            this.heart = heart;
        }

        #region Implement IBeatModel Interface
        public int BPM 
        {
            get => heart.HeartRate; 
            set 
            {
                
            }  
        }

        public void Initialize()
        {
            
        }

        public void On()
        {

        }

        public void Off()
        {

        }

        public void RegisterObserver(IBMPObserver o)
        {
            heart.RegisterObserver(o);
        }

        public void RemoveObserver(IBMPObserver o)
        {
            heart.RemoveObserver(o);
        }

        public void NotifyObservers()
        {
            heart.NotifyObservers();
        }

        #endregion
    }
}
