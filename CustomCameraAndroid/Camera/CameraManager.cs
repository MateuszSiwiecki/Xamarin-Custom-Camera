using Android;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Core.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomCameraAndroid.Camera
{
    internal class CameraManager : CustomCameraAndroid.Abstraction.CameraManager
    {
        public Android.Hardware.Camera Camera;

        public override void AddSurfaceReceiver()
        {
            throw new NotImplementedException();
        }

        public override void CloseCamera()
        {
            throw new NotImplementedException();
        }


        public override void OpenCamera()
        {
            throw new NotImplementedException();
        }

        public override void RemoveSurfaceReceiver()
        {
            throw new NotImplementedException();
        }
    }
}