#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.MediaProperties
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IMediaEncodingProperties 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Media.MediaProperties.MediaPropertySet Properties
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		string Subtype
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		string Type
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.Media.MediaProperties.IMediaEncodingProperties.Properties.get
		// Forced skipping of method Windows.Media.MediaProperties.IMediaEncodingProperties.Type.get
		// Forced skipping of method Windows.Media.MediaProperties.IMediaEncodingProperties.Subtype.set
		// Forced skipping of method Windows.Media.MediaProperties.IMediaEncodingProperties.Subtype.get
	}
}
