using ScrollControl.Controls;
using ScrollControl.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ScrollViewControl), typeof(ScrollViewControlRenderer))]
namespace ScrollControl.iOS
{
    public class ScrollViewControlRenderer : ScrollViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var element = e.NewElement as ScrollViewControl;
            element?.Render();

            ShowsHorizontalScrollIndicator = false;
        }
    }
}