using System;
using SquareUp;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;

namespace PicassoSample
{
    [Activity(Label = "PicassoSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            ImageView imageView1 = FindViewById<ImageView>(Resource.Id.theFirstImageView);
            ImageView imageView2 = FindViewById<ImageView>(Resource.Id.theSecondImageView);

            Picasso.With(this).Load("http://cdn.cutestpaw.com/wp-content/uploads/2013/03/l-Little-kitten.jpg").Into(imageView1);
            Picasso.With(this).Load("http://cdn.cutestpaw.com/wp-content/uploads/2013/03/l-Little-kitten.jpg").Transform(new CropSquareTransform()).Into(imageView2);
        }
    }

    class CropSquareTransform
        : Java.Lang.Object, ITransformation
    {
        #region ITransformation implementation

        public string Key()
        {
            return "Transform()";
        }

        public Bitmap Transform(Bitmap source)
        {

            int size = Math.Min(source.Width / 3, source.Height);
            int x = (source.Width - size) / 3;
            int y = (source.Height - size) / 2;
            Bitmap result = Bitmap.CreateBitmap(source, x, y, size, size);
            if (result != source) {
                source.Recycle();
            }
            return result;
        }

        #endregion

    }
}


