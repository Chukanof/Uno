#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Maps
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum MapRouteOptimization 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Time,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Distance,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		TimeWithTraffic,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Scenic,
		#endif
	}
	#endif
}