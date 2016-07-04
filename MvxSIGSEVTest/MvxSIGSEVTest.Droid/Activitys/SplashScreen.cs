using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Platform;
using MvvmCross.Droid.Views;

namespace MvxSIGSEVTest.Droid.Activitys
{
    [Activity(
         Label = "MvxRecyclerViewTest"
         , MainLauncher = true
         , NoHistory = true)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            var setupSingleton = MvxAndroidSetupSingleton.EnsureSingletonAvailable(this);
            setupSingleton.EnsureInitialized();

            base.OnCreate(bundle);
        }

        public SplashScreen()
            : base(Resource.Layout.activity_splashscreen)
        {
        }
    }
}