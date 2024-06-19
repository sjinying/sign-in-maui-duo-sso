
using Android.Webkit;
using SignInMaui.Platforms.Android;
using WebView = Android.Webkit.WebView;

[assembly: Dependency(typeof(WebviewService))]
namespace SignInMaui.Platforms.Android
{
    public class WebviewService : IWebviewService
    {
        public void ClearCache()
        {
#if ANDROID
            var webView = new WebView(Platform.CurrentActivity);
            webView.ClearCache(true);
#endif
        }
    }
}