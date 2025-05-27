using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Controls;
using Avalonia.Themes.Fluent;
using Skmr.Editor.MotionGraphics.UI.Views;

namespace Skmr.Editor.MotionGraphics.UI
{
    internal sealed class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args)
        {
            var lifetime = new ClassicDesktopStyleApplicationLifetime { Args = args, ShutdownMode = ShutdownMode.OnLastWindowClose };

            var appBuilder = AppBuilder.Configure<Application>()
                .UsePlatformDetect()
                .AfterSetup(b => b.Instance?.Styles.Add(new FluentTheme()))
                .SetupWithLifetime(lifetime);

            //var menu = new NativeMenu()
            //{
            //    Items = 
            //    { 
            //        new NativeMenuItem()
            //        {
            //            Header = "File",
            //            Menu = {
            //                new NativeMenuItem()
            //                {
            //                    Header = "New",
            //                },
            //                new NativeMenuItem()
            //                {
            //                    Header = "Save",
            //                },
            //                new NativeMenuItem()
            //                {
            //                    Header = "Load",
            //                }
            //            }
            //        } 
            //    }
            //};

            var mainViewModel = new ViewModels.MainViewModel();

            lifetime.MainWindow = new Window()
            {
                Title = "Motion Graphics",
                Content = new MainView(mainViewModel),

            };


            lifetime.Start(args);
        }  
    }
}
