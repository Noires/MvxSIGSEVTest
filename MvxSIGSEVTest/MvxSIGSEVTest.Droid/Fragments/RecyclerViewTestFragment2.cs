using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvxSIGSEVTest.ViewModels;

namespace MvxSIGSEVTest.Droid.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame)]
    [Register("mvxsigsevtest.droid.fragments.RecyclerViewTestFragment2")]
    public class RecyclerViewTestFragment2 : BaseFragment<RecyclerViewTestViewModel2>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);


            //var recyclerview = view.FindViewById<MvxRecyclerView>(Resource.Id.lvTestList);
            //recyclerview.SetLayoutManager(new LinearLayoutManager(Context));

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ViewModel?.Update();
        }

        protected override int FragmentId => Resource.Layout.fragment_recyclerviewtest;

        public override bool UserVisibleHint
        {
            get { return base.UserVisibleHint; }
            set
            {
                if (value)
                {
                    if (IsVisible)
                    {
                        ViewModel?.Update();
                    }
                }
                base.UserVisibleHint = value;
            }
        }

    }


}