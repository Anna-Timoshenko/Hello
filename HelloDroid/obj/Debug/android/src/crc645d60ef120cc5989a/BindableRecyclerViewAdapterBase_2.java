package crc645d60ef120cc5989a;


public abstract class BindableRecyclerViewAdapterBase_2
	extends androidx.recyclerview.widget.RecyclerView.Adapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getItemViewType:(I)I:GetGetItemViewType_IHandler\n" +
			"n_onFailedToRecycleView:(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)Z:GetOnFailedToRecycleView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler\n" +
			"n_onViewAttachedToWindow:(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V:GetOnViewAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler\n" +
			"n_onViewDetachedFromWindow:(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V:GetOnViewDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler\n" +
			"n_onCreateViewHolder:(Landroid/view/ViewGroup;I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;:GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler\n" +
			"n_onBindViewHolder:(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V:GetOnBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler\n" +
			"n_onViewRecycled:(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V:GetOnViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler\n" +
			"";
		mono.android.Runtime.register ("Softeq.XToolkit.Bindings.Droid.Bindable.BindableRecyclerViewAdapterBase`2, Softeq.XToolkit.Bindings.Droid", BindableRecyclerViewAdapterBase_2.class, __md_methods);
	}


	public BindableRecyclerViewAdapterBase_2 ()
	{
		super ();
		if (getClass () == BindableRecyclerViewAdapterBase_2.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.Bindings.Droid.Bindable.BindableRecyclerViewAdapterBase`2, Softeq.XToolkit.Bindings.Droid", "", this, new java.lang.Object[] {  });
	}


	public int getItemViewType (int p0)
	{
		return n_getItemViewType (p0);
	}

	private native int n_getItemViewType (int p0);


	public boolean onFailedToRecycleView (androidx.recyclerview.widget.RecyclerView.ViewHolder p0)
	{
		return n_onFailedToRecycleView (p0);
	}

	private native boolean n_onFailedToRecycleView (androidx.recyclerview.widget.RecyclerView.ViewHolder p0);


	public void onViewAttachedToWindow (androidx.recyclerview.widget.RecyclerView.ViewHolder p0)
	{
		n_onViewAttachedToWindow (p0);
	}

	private native void n_onViewAttachedToWindow (androidx.recyclerview.widget.RecyclerView.ViewHolder p0);


	public void onViewDetachedFromWindow (androidx.recyclerview.widget.RecyclerView.ViewHolder p0)
	{
		n_onViewDetachedFromWindow (p0);
	}

	private native void n_onViewDetachedFromWindow (androidx.recyclerview.widget.RecyclerView.ViewHolder p0);


	public androidx.recyclerview.widget.RecyclerView.ViewHolder onCreateViewHolder (android.view.ViewGroup p0, int p1)
	{
		return n_onCreateViewHolder (p0, p1);
	}

	private native androidx.recyclerview.widget.RecyclerView.ViewHolder n_onCreateViewHolder (android.view.ViewGroup p0, int p1);


	public void onBindViewHolder (androidx.recyclerview.widget.RecyclerView.ViewHolder p0, int p1)
	{
		n_onBindViewHolder (p0, p1);
	}

	private native void n_onBindViewHolder (androidx.recyclerview.widget.RecyclerView.ViewHolder p0, int p1);


	public void onViewRecycled (androidx.recyclerview.widget.RecyclerView.ViewHolder p0)
	{
		n_onViewRecycled (p0);
	}

	private native void n_onViewRecycled (androidx.recyclerview.widget.RecyclerView.ViewHolder p0);

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
