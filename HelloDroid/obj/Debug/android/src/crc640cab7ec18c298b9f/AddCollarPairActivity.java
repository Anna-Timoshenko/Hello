package crc640cab7ec18c298b9f;


public class AddCollarPairActivity
	extends crc64de6a99482732a171.ActivityBase_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("HelloDroid.Views.AddCollarPairActivity, HelloDroid", AddCollarPairActivity.class, __md_methods);
	}


	public AddCollarPairActivity ()
	{
		super ();
		if (getClass () == AddCollarPairActivity.class)
			mono.android.TypeManager.Activate ("HelloDroid.Views.AddCollarPairActivity, HelloDroid", "", this, new java.lang.Object[] {  });
	}


	public AddCollarPairActivity (int p0)
	{
		super (p0);
		if (getClass () == AddCollarPairActivity.class)
			mono.android.TypeManager.Activate ("HelloDroid.Views.AddCollarPairActivity, HelloDroid", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
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
