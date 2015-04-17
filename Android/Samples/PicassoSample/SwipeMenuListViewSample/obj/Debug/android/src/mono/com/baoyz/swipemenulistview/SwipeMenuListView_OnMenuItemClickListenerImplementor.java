package mono.com.baoyz.swipemenulistview;


public class SwipeMenuListView_OnMenuItemClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baoyz.swipemenulistview.SwipeMenuListView.OnMenuItemClickListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMenuItemClick:(ILcom/baoyz/swipemenulistview/SwipeMenu;I)Z:GetOnMenuItemClick_ILcom_baoyz_swipemenulistview_SwipeMenu_IHandler:Baoyz.SwipeMenuListView/IOnMenuItemClickListenerInvoker, SwipeMenuListView\n" +
			"";
		mono.android.Runtime.register ("Baoyz.SwipeMenuListView/IOnMenuItemClickListenerImplementor, SwipeMenuListView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SwipeMenuListView_OnMenuItemClickListenerImplementor.class, __md_methods);
	}


	public SwipeMenuListView_OnMenuItemClickListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SwipeMenuListView_OnMenuItemClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Baoyz.SwipeMenuListView/IOnMenuItemClickListenerImplementor, SwipeMenuListView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onMenuItemClick (int p0, com.baoyz.swipemenulistview.SwipeMenu p1, int p2)
	{
		return n_onMenuItemClick (p0, p1, p2);
	}

	private native boolean n_onMenuItemClick (int p0, com.baoyz.swipemenulistview.SwipeMenu p1, int p2);

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
