package crc6471b64d6d31bae7cb;


public abstract class ToolbarActivityBase_2
	extends crc64de6a99482732a171.ActivityBase_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBackPressed:()V:GetOnBackPressedHandler\n" +
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Softeq.XToolkit.WhiteLabel.Droid.Views.ToolbarActivityBase`2, Softeq.XToolkit.WhiteLabel.Droid", ToolbarActivityBase_2.class, __md_methods);
	}


	public ToolbarActivityBase_2 ()
	{
		super ();
		if (getClass () == ToolbarActivityBase_2.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.Views.ToolbarActivityBase`2, Softeq.XToolkit.WhiteLabel.Droid", "", this, new java.lang.Object[] {  });
	}


	public ToolbarActivityBase_2 (int p0)
	{
		super (p0);
		if (getClass () == ToolbarActivityBase_2.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.Views.ToolbarActivityBase`2, Softeq.XToolkit.WhiteLabel.Droid", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onBackPressed ()
	{
		n_onBackPressed ();
	}

	private native void n_onBackPressed ();


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
