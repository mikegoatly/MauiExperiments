using SkiaSharp;

using Topten.RichTextKit;

namespace MauiRichTextKit;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    private void SKCanvasView_PaintSurface(object sender, SkiaSharp.Views.Maui.SKPaintSurfaceEventArgs e)
    {
		var text = new TextBlock();
		var styleManager = StyleManager.Default.Value;
		styleManager.FontSize(40);
		styleManager.HaloColor(SKColors.Red);
		styleManager.HaloWidth(4);
		styleManager.HaloBlur(2);
		
		text.AddText("Hello MAUI!", styleManager.CurrentStyle);

		text.Paint(e.Surface.Canvas, new SKPoint(100, 200));
	}
}

