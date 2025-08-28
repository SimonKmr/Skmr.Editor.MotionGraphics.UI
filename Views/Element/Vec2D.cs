using Avalonia.Controls;
using Avalonia.Markup.Declarative;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skmr.Editor.MotionGraphics.UI.Views.Element
{
    public class Vec2D : ComponentBase
    {
        public Vec2D(string name)
        {
            Name = name;
        }

        public string Name { get; set; } = "Vec2D";
        public float x { get; set; } = 0;
        public float y { get; set; } = 0;

        protected override object Build()
        {
            var lightGray = new SolidColorBrush()
            {
                Color = new Color(255, 0xC0, 0xC0, 0xC0)
            };

            return new Grid()
            {
                RowDefinitions = new RowDefinitions()
                {
                    new RowDefinition(1,GridUnitType.Pixel),
                    new RowDefinition(1,GridUnitType.Auto),
                    new RowDefinition(1,GridUnitType.Pixel),
                },
                
                ColumnDefinitions = new ColumnDefinitions()
                {
                    new ColumnDefinition(1,GridUnitType.Pixel),
                    new ColumnDefinition(1,GridUnitType.Auto),
                    new ColumnDefinition(1,GridUnitType.Star),
                    new ColumnDefinition(1,GridUnitType.Auto),
                    new ColumnDefinition(2,GridUnitType.Pixel),
                    new ColumnDefinition(1,GridUnitType.Auto),
                    new ColumnDefinition(1,GridUnitType.Pixel),
                },
                
                Children =
                {
                    new Label()
                    {
                        Content = Name,
                        FontSize = 10,
                        Foreground = lightGray,
                        VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
                    }.Col(1).Row(1),
                    new TextBox()
                    {
                        Text = x.ToString(),
                        FontSize = 10,
                    }.Col(3).Row(1),
                    new TextBox()
                    {
                        Text = y.ToString(),
                        FontSize = 10,
                    }.Col(5).Row(1),
                },
            };
        }
    }
}
