package crc64de6a99482732a171;


public class FragmentBase_1
	extends androidx.fragment.app.Fragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"";
		mono.android.Runtime.register ("Softeq.XToolkit.WhiteLabel.Droid.FragmentBase`1, Softeq.XToolkit.WhiteLabel.Droid", FragmentBase_1.class, __md_methods);
	}


	public FragmentBase_1 ()
	{
		super ();
		if (getClass () == FragmentBase_1.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.FragmentBase`1, Softeq.XToolkit.WhiteLabel.Droid", "", this, new java.lang.Object[] {  });
	}


	public FragmentBase_1 (int p0)
	{
		super (p0);
		if (getClass () == FragmentBase_1.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.FragmentBase`1, Softeq.XToolkit.WhiteLabel.Droid", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();


	public void onPause ()
	{
		n_onPause ();
	}

	private native void n_onPause ();

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
