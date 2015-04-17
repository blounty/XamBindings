package mono.com.baoyz.swipemenulistview;


public class SwipeMenuView_OnSwipeItemClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baoyz.swipemenulistview.SwipeMenuView.OnSwipeItemClickListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onItemClick:(Lcom/baoyz/swipemenulistview/SwipeMenuView;Lcom/baoyz/swipemenulistview/SwipeMenu;I)V:GetOnItemClick_Lcom_baoyz_swipemenulistview_SwipeMenuView_Lcom_baoyz_swipemenulistview_SwipeMenu_IHandler:Baoyz.SwipeMenuView/IOnSwipeItemClickListenerInvoker, SwipeMenuListView\n" +
			"";
		mono.android.Runtime.register ("Baoyz.SwipeMenuView/IOnSwipeItemClickListenerImplementor, SwipeMenuListView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SwipeMenuView_OnSwipeItemClickListenerImplementor.class, __md_methods);
	}


	public SwipeMenuView_OnSwipeItemClickListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SwipeMenuView_OnSwipeItemClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Baoyz.SwipeMenuView/IOnSwipeItemClickListenerImplementor, SwipeMenuListView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onItemClick (com.baoyz.swipemenulistview.SwipeMenuView p0, com.baoyz.swipemenulistview.SwipeMenu p1, int p2)
	{
		n_onItemClick (p0, p1, p2);
	}

	private native void n_onItemClick (com.baoyz.swipemenulistview.SwipeMenuView p0, com.baoyz.swipemenulistview.SwipeMenu p1, int p2);

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
