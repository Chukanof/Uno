#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Data.Text
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	public delegate void SelectableWordSegmentsTokenizingHandler(global::System.Collections.Generic.IEnumerable<global::Windows.Data.Text.SelectableWordSegment> @precedingWords, global::System.Collections.Generic.IEnumerable<global::Windows.Data.Text.SelectableWordSegment> @words);
	#endif
}