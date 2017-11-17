using Android.App;
using Android.Widget;
using Android.OS;

using Accord.Imaging;
using Android.Graphics;
using System.Collections.Generic;
using Android.Graphics.Drawables;
using System.IO;
using System;
using System.Threading.Tasks;

namespace RoadDetect
{
    [Activity(Label = "RoadDetect", MainLauncher = true)]
    public class MainActivity : Activity
    {
        TextView tvResult;
        ImageView ivSource;
        Button btnTranslate;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            init();


            ivSource.BuildDrawingCache(true);
            Bitmap bmap = ivSource.GetDrawingCache(true);
            ivSource.SetImageBitmap(bmap);
            Bitmap b = Bitmap.CreateBitmap(ivSource.GetDrawingCache(true));


            ////Bitmap bitmap = BitmapFactory.DecodeByteArray(Resource.Drawable.test);
            //UnmanagedImage unmanagedImage = UnmanagedImage.FromManagedImage(result);


            //var hog = new HistogramsOfOrientedGradients(numberOfBins: 9, blockSize: 3, cellSize: 6);
            //List<double[]> descriptors = hog.ProcessImage(bitmap);
        }

        private void init()
        {
            ivSource = FindViewById<ImageView>(Resource.Id.ivSource);
            ivSource.SetImageResource(Resource.Drawable.test);
        }
    }
}

