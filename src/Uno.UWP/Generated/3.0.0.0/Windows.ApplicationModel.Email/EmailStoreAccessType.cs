#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum EmailStoreAccessType 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		AppMailboxesReadWrite,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		AllMailboxesLimitedReadWrite,
		#endif
	}
	#endif
}
