using MvvmCross.Core.ViewModels;

namespace MvxSIGSEVTest.ViewModels
{
    public class OverViewViewModel : BaseViewModel
    {
        public IMvxCommand ShowNextScreen
        {
            get
            {
                return new MvxCommand(() =>
                {
                    ShowViewModel<OverViewViewModel2>();
                });
            }
        }

    }
}
