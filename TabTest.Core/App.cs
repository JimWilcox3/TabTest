using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using TabTest.Core.ViewModels;

namespace TabTest.Core

{
    public class App : MvxApplication
    {
        public override void Initialize()
        {

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            CreatableTypes()
                .EndingWith("Singleton")
                .AsInterfaces()
                .RegisterAsSingleton();

            RegisterAppStart<MainViewModel>();

        }
    }
}