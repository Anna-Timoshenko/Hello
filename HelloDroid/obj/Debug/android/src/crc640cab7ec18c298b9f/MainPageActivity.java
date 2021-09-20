package crc640cab7ec18c298b9f;


public class MainPageActivity
	extends crc64de6a99482732a171.ActivityBase_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("HelloDroid.Views.MainPageActivity, HelloDroid", MainPageActivity.class, __md_methods);
	}


	public MainPageActivity ()
	{
		super ();
		if (getClass () == MainPageActivity.class)
			mono.android.TypeManager.Activate ("HelloDroid.Views.MainPageActivity, HelloDroid", "", this, new java.lang.Object[] {  });
	}


	public MainPageActivity (int p0)
	{
		super (p0);
		if (getClass () == MainPageActivity.class)
			mono.android.TypeManager.Activate ("HelloDroid.Views.MainPageActivity, HelloDroid", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


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
