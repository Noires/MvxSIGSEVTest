using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvxRecyclerViewLeakTest.ViewModels;

namespace MvxRecyclerViewLeakTest.Droid.Activitys
{
    [Activity(Label = "MainActivity", Theme = "@style/Theme.MainTest" )]
    public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_main);

            if (bundle == null)
            {
                ViewModel.ShowInitScreen.Execute();
            }
        }
    }
}