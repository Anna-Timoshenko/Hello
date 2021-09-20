package crc64542c26b92aff87a8;


public class DroidToastService_SnackbarCallback
	extends com.google.android.material.snackbar.BaseTransientBottomBar.BaseCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDismissed:(Ljava/lang/Object;I)V:GetOnDismissed_Ljava_lang_Object_IHandler\n" +
			"";
		mono.android.Runtime.register ("Softeq.XToolkit.WhiteLabel.Droid.Services.DroidToastService+SnackbarCallback, Softeq.XToolkit.WhiteLabel.Droid", DroidToastService_SnackbarCallback.class, __md_methods);
	}


	public DroidToastService_SnackbarCallback ()
	{
		super ();
		if (getClass () == DroidToastService_SnackbarCallback.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.Services.DroidToastService+SnackbarCallback, Softeq.XToolkit.WhiteLabel.Droid", "", this, new java.lang.Object[] {  });
	}


	public void onDismissed (java.lang.Object p0, int p1)
	{
		n_onDismissed (p0, p1);
	}

	private native void n_onDismissed (java.lang.Object p0, int p1);

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
