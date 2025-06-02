using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skmr.Editor.MotionGraphics.UI.Views.Timeline
{
    public class TimelinePanelViewModel
    {
        public string Name { get; set; } = "name";
        public int TotalLength { get; set; } = 30;
        public IEnumerable<int> Keyframes { get; set; } = new int[] { };

        public int Start { get; set; } = 0;
        public int Length { get; set; } = 300;

        public TimelinePanelViewModel(string name, int start, int length, int totalLength, IEnumerable<int> keyframes)
        {
            Name = name;
            TotalLength = totalLength;
            Keyframes = keyframes;
            
            Start = start;
            Length = length;
        }

    }
}
