using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Skmr.Editor.MotionGraphics.UI.Views.Timeline
{
    public class Track : Control
    {
        //https://docs.avaloniaui.net/docs/guides/custom-controls/draw-with-a-property
        public new IEnumerable<int> Keyframes { get; set; } = new int[0];
        public int Length { get; set; } = 300;
        public int FramesPerSecond { get; set; } = 30;
        public IBrush? Background { get; set; }

        public sealed override void Render(DrawingContext context)
        {
            context.FillRectangle(Background, new Rect(Bounds.Size));

            DrawKeyframes(context);

            DrawFrameMarkers(context);

            base.Render(context);
        }

        private void DrawFrameMarkers(DrawingContext context)
        {
            
            var w = Bounds.Width;
            var h = Bounds.Height;
            var u = w / Length;
            var xOffset = u / 2;
            
            for (var i = 0; i < Length ; i++)
            {
                var x = u * i + xOffset;
                var p1 = new Point(x, 0);
                
                IPen brush;
                Point p2;

                if (i % FramesPerSecond == 0)
                {
                    brush = new Pen(new SolidColorBrush(new Color(100, 255, 255, 255)));
                    p2 = new Point(x, h / 3);
                }
                else
                {
                    brush = new Pen(new SolidColorBrush(new Color(50, 255, 255, 255)));
                    p2 = new Point(x, h / 8);
                }

                context.DrawLine(brush, p1, p2);
            }
        }

        private void DrawKeyframes(DrawingContext context)
        {
            IBrush brush = new SolidColorBrush(new Color(255, 100, 100, 200));
            var w = Bounds.Width;
            var h = Bounds.Height;
            var u = w / Length;

            var children = Keyframes.ToArray();
            var r = u / 2;
            for (int i = 0; i < children.Length; i++)
            {
                var x = u * (double)children[i];
                var rect = new Rect(x, 3, u, h-3);
                var p = new Point(x + r, h / 2);
                context.DrawEllipse(brush, null, p, r , u / 2);
            }
        }
    }
}
