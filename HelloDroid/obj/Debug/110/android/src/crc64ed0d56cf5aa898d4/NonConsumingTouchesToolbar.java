package crc64ed0d56cf5aa898d4;


public class NonConsumingTouchesToolbar
	extends androidx.appcompat.widget.Toolbar
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("Softeq.XToolkit.WhiteLabel.Droid.Controls.NonConsumingTouchesToolbar, Softeq.XToolkit.WhiteLabel.Droid", NonConsumingTouchesToolbar.class, __md_methods);
	}


	public NonConsumingTouchesToolbar (android.content.Context p0)
	{
		super (p0);
		if (getClass () == NonConsumingTouchesToolbar.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.Controls.NonConsumingTouchesToolbar, Softeq.XToolkit.WhiteLabel.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public NonConsumingTouchesToolbar (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == NonConsumingTouchesToolbar.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.Controls.NonConsumingTouchesToolbar, Softeq.XToolkit.WhiteLabel.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public NonConsumingTouchesToolbar (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == NonConsumingTouchesToolbar.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.Controls.NonConsumingTouchesToolbar, Softeq.XToolkit.WhiteLabel.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);

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