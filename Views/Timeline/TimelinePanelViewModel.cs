using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skmr.Editor.MotionGraphics.UI.Views.Timeline
{
    public class TimelinePanelViewModel
    {
        public TimelinePanelViewModel(string name, int length, IEnumerable<int> keyframes)
        {
            Name = name;
            Length = length;
            Keyframes = keyframes;
        }
        public string Name { get; set; } = "name";
        public int Length { get; set; } = 30;
        public IEnumerable<int> Keyframes { get; set; } = new int[] { };
    }
}
