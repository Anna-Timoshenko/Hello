package crc64879a17e91ae93265;


public class EditTextExtensions_ForbiddenCharsInputFilter
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.text.InputFilter
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_filter:(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;:GetFilter_Ljava_lang_CharSequence_IILandroid_text_Spanned_IIHandler:Android.Text.IInputFilterInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Softeq.XToolkit.Common.Droid.Extensions.EditTextExtensions+ForbiddenCharsInputFilter, Softeq.XToolkit.Common.Droid", EditTextExtensions_ForbiddenCharsInputFilter.class, __md_methods);
	}


	public EditTextExtensions_ForbiddenCharsInputFilter ()
	{
		super ();
		if (getClass () == EditTextExtensions_ForbiddenCharsInputFilter.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.Common.Droid.Extensions.EditTextExtensions+ForbiddenCharsInputFilter, Softeq.XToolkit.Common.Droid", "", this, new java.lang.Object[] {  });
	}

	public EditTextExtensions_ForbiddenCharsInputFilter (char[] p0)
	{
		super ();
		if (getClass () == EditTextExtensions_ForbiddenCharsInputFilter.class)
			mono.android.TypeManager.Activate ("Softeq.XToolkit.Common.Droid.Extensions.EditTextExtensions+ForbiddenCharsInputFilter, Softeq.XToolkit.Common.Droid", "System.Char[], mscorlib", this, new java.lang.Object[] { p0 });
	}


	public java.lang.CharSequence filter (java.lang.CharSequence p0, int p1, int p2, android.text.Spanned p3, int p4, int p5)
	{
		return n_filter (p0, p1, p2, p3, p4, p5);
	}

	private native java.lang.CharSequence n_filter (java.lang.CharSequence p0, int p1, int p2, android.text.Spanned p3, int p4, int p5);

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
