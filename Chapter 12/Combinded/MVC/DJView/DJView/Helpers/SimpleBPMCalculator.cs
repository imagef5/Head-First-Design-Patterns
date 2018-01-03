/*
 * MVC 패턴의 동작 방식을 알아보기 위한 Demo용 코드 입니다.
 * Xamarin 을 이용한 코드를 작성하실 경우 Xamarin 에서 제공 해주는 
 * 강력한 Data Binding 기능 및 MVVM 패턴을 이용 하시면 
 * 더 유연한 코드를 작성 하실 수 있습니다.
 * 
 * Music BPM 계산기와 무관함 
 * 단순 데모용 
 */
using System;
namespace DJView.Helpers
{
    public static class SimpleBPMCalculator
    {
        static readonly int tempo = 4;
        static readonly double beats = 60.0;

        public static double GetMiliSeconds(int bpm)
        {
            double val = 0;

            if(bpm > 0)
            {
                val = beats / bpm * 1000;
            }

            return val;
        }
    }
}
