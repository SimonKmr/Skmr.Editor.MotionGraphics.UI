using SDL3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SDL3.SDL;

namespace Skmr.Editor.MotionGraphics.UI.Views.Preview
{
    //Creates a Window with SDL
    internal class PixelBuffer
    {
        private nint renderer;
        private nint window;
        private int width;
        private int height;
        private Rect rect;
        private nint texture;

        public PixelBuffer(nint window, nint renderer, int width, int height)
        {
            this.window = window;
            this.renderer = renderer;
            this.width = width;
            this.height = height;

            Resize(width, height);
        }
        
        public void Resize(int width, int height)
        {
            texture = SDL.CreateTexture(renderer, SDL.PixelFormat.RGBX8888, SDL.TextureAccess.Streaming, width, height);
            var error = SDL.GetError();
            rect = new SDL.Rect();
            rect.X = 0;
            rect.Y = 0;
            rect.W = width;
            rect.H = height;
        }

        public void Update(byte[] pixel)
        {
            SDL.LockTexture(texture, rect, out var pixels, out var pitch);

            unsafe
            {
                var buffer = (byte*)pixels.ToPointer();
                for (int i = 0; i < width * height * 4; i++)
                {
                    *(buffer + i) = pixel[i];
                }
            }

            SDL.UnlockTexture(texture);
        }

        public void Render()
        {
            SDL.RenderTexture(renderer, texture, nint.Zero, nint.Zero);
        }
    }
}
