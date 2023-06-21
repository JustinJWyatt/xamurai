using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamurai.Services;

[assembly: Dependency(typeof(Xamurai.Droid.Services.StatusBarService))]
namespace Xamurai.Droid.Services
{
    public class StatusBarService : IStatusBarService
    {
        public void HideStatusBar()
        {
            var activity = Platform.CurrentActivity;
            var window = activity.Window;
            var attrs = activity.Window.Attributes;
            attrs.Flags |= WindowManagerFlags.Fullscreen | WindowManagerFlags.LayoutNoLimits;
            window.Attributes.LayoutInDisplayCutoutMode = LayoutInDisplayCutoutMode.ShortEdges;
            activity.Window.Attributes = attrs;
        }
    }
}