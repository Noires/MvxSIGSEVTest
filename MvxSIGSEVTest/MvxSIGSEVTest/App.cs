using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace MvxSIGSEVTest
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsSingleton();

            Mvx.ConstructAndRegisterSingleton<IMvxAppStart, AppStart>();

            var appStart = Mvx.Resolve<IMvxAppStart>();

            RegisterAppStart(appStart);
        }
    }
}
