package swipemenulistviewsample;


public class MainActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		com.baoyz.swipemenulistview.SwipeMenuCreator,
		android.widget.AdapterView.OnItemClickListener,
		com.baoyz.swipemenulistview.SwipeMenuListView.OnSwipeListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_create:(Lcom/baoyz/swipemenulistview/SwipeMenu;)V:GetCreate_Lcom_baoyz_swipemenulistview_SwipeMenu_Handler:Baoyz.ISwipeMenuCreatorInvoker, SwipeMenuListView\n" +
			"n_onItemClick:(Landroid/widget/AdapterView;Landroid/view/View;IJ)V:GetOnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJHandler:Android.Widget.AdapterView/IOnItemClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onSwipeEnd:(I)V:GetOnSwipeEnd_IHandler:Baoyz.SwipeMenuListView/IOnSwipeListenerInvoker, SwipeMenuListView\n" +
			"n_onSwipeStart:(I)V:GetOnSwipeStart_IHandler:Baoyz.SwipeMenuListView/IOnSwipeListenerInvoker, SwipeMenuListView\n" +
			"";
		mono.android.Runtime.register ("SwipeMenuListViewSample.MainActivity, SwipeMenuListViewSample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity.class, __md_methods);
	}


	public MainActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("SwipeMenuListViewSample.MainActivity, SwipeMenuListViewSample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void create (com.baoyz.swipemenulistview.SwipeMenu p0)
	{
		n_create (p0);
	}

	private native void n_create (com.baoyz.swipemenulistview.SwipeMenu p0);


	public void onItemClick (android.widget.AdapterView p0, android.view.View p1, int p2, long p3)
	{
		n_onItemClick (p0, p1, p2, p3);
	}

	private native void n_onItemClick (android.widget.AdapterView p0, android.view.View p1, int p2, long p3);


	public void onSwipeEnd (int p0)
	{
		n_onSwipeEnd (p0);
	}

	private native void n_onSwipeEnd (int p0);


	public void onSwipeStart (int p0)
	{
		n_onSwipeStart (p0);
	}

	private native void n_onSwipeStart (int p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
