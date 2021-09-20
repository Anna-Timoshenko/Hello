package crc6471b64d6d31bae7cb;


public abstract class BottomNavigationActivityBase_2
	extends crc6471b64d6d31bae7cb.ToolbarActivityBase_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onDestroy:()V:GetOnDestroyHandler\n" +
			"";
		mono.android.Runtime.register ("Softeq.XToolkit.WhiteLabel.Droid.Views.BottomNavigationActivityBase`2, Softeq.XToolkit.WhiteLabel.Droid", BottomNavigationActivityBase_2.class, __md_methods);
	}


	public BottomNavigationActivityBase_2 ()
	{
		super ();
		if (getClass () == BottomNavigationActivityBase_2.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.Views.BottomNavigationActivityBase`2, Softeq.XToolkit.WhiteLabel.Droid", "", this, new java.lang.Object[] {  });
	}


	public BottomNavigationActivityBase_2 (int p0)
	{
		super (p0);
		if (getClass () == BottomNavigationActivityBase_2.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.Views.BottomNavigationActivityBase`2, Softeq.XToolkit.WhiteLabel.Droid", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onDestroy ()
	{
		n_onDestroy ();
	}

	private native void n_onDestroy ();

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
