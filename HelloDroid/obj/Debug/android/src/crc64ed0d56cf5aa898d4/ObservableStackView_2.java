package crc64ed0d56cf5aa898d4;


public abstract class ObservableStackView_2
	extends android.widget.LinearLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Softeq.XToolkit.WhiteLabel.Droid.Controls.ObservableStackView`2, Softeq.XToolkit.WhiteLabel.Droid", ObservableStackView_2.class, __md_methods);
	}


	public ObservableStackView_2 (android.content.Context p0)
	{
		super (p0);
		if (getClass () == ObservableStackView_2.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.Controls.ObservableStackView`2, Softeq.XToolkit.WhiteLabel.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public ObservableStackView_2 (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == ObservableStackView_2.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.Controls.ObservableStackView`2, Softeq.XToolkit.WhiteLabel.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public ObservableStackView_2 (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == ObservableStackView_2.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.Controls.ObservableStackView`2, Softeq.XToolkit.WhiteLabel.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public ObservableStackView_2 (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == ObservableStackView_2.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.WhiteLabel.Droid.Controls.ObservableStackView`2, Softeq.XToolkit.WhiteLabel.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
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
