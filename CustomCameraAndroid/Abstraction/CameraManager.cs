using Android;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Core.App;
using AndroidX.Core.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CustomCameraAndroid.Abstraction
{
    internal abstract class CameraManager
    {
        public static readonly int REQUEST_CAMERA_PERMISSION = 1;
        public Context MainContext => Android.App.Application.Context;

        public CameraManager()
        {
            GetCameraPermission();
        }

        public bool GetCameraPermission()
        {
            if (ContextCompat.CheckSelfPermission(MainContext, Manifest.Permission.Camera) == (int)Permission.Granted)
            {
                return true;
            }
            else
            {
                ActivityCompat.RequestPermissions((Activity)MainContext, new String[] { Manifest.Permission.Camera }, REQUEST_CAMERA_PERMISSION);
                return false;
            }

        }
        public abstract void OpenCamera();
        public abstract void CloseCamera();
        public abstract void AddSurfaceReceiver();
        public abstract void RemoveSurfaceReceiver();
    }
}