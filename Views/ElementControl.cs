using Avalonia.Controls;
using Avalonia.Markup.Declarative;
using Avalonia.Media;
using Skmr.Editor.MotionGraphics.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skmr.Editor.MotionGraphics.UI.Views
{
    internal class ElementControl : ComponentBase
    {
        private IElement element;
        public ElementControl(IElement element)
        {
            this.element = element;
        }
        protected override void OnCreated()
        {
            this.element = new Gradient();
            base.OnCreated();
        }

        protected override object Build()
        {
            var background = new SolidColorBrush()
            {
                Color = new Color(255, 0x10, 0x10, 0x10)
            };

            var lightGray = new SolidColorBrush()
            {
                Color = new Color(255, 0xC0, 0xC0, 0xC0)
            };

            var sp = new StackPanel()
            {
                Background = background
            };
            var name = element.GetType().Name;
            var properties = element.GetType().GetProperties();
            
            sp.Children.Add(new Label()
            {
                Content = name,
                FontSize = 12,
            });

            foreach (var p in properties)
            {
                sp.Children.Add(new Label()
                {
                    Content = p.Name,
                    FontSize = 10,
                    Foreground = lightGray,
                });
            }

            return sp;
            
        }
    }
}
