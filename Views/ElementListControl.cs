using Avalonia.Controls;
using Avalonia.Markup.Declarative;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Skmr.Editor.MotionGraphics.Elements;
using Avalonia.Media;
using Avalonia;

namespace Skmr.Editor.MotionGraphics.UI.Views
{
    internal class ElementListControl : ComponentBase
    {
        protected override object Build()
        {
            var ns = "Skmr.Editor.MotionGraphics.Elements";
            var assembly = typeof(IElement);
            var types = Assembly.GetAssembly(assembly).GetTypes()
                .Where( t => t.IsClass && t.GetInterfaces()
                .Contains(typeof(IElement)))
                .ToArray();

            var stackPanel = new StackPanel();

            foreach(var t in types)
            {
                stackPanel.Children.Add(new Label()
                {
                    FontSize = 12,
                    Content = t.Name,
                    Margin = new Thickness(5,5,5,0),
                    Background = new SolidColorBrush()
                    {
                        Color = new Color(255, 0x20, 0x20, 0x20)
                    },
                    CornerRadius = new CornerRadius(2),
                });
            }

            return new ScrollViewer()
            {
                Background = new SolidColorBrush()
                {
                    Color = new Color(255, 0x10, 0x10, 0x10)
                },
                Content = stackPanel,
            };
        }
    }
}
