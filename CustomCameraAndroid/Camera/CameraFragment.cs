using System;
using System.Collections.Generic;
using Dg = System.Diagnostics.Debug;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Android.OS;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;

namespace CustomCameraAndroid.Camera
{
    public class CameraFragment : Fragment, TextureView.ISurfaceTextureListener
    {

        public AutoFitTextureView bottomLayer;
        public AutoFitTextureView upperLayer;
        public ImageView textureView3;

        public volatile byte[] scannedImage;
        private volatile bool processingFirst = false;
        private volatile bool processingSecond = false;
        public SurfaceTexture surface;
        public int height = 0;
        public int width = 0;

        #region Constructors

        public CameraFragment()
        {
        }

        public CameraFragment(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        #endregion

        #region Overrides

        public override Android.Views.View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) =>
            inflater.Inflate(CustomCameraAndroid.Resource.Layout.CameraFragment, null);

        public override void OnViewCreated(Android.Views.View view, Bundle savedInstanceState)
        {
            bottomLayer = view.FindViewById<AutoFitTextureView>(CustomCameraAndroid.Resource.Id.cameratexture1);
            upperLayer = view.FindViewById<AutoFitTextureView>(CustomCameraAndroid.Resource.Id.cameratexture2);
            bottomLayer.SetOpaque(false);
            upperLayer.SetOpaque(false);

            bottomLayer.SurfaceTextureListener = this;
        }
        public override void OnPause()
        {
            Dg.WriteLine("OnPause START");
            try
            {

            }
            catch (Exception e)
            {

            }
            base.OnPause();
            Dg.WriteLine("OnPause END");
        }

        public override async void OnResume()
        {
            Dg.WriteLine("On resume START");
            base.OnResume();

            try
            {
                if(surface != null)
                {

                }
            }
            catch (Exception e)
            {

            }
            Dg.WriteLine("On resume END");
        }

        protected override void Dispose(bool disposing)
        {
            Dg.WriteLine("Dispose START");

            try
            {
                bottomLayer?.Dispose();
                upperLayer?.Dispose();
            }
            catch (Exception e)
            {

            }
            base.Dispose(disposing);
            Dg.WriteLine("Dispose END");
        }

        #endregion

        #region TextureView.ISurfaceTextureListener

        async void TextureView.ISurfaceTextureListener.OnSurfaceTextureAvailable(SurfaceTexture surface, int width, int height)
        {
            this.surface = surface;

            this.width = width;
            this.height = height;

            bottomLayer.LayoutParameters = new Android.Widget.FrameLayout.LayoutParams(width, (int)(height));
            upperLayer.LayoutParameters = new Android.Widget.FrameLayout.LayoutParams(width, (int)(height));
        }

        bool TextureView.ISurfaceTextureListener.OnSurfaceTextureDestroyed(SurfaceTexture surface)
        {
            return true;
        }

        void TextureView.ISurfaceTextureListener.OnSurfaceTextureSizeChanged(SurfaceTexture surface, int width, int height)
        { }

        void TextureView.ISurfaceTextureListener.OnSurfaceTextureUpdated(SurfaceTexture surface)
        {
        }

        #endregion
    }
}