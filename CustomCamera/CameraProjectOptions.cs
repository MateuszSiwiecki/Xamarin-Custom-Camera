using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCamera
{
    public static class CameraProjectOptions
    {
        public static AndroidCameraType CameraType = AndroidCameraType.Camera;
    }
    public enum AndroidCameraType
    {
        Camera,
        Camera2,
        CameraX
    }
}
