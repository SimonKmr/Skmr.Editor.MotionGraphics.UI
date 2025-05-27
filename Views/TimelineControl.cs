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
        public int Units { get; set; }
        protected override object Build()
        => new StackPanel()
        {
            Background = new SolidColorBrush()
            {
                Color = new Color(255, 0x10, 0x10, 0x10)
            },
            Orientation = Avalonia.Layout.Orientation.Vertical,
            Children =
            {
                new Track()
                {
                    Height = 13,
                    Background = new SolidColorBrush()
                    {
                        Color = new Color(255, 0x05, 0x05, 0x05)
                    },
                    Margin = new Thickness(0,2,0,0),
                    Children = new int[]{ 20, 40, }
                },
                new Track()
                {
                    Height = 13,
                    Background = new SolidColorBrush()
                    {
                        Color = new Color(255, 0x05, 0x05, 0x05)
                    },
                    Margin = new Thickness(0,2,0,0),
                    Children = new int[]{ 100, 160, }
                },
                new Track()
                {
                    Height = 13,
                    Background = new SolidColorBrush()
                    {
                        Color = new Color(255, 0x05, 0x05, 0x05)
                    },
                    Margin = new Thickness(0,2,0,0),
                    Children = new int[]{ 240, 300, }
                },
                new Track()
                {
                    Height = 13,
                    Background = new SolidColorBrush()
                    {
                        Color = new Color(255, 0x05, 0x05, 0x05)
                    },
                    Margin = new Thickness(0,2,0,0),
                    Children = new int[]{ 23, 43, }
                },
            }
        };
    }
}
