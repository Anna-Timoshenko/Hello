package crc645d60ef120cc5989a;


public class BindableRecyclerViewAdapter_3
	extends crc645d60ef120cc5989a.BindableRecyclerViewAdapterBase_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getItemCount:()I:GetGetItemCountHandler\n" +
			"n_onCreateViewHolder:(Landroid/view/ViewGroup;I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;:GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler\n" +
			"";
		mono.android.Runtime.register ("Softeq.XToolkit.Bindings.Droid.Bindable.BindableRecyclerViewAdapter`3, Softeq.XToolkit.Bindings.Droid", BindableRecyclerViewAdapter_3.class, __md_methods);
	}


	public BindableRecyclerViewAdapter_3 ()
	{
		super ();
		if (getClass () == BindableRecyclerViewAdapter_3.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.Bindings.Droid.Bindable.BindableRecyclerViewAdapter`3, Softeq.XToolkit.Bindings.Droid", "", this, new java.lang.Object[] {  });
	}


	public int getItemCount ()
	{
		return n_getItemCount ();
	}

	private native int n_getItemCount ();


	public androidx.recyclerview.widget.RecyclerView.ViewHolder onCreateViewHolder (android.view.ViewGroup p0, int p1)
	{
		return n_onCreateViewHolder (p0, p1);
	}

	private native androidx.recyclerview.widget.RecyclerView.ViewHolder n_onCreateViewHolder (android.view.ViewGroup p0, int p1);

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
