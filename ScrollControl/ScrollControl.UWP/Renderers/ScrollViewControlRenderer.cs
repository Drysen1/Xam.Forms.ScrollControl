using ScrollControl.Controls;
using ScrollControl.UWP.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(ScrollViewControl), typeof(ScrollViewControlRenderer))]
namespace ScrollControl.UWP.Renderers
{
    public class ScrollViewControlRenderer : ScrollViewRenderer
    {
        public ScrollViewControlRenderer()
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<ScrollView> e)
        {
            base.OnElementChanged(e);
            var element = e.NewElement as ScrollViewControl;
            element?.Render();
        }
    }
}
