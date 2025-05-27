using Avalonia;
using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skmr.Editor.MotionGraphics.UI.Views.Timeline
{
    internal class TimelinePanel : Panel
    {
        public int Tracks { get; set; }
        public int Length { get; set; }

        public new IEnumerable<Track> Children { get; set; }

        protected override Size ArrangeOverride(Size finalSize)
        {
            return base.ArrangeOverride(finalSize);
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            return base.MeasureOverride(availableSize);
        }
    }
}
