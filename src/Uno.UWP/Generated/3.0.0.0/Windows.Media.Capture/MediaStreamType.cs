#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Capture
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum MediaStreamType 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		VideoPreview,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		VideoRecord,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Audio,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Photo,
		#endif
	}
	#endif
}
