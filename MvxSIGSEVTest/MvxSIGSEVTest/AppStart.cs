using MvvmCross.Core.ViewModels;
using MvxSIGSEVTest.ViewModels;

namespace MvxSIGSEVTest
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
             ShowViewModel<MainViewModel>();
        }
    }
}
