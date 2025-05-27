using Avalonia.Controls;
using SDL3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skmr.Editor.MotionGraphics.UI.Views.Preview
{
    public class SdlLayer : IDisposable
    {
        private bool isResizeable = true;

        public int Width { get; set; }
        public int Height { get; set; }

        private nint renderer;
        private readonly nint window;

        private readonly PixelBuffer pixelBuffer;

        public SdlLayer(nint handle)
        {
            uint prop = SDL.CreateProperties();
            SDL.SetPointerProperty(prop, SDL.Props.WindowCreateWin32HWNDPointer, handle);
            window = SDL.CreateWindowWithProperties(prop);
            renderer = SDL.CreateRenderer(window, null);
            
            SDL.SetWindowFullscreen(window, true);
            SDL.SetRenderDrawColor(renderer, 0, 255, 0, 255);
            SDL.RenderClear(renderer);
            
            pixelBuffer = new PixelBuffer(window, renderer,1920,1080);
        }

        public void InitRenderer()
        {
            
            
        }

        public void Dispose()
        {
            SDL.DestroyRenderer(renderer);
            SDL.DestroyWindow(window);
        }

        public void Update(byte[] bytes,int width, int height)
        {
            pixelBuffer.Resize(width,height);
            pixelBuffer.Update(bytes);
        }

        public void Render()
        {
            
            pixelBuffer.Render();
            SDL.RenderPresent(renderer);
        }
    }
}
