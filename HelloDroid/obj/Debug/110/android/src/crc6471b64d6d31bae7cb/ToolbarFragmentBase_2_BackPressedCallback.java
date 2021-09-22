package crc6471b64d6d31bae7cb;


public class ToolbarFragmentBase_2_BackPressedCallback
	extends androidx.activity.OnBackPressedCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_handleOnBackPressed:()V:GetHandleOnBackPressedHandler\n" +
			"";
		mono.android.Runtime.register ("Softeq.XToolkit.WhiteLabel.Droid.Views.ToolbarFragmentBase`2+BackPressedCallback, Softeq.XToolkit.WhiteLabel.Droid", ToolbarFragmentBase_2_BackPressedCallback.class, __md_methods);
	}


	public ToolbarFragmentBase_2_BackPressedCallback (boolean p0)
	{
		super (p0);
		if (getClass () == ToolbarFragmentBase_2_BackPressedCallback.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.Views.ToolbarFragmentBase`2+BackPressedCallback, Softeq.XToolkit.WhiteLabel.Droid", "System.Boolean, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void handleOnBackPressed ()
	{
		n_handleOnBackPressed ();
	}

	private native void n_handleOnBackPressed ();

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
