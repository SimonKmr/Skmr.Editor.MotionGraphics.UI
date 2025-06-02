using Avalonia.Controls;
using Avalonia.Markup.Declarative;
using Avalonia.Media;
using System.Collections.Generic;

namespace Skmr.Editor.MotionGraphics.UI.Views.Timeline
{
    public class TimelinePanel : ComponentBase<TimelinePanelViewModel>
    {
        public TimelinePanel(TimelinePanelViewModel viewModel) : base(viewModel)
        {
        }

        protected override object Build(TimelinePanelViewModel? vm)
        {
            var grid = new Grid()
            {
                ColumnDefinitions = new ColumnDefinitions()
                {
                    new ColumnDefinition(100,GridUnitType.Pixel),
                    new ColumnDefinition(1,GridUnitType.Pixel),
                    new ColumnDefinition(1,GridUnitType.Star),
                }
            };

            var label = new Label()
            {
                Content = @vm.Name,
                FontSize = 12,
            };

            var border = new Border()
            {
                Child = label,
                Background = new SolidColorBrush()
                {
                    Color = new Color(255, 0x05, 0x05, 0x05)
                }
            };

            var track = new Track()
            {
                Background = new SolidColorBrush()
                {
                    Color = new Color(255, 0x05, 0x05, 0x05)
                },
                TotalFrames = @vm.TotalLength,
                Keyframes = @vm.Keyframes,
                Start = @vm.Start,
                Length = @vm.Length,
            };

            grid.Children.Add(border.Col(0));
            grid.Children.Add(track.Col(2));

            return grid;
        }
    }
}
