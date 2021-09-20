package crc64de6a99482732a171;


public abstract class ActivityBase_2
	extends crc64de6a99482732a171.ActivityBase_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Softeq.XToolkit.WhiteLabel.Droid.ActivityBase`2, Softeq.XToolkit.WhiteLabel.Droid", ActivityBase_2.class, __md_methods);
	}


	public ActivityBase_2 ()
	{
		super ();
		if (getClass () == ActivityBase_2.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.ActivityBase`2, Softeq.XToolkit.WhiteLabel.Droid", "", this, new java.lang.Object[] {  });
	}


	public ActivityBase_2 (int p0)
	{
		super (p0);
		if (getClass () == ActivityBase_2.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.ActivityBase`2, Softeq.XToolkit.WhiteLabel.Droid", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
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
