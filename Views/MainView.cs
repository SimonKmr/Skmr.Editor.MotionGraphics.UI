using Avalonia.Controls;
using Avalonia.Markup.Declarative;
using Avalonia.Media;
using Skmr.Editor.MotionGraphics.UI.ViewModels;
using skmr = Skmr.Editor.MotionGraphics;

namespace Skmr.Editor.MotionGraphics.UI.Views
{
    internal class MainView : ViewBase<MainViewModel>
    {
        public MainView(MainViewModel viewModel) : base(viewModel) { }

        protected override object Build(MainViewModel? vm)
            => new Grid()
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition(250,GridUnitType.Pixel),
                    new ColumnDefinition(1,GridUnitType.Pixel),
                    new ColumnDefinition(450,GridUnitType.Pixel),
                    new ColumnDefinition(1,GridUnitType.Pixel),
                    new ColumnDefinition(1,GridUnitType.Star),
                    new ColumnDefinition(1,GridUnitType.Pixel),
                    new ColumnDefinition(100,GridUnitType.Pixel),
                },

                RowDefinitions =
                {
                    new RowDefinition(40, GridUnitType.Pixel),
                    new RowDefinition(1, GridUnitType.Pixel),
                    new RowDefinition(1, GridUnitType.Star),
                    new RowDefinition(1, GridUnitType.Pixel),
                    new RowDefinition(300, GridUnitType.Pixel),
                },

                Background = new SolidColorBrush(){
                    Color = new Color(255, 0x20, 0x20, 0x20)
                },

                ShowGridLines = false,

                Children =
                {
                    new Panel()
                    {
                        Background = new SolidColorBrush()
                        {
                            Color = new Color(255, 0x10, 0x10, 0x10)
                        },
                    }.Row(0).ColSpan(7),
                    
                    new ElementListControl().Row(2).Col(0),

                    new ElementControl(new ElementViewModel(){Element = new skmr.Elements.Solid() }).Row(2).Col(2),

                    GetPreviewControl(),

                    new Panel()
                    {
                        Background = new SolidColorBrush()
                        {
                            Color = new Color(255, 0x10, 0x10, 0x10)
                        },
                    }.Row(2).Col(6),

                    new TimelineControl()
                    {
                        
                    }.Row(4).ColSpan(7),

                    GetButton()
                }
            };

        private Button GetButton()
        {
            var button = new Button();
            button.Click += (s, e) =>
            {
                previewControl.Update();
            };

            return button;      
        }

        private PreviewControl previewControl;

        private Control GetPreviewControl()
        {
            var grid = new Grid()
            {
                RowDefinitions =
                {
                    new RowDefinition(1,GridUnitType.Star),
                    new RowDefinition(20,GridUnitType.Pixel),

                },

                Children =
                {
                    new PreviewControl()
                }


            }.Row(2).Col(4);
            
            return grid;
        }
    }
}
