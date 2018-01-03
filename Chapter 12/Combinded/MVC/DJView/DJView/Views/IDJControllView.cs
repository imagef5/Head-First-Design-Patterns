using DJView.Controllers;
namespace DJView.Views
{
    public interface IDJControlView
    {
        void InitView();
        void DisableStartButton();
        void DisableStopButton();
        void SetController(IDJController controller);
    }
}
