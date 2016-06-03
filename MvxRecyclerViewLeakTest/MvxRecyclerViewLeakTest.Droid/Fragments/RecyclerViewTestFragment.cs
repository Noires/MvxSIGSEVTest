using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Shared.Attributes;
using MvxRecyclerViewLeakTest.ViewModels;

namespace MvxRecyclerViewLeakTest.Droid.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame)]
    [Register("mvxrecyclerviewleaktest.droid.fragments.RecyclerViewTestFragment")]
    public class RecyclerViewTestFragment : BaseFragment<RecyclerViewTestViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            return view;
        }

        protected override int FragmentId
        {
            get
            {
                return Resource.Layout.fragment_recyclerviewtest;
            }
        }
    }
}