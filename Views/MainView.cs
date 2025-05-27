using Avalonia.Controls;
using Avalonia.Markup.Declarative;
using Avalonia.Media;
using Skmr.Editor.MotionGraphics.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    
                    new Panel()
                    {

                        Background = new SolidColorBrush()
                        {
                            Color = new Color(255, 0x10, 0x10, 0x10)
                        },
                    }.Row(2).Col(0),

                    new Panel()
                    {

                        Background = new SolidColorBrush()
                        {
                            Color = new Color(255, 0x10, 0x10, 0x10)
                        },
                    }.Row(2).Col(2),

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

        private PreviewControl GetPreviewControl()
        {
            var pc = new PreviewControl()
            {

            }.Row(2).Col(4);
            
            pc.KeyDown += (sender, e) =>
            {
                var s = sender as PreviewControl;
                s.Update();
            };
            
            previewControl = pc;
            return pc;
        }
    }
}
