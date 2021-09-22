package crc645d60ef120cc5989a;


public abstract class BindableViewHolder_1
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Softeq.XToolkit.Bindings.Droid.Bindable.BindableViewHolder`1, Softeq.XToolkit.Bindings.Droid", BindableViewHolder_1.class, __md_methods);
	}


	public BindableViewHolder_1 (android.view.View p0)
	{
		super (p0);
		if (getClass () == BindableViewHolder_1.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.Bindings.Droid.Bindable.BindableViewHolder`1, Softeq.XToolkit.Bindings.Droid", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
