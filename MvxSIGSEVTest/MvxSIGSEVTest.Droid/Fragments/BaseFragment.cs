using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Support.V7.RecyclerView;

namespace MvxSIGSEVTest.Droid.Fragments
{
    public abstract class BaseFragment : MvxFragment
    {
        protected BaseFragment()
        {
            /* Control whether a fragment instance is retained across Activity re-creation (such as from a configuration change). 
             * This can only be used with fragments not in the back stack. If set, the fragment lifecycle will be slightly different when an activity is recreated:
             * onDestroy() will not be called (but onDetach() still will be, because the fragment is being detached from its current activity).
             * onCreate(Bundle) will not be called since the fragment is not being re-created.
             * onAttach(Activity) and onActivityCreated(Bundle) will still be called.
            */
            RetainInstance = false;
        }

        /// <summary>
        /// FragmentId equivalent zur LayoutID des Fragmentes.
        /// </summary>
        protected abstract int FragmentId { get; }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(FragmentId, null);

     

            return view;
        }
    }

    public abstract class BaseFragment<TViewModel> : BaseFragment where TViewModel : class, IMvxViewModel
    {

        public new TViewModel ViewModel
        {
            get { return (TViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }
    }
}