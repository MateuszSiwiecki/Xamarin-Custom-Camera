using Android.App;
using Android.Content;
using Android.Hardware.Camera2;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomCameraAndroid.Camera2
{
    public class CameraManager : CustomCameraAndroid.Abstraction.CameraManager
    {
        public CameraDevice cameraDevice;
        public CameraCaptureSession previewSession;
        public MediaRecorder mediaRecorder;

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