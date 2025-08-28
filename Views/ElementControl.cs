using Avalonia.Controls;
using Avalonia.Markup.Declarative;
using Avalonia.Media;
using Skmr.Editor.MotionGraphics.UI.ViewModels;

namespace Skmr.Editor.MotionGraphics.UI.Views
{
    internal class ElementControl : ComponentBase<ElementViewModel>
    {
        public ElementControl(ElementViewModel viewModel) : base(viewModel)
        {

        }

        protected override object Build(ElementViewModel? vm)
        {
            var element = vm.Element;

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
                if (p.PropertyType.FullName.Contains("Skmr.Editor.Data.Vec2D"))
                {
                    sp.Children.Add(new Element.Vec2D(p.Name) {x = 1920, y = 1080});
                }
                else if (p.PropertyType.FullName.Contains("Skmr.Editor.Data.Colors.RGBA"))
                {
                    sp.Children.Add(new Element.RGBA() { R = 16, G = 16, B = 16, A = 255 });
                }
                else
                {
                    sp.Children.Add(new Label()
                    {
                        Content = p.Name,
                        FontSize = 10,
                        Foreground = lightGray,
                    });
                }



            }

            return sp;
        }
    }
}
