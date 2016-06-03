using MvvmCross.Core.ViewModels;

namespace MvxRecyclerViewLeakTest.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public IMvxCommand ShowInitScreen
        {
            get
            {
                return new MvxCommand(() =>
                {
                    ShowViewModel<RecyclerViewTestViewModel>();
                });
            }
        }
    }
}
