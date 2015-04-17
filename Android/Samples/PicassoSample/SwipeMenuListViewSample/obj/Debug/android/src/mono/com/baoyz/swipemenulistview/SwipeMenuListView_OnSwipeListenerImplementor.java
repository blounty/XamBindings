package mono.com.baoyz.swipemenulistview;


public class SwipeMenuListView_OnSwipeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baoyz.swipemenulistview.SwipeMenuListView.OnSwipeListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onSwipeEnd:(I)V:GetOnSwipeEnd_IHandler:Baoyz.SwipeMenuListView/IOnSwipeListenerInvoker, SwipeMenuListView\n" +
			"n_onSwipeStart:(I)V:GetOnSwipeStart_IHandler:Baoyz.SwipeMenuListView/IOnSwipeListenerInvoker, SwipeMenuListView\n" +
			"";
		mono.android.Runtime.register ("Baoyz.SwipeMenuListView/IOnSwipeListenerImplementor, SwipeMenuListView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SwipeMenuListView_OnSwipeListenerImplementor.class, __md_methods);
	}


	public SwipeMenuListView_OnSwipeListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SwipeMenuListView_OnSwipeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Baoyz.SwipeMenuListView/IOnSwipeListenerImplementor, SwipeMenuListView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


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
