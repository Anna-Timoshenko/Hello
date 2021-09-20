package crc6412bfed534a5a1fdb;


public class ObservableAdapterExtended_1
	extends crc6412bfed534a5a1fdb.ObservableAdapter_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getView:(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"";
		mono.android.Runtime.register ("Softeq.XToolkit.Bindings.Droid.ObservableAdapterExtended`1, Softeq.XToolkit.Bindings.Droid", ObservableAdapterExtended_1.class, __md_methods);
	}


	public ObservableAdapterExtended_1 ()
	{
		super ();
		if (getClass () == ObservableAdapterExtended_1.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.Bindings.Droid.ObservableAdapterExtended`1, Softeq.XToolkit.Bindings.Droid", "", this, new java.lang.Object[] {  });
	}


	public android.view.View getView (int p0, android.view.View p1, android.view.ViewGroup p2)
	{
		return n_getView (p0, p1, p2);
	}

	private native android.view.View n_getView (int p0, android.view.View p1, android.view.ViewGroup p2);

	private java.util.ArrayList refList;
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
