using System.Collections.Generic;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Support.Design.Widget;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using MvxSIGSEVTest.ViewModels;

namespace MvxSIGSEVTest.Droid.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame,true)]
    [Register("mvxsigsevtest.droid.fragments.OverViewFragment2")]
    public class OverViewFragment2 : BaseFragment<OverViewViewModel2>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            var fragments = new List<MvxCachingFragmentStatePagerAdapter.FragmentInfo>
            {
                // TODO: Remove Strings
                new MvxCachingFragmentStatePagerAdapter.FragmentInfo("Test", typeof (RecyclerViewTestFragment),
                    typeof (RecyclerViewTestViewModel)),
                new MvxCachingFragmentStatePagerAdapter.FragmentInfo("Test2", typeof (RecyclerViewTestFragment2),
                    typeof (RecyclerViewTestViewModel2))
            };
            var fragmentAdapter = new MvxCachingFragmentStatePagerAdapter(Activity, ChildFragmentManager, fragments);
            var viewPager = view.FindViewById<ViewPager>(Resource.Id.viewpager);
            if (viewPager != null)
            {
                viewPager.Adapter = fragmentAdapter;
                var tabLayout = view.FindViewById<TabLayout>(Resource.Id.tabs);
                if (tabLayout != null)
                {
                    tabLayout.SetupWithViewPager(viewPager);
                }

            }

            return view;
        }

        protected override int FragmentId => Resource.Layout.fragment_overview;
    }
}