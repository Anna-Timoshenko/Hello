package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("HelloDroid.MainApplication, HelloDroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc64a0a2051fc74d3e23.MainApplication.class, crc64a0a2051fc74d3e23.MainApplication.__md_methods);
		mono.android.Runtime.register ("Softeq.XToolkit.WhiteLabel.Droid.MainApplicationBase, Softeq.XToolkit.WhiteLabel.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc64de6a99482732a171.MainApplicationBase.class, crc64de6a99482732a171.MainApplicationBase.__md_methods);
		
	}
}
