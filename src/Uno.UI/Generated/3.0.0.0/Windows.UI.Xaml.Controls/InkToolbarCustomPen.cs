#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbarCustomPen : global::Windows.UI.Xaml.DependencyObject
	{
		#if false || false || false || false
		[global::Uno.NotImplemented]
		protected InkToolbarCustomPen() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbarCustomPen", "InkToolbarCustomPen.InkToolbarCustomPen()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarCustomPen.InkToolbarCustomPen()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Input.Inking.InkDrawingAttributes CreateInkDrawingAttributes( global::Windows.UI.Xaml.Media.Brush brush,  double strokeWidth)
		{
			throw new global::System.NotImplementedException("The member InkDrawingAttributes InkToolbarCustomPen.CreateInkDrawingAttributes(Brush brush, double strokeWidth) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		protected virtual global::Windows.UI.Input.Inking.InkDrawingAttributes CreateInkDrawingAttributesCore( global::Windows.UI.Xaml.Media.Brush brush,  double strokeWidth)
		{
			throw new global::System.NotImplementedException("The member InkDrawingAttributes InkToolbarCustomPen.CreateInkDrawingAttributesCore(Brush brush, double strokeWidth) is not implemented in Uno.");
		}
		#endif
	}
}
