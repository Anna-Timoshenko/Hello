package crc645d60ef120cc5989a;


public class BindableRecyclerViewAdapter_2
	extends crc645d60ef120cc5989a.BindableRecyclerViewAdapterBase_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getItemCount:()I:GetGetItemCountHandler\n" +
			"";
		mono.android.Runtime.register ("Softeq.XToolkit.Bindings.Droid.Bindable.BindableRecyclerViewAdapter`2, Softeq.XToolkit.Bindings.Droid", BindableRecyclerViewAdapter_2.class, __md_methods);
	}


	public BindableRecyclerViewAdapter_2 ()
	{
		super ();
		if (getClass () == BindableRecyclerViewAdapter_2.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.Bindings.Droid.Bindable.BindableRecyclerViewAdapter`2, Softeq.XToolkit.Bindings.Droid", "", this, new java.lang.Object[] {  });
	}


	public int getItemCount ()
	{
		return n_getItemCount ();
	}

	private native int n_getItemCount ();

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
