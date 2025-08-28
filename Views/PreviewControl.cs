using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform;
using Skmr.Editor.MotionGraphics.UI.Views.Preview;
using System;

namespace Skmr.Editor.MotionGraphics.UI.Views
{
    internal class PreviewControl : NativeControlHost
    {
        private SdlLayer window;
        protected override IPlatformHandle CreateNativeControlCore(IPlatformHandle parent)
        {
            var handle = base.CreateNativeControlCore(parent);
            window = new SdlLayer(handle.Handle);
            window.Render();

            return handle;
        }

        public void Update()
        {
            Random r = new Random();
            byte[] bytes = new byte[1920 * 1080 * 4];
            r.NextBytes(bytes);
            var w = Width;
            for (int i = 0; i < bytes.Length; i+=4)
            {
                bytes[i + 0] = (byte)(255);
                bytes[i + 1] = (byte)(0); //B
                bytes[i + 2] = (byte)(0); //G
                bytes[i + 3] = (byte)(255); //R
            }
            window.Update(bytes, 1920, 1080);
            window.Render();
        }
    }
}
