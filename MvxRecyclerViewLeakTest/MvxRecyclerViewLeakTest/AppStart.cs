using MvvmCross.Core.ViewModels;
using MvxRecyclerViewLeakTest.ViewModels;

namespace MvxRecyclerViewLeakTest
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
             ShowViewModel<MainViewModel>();
        }
    }
}
