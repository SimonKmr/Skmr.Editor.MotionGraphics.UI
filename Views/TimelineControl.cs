using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Declarative;
using Avalonia.Media;
using Skmr.Editor.MotionGraphics.UI.Views.Timeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skmr.Editor.MotionGraphics.UI.Views
{
    public class TimelineControl : ComponentBase
    {
        public int Start { get; set; } = 0;
        public int Length { get; set; } = 300;
        public int Units { get; set; }
        protected override object Build()
        => new ScrollViewer()
        { 
            Content = new StackPanel()
            {
                Background = new SolidColorBrush()
                {
                    Color = new Color(255, 0x10, 0x10, 0x10)
                },
                Orientation = Avalonia.Layout.Orientation.Vertical,
                Children =
                {
                    new TimelinePanel(new TimelinePanelViewModel("position",Start,Length,300,new int[] { 30, 35, 110, 125, 200, 299 })){Margin = new Thickness(0,2,0,0)},
                    new TimelinePanel(new TimelinePanelViewModel("resolution",Start,Length,300,new int[] { 0,20,60,80 })){Margin = new Thickness(0,2,0,0)},
                    new TimelinePanel(new TimelinePanelViewModel("color",Start,Length,300,new int[] { 5,65 })){Margin = new Thickness(0,2,0,0)},
                },
            }
        };
    }
}
