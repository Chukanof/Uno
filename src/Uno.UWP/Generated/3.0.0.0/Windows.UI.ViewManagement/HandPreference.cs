#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.ViewManagement
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum HandPreference 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		LeftHanded,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		RightHanded,
		#endif
	}
	#endif
}
