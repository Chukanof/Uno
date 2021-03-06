#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Holographic
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct HolographicAdapterId 
	{
		// Forced skipping of method Windows.Graphics.Holographic.HolographicAdapterId.HolographicAdapterId()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint LowPart;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  int HighPart;
		#endif
	}
}
