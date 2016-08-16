using System;
using System.Collections.Generic;
using System.Text;
using TVShows.Controls;
using TVShows.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TVShowsWebView), typeof(TVShowsWebViewRenderer))]
namespace TVShows.iOS.Renderers
{

    public class TVShowsWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            Delegate = new ExtendedUIWebViewDelegate(this);
        }
    }

    public class ExtendedUIWebViewDelegate : UIWebViewDelegate
    {
        TVShowsWebViewRenderer webViewRenderer;

        public ExtendedUIWebViewDelegate(TVShowsWebViewRenderer _webViewRenderer = null)
        {
            webViewRenderer = _webViewRenderer ?? new TVShowsWebViewRenderer();
        }

        public override async void LoadingFinished(UIWebView webView)
        {
            var wv = webViewRenderer.Element as TVShowsWebView;
            if (wv != null)
            {
                await System.Threading.Tasks.Task.Delay(100); // wait here till content is rendered
                wv.HeightRequest = (double)webView.ScrollView.ContentSize.Height;
            }
        }
    }
}
