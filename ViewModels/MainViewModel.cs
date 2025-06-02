using Skmr.Editor.MotionGraphics.Sequences;

namespace Skmr.Editor.MotionGraphics.UI.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        public int CurrentFrame { get; set; }
        public Sequence Sequence { get; private set; }
        
        public MainViewModel()
        {
            Sequence = new Sequence(1920, 1080);
        }

        public void New()
        {
            Sequence = new Sequence(1920, 1080);
        }

        public void Save()
        {

        }
    }
}
