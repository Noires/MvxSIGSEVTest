using MvvmCross.Core.ViewModels;

namespace MvxSIGSEVTest.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public IMvxCommand ShowInitScreen
        {
            get
            {
                return new MvxCommand(() =>
                {
                    ShowViewModel<OverViewViewModel>();
                });
            }
        }
    }
}
