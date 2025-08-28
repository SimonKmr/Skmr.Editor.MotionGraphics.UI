using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Controls;
using Avalonia.Markup.Declarative;
using Avalonia.Media;
using Grid = Avalonia.Controls.Grid;
using System.Security.Cryptography.X509Certificates;

namespace Skmr.Editor.MotionGraphics.UI.Views.Element
{
    public class RGBA : ComponentBase
    {
        public string Name { get; set; } = "RGBA";
        public string HexCode { get; set; } = "#101010FF";
        public byte R { get; set; } = 16;
        public byte G { get; set; } = 16;
        public byte B { get; set; } = 16;
        public byte A { get; set; } = 255;

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
                    new ColumnDefinition(2,GridUnitType.Pixel),
                    new ColumnDefinition(1,GridUnitType.Auto),
                    new ColumnDefinition(2,GridUnitType.Pixel),
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
                        Text = HexCode.ToString(),
                        FontSize = 10,
                    }.Col(3).Row(1),
                    new TextBox()
                    {
                        Text = R.ToString(),
                        FontSize = 10,
                    }.Col(5).Row(1),
                    new TextBox()
                    {
                        Text = G.ToString(),
                        FontSize = 10,
                    }.Col(7).Row(1),
                    new TextBox()
                    {
                        Text = B.ToString(),
                        FontSize = 10,
                    }.Col(9).Row(1),
                    new TextBox()
                    {
                        Text = A.ToString(),
                        FontSize = 10,
                    }.Col(11).Row(1),

                },
            };

        }
    }
}
