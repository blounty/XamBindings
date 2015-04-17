using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Baoyz;
using Android.Content.PM;
using System.Linq;
using Android.Graphics.Drawables;
using Android.Graphics;
using Android.Util;
using System.Collections.Generic;

namespace SwipeMenuListViewSample
{
    [Activity(Label = "Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, ISwipeMenuCreator, SwipeMenuListView.IOnItemClickListener, SwipeMenuListView.IOnSwipeListener
    {
        
        AppAdapter mAdapter;
        //SwipeMenuListView mListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var mListView = FindViewById<SwipeMenuListView>(Resource.Id.SwipeList);
            mAdapter = new AppAdapter(this);
            mListView.Adapter = mAdapter;

            ((SwipeMenuListView)mListView).SetMenuCreator(this);

            //mListView.SetOnMenuItemClickListener((SwipeMenuListView.IOnItemClickListener)this);
            mListView.SetOnSwipeListener(this);

        }

        public void OnItemClick(AdapterView parent, View view, int position, long id)
        {
            ApplicationInfo item = mAdapter.mAppList.ElementAt(position);
            switch (position) {
                case 0:
                    // open
                    //open(item);
                    break;
                case 1:
                    // delete
                    //                  delete(item);
                    //mAppList.remove(position);
                    //Adapter.notifyDataSetChanged();
                    break;
            }
        }

        public void OnSwipeEnd(int p0)
        {
            //throw new NotImplementedException();
        }

        public void OnSwipeStart(int p0)
        {
            //throw new NotImplementedException();
        }

        public void Create(SwipeMenu menu)
        {
            // create "open" item
            SwipeMenuItem openItem = new SwipeMenuItem(
                this);
            // set item background
            openItem.Background = new ColorDrawable(Android.Graphics.Color.Green);
            // set item width
            openItem.Width = dp2px(90);
            // set item title
            openItem.Title = "Open";
            // set item title fontsize
            openItem.TitleSize = 18;
            // set item title font color
            openItem.TitleColor = Color.White.ToArgb();
            // add to menu
            menu.AddMenuItem(openItem);

            // create "delete" item
            SwipeMenuItem deleteItem = new SwipeMenuItem(
                this);
            // set item background
            deleteItem.Background = new ColorDrawable();
            // set item width
            deleteItem.Width = dp2px(90);
            // set a icon
            deleteItem.Icon = new ColorDrawable(Android.Graphics.Color.Red);
            // add to menu
            menu.AddMenuItem(deleteItem);
        }

        private int dp2px(int dp) {
            return (int) TypedValue.ApplyDimension(ComplexUnitType.Dip, dp,
                Resources.DisplayMetrics);
        }
    }

    class AppAdapter : BaseAdapter 
    {
        public List<ApplicationInfo> mAppList;
        Context context;

        public AppAdapter (Context context)
        {
            this.context = context;
            mAppList = context.PackageManager.GetInstalledApplications(0).ToList();
        }

        public override int Count
        {
            get
            {
                return mAppList.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return mAppList.ElementAt(position);
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if (convertView == null) {
                convertView = View.Inflate(context,
                    Resource.Layout.ItemListApp, null);
                var h = new ViewHolder(convertView);
            }
            var holder = (ViewHolder) convertView.Tag;
            var item = (ApplicationInfo)GetItem(position);
            holder.Iv_icon.SetImageDrawable(item.LoadIcon(context.PackageManager));
            holder.Tv_name.Text = item.LoadLabel(context.PackageManager);
            return convertView;
        }
    }


    class ViewHolder : Java.Lang.Object {
        ImageView iv_icon;

        public ImageView Iv_icon
        {
            get
            {
                return iv_icon;
            }
            set
            {
                iv_icon = value;
            }
        }

        TextView tv_name;

        public TextView Tv_name
        {
            get
            {
                return tv_name;
            }
            set
            {
                tv_name = value;
            }
        }

        public ViewHolder(View view) {
            iv_icon = (ImageView) view.FindViewById(Resource.Id.iv_icon);
            tv_name = (TextView) view.FindViewById(Resource.Id.tv_name);
            view.Tag = this;
        }
    }
}


