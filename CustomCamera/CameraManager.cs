using CustomCamera.CameraView;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomCamera
{
    public static class CameraManager
    {
        public static List<Camera> ActiveCameras = new List<Camera>();
        public static void CheckPermission()
        {
        }
        public static void StartPreview()
        {

        }
        public static void StopPreview()
        {

        }
        public static Camera GetCamera()
        { 
            var camera = GetCamera(CameraProjectOptions.CameraType);

            //register the existing camera
            ActiveCameras.Add(camera);

            return camera;
        }
        private static Camera GetCamera(AndroidCameraType cameraType) => cameraType switch
        {
            AndroidCameraType.Camera => new CameraRender(),
            AndroidCameraType.Camera2 => new Camera2Render(),
            AndroidCameraType.CameraX => new CameraXRender(),
            _ => null,
        };

        public static void RemoveCamera(Camera cameraToRemove)
        {
            ActiveCameras.Remove(cameraToRemove);
        }
    }
}
