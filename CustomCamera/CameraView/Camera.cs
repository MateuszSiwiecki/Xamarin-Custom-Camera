using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomCamera.CameraView
{
    public class Camera : View
    {
        public byte[] Picture { get; set; }
        public bool Flash { get; set; } = false;

        public async Task<byte[]> TakePicture() => await TakePicture(0);
        public async Task<byte[]> TakePicture(int time)
        {
            if (time > 0) await Task.Delay(time);
            return Picture;
        }
    }
}
