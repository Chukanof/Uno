#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Chat
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IChatItem 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.ApplicationModel.Chat.ChatItemKind ItemKind
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Chat.IChatItem.ItemKind.get
	}
}
