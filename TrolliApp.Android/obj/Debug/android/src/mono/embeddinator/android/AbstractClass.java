package mono.embeddinator.android;


public abstract class AbstractClass
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_GetText:()Ljava/lang/String;:__export__\n" +
			"";
		mono.android.Runtime.register ("TrolliApp.Droid.OnComplete, TrolliApp.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AbstractClass.class, __md_methods);
	}


	public AbstractClass ()
	{
		super ();
		if (getClass () == AbstractClass.class)
			mono.android.TypeManager.Activate ("TrolliApp.Droid.OnComplete, TrolliApp.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public java.lang.String getText ()
	{
		return n_GetText ();
	}

	private native java.lang.String n_GetText ();

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
