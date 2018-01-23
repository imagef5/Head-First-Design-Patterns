/* MVC 패턴의 동작 방식을 알아보기 위한 Demo용 코드 입니다.
 * Xamarin 을 이용한 코드를 작성하실 경우 Xamarin 에서 제공 해주는 
 * 강력한 Data Binding 기능 및 MVVM 패턴을 이용 하시면
 * 더 유연한 코드를 작성 하실 수 있습니다.
 */
using DJView.Controllers;
using DJView.Models;
using Xamarin.Forms;

namespace DJView
{
    public partial class HeartBeatViewPage : ContentPage
    {
        public HeartBeatViewPage()
        {
            InitializeComponent();

            #region For HeartAdapter Test
            IHeartModel heartModel = new HeartModel();
            IBeatModel beatModel = new HeartAdapter(heartModel);
            IDJController btmController = new DJController(djView, beatModel);
            IBeatController heartController = new HeartController(beatView, beatModel);
            #endregion
        }
    }
}
