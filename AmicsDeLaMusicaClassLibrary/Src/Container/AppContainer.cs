using AmicsDeLaMusicaClassLibrary.src.Partner;
using AmicsDeLaMusicaClassLibrary.Src.DataBase;
using AmicsDeLaMusicaClassLibrary.Src.Partner;
using AmicsDeLaMusicaClassLibrary.Src.Reports;
using SimpleInjector;

namespace AmicsDeLaMusicaClassLibrary.Src.Container
{
    public class AppContainer
    {
        private static SimpleInjector.Container _container;

        public static SimpleInjector.Container GetInstance()
        {

            if (_container == null) {

                _container = new SimpleInjector.Container();

                _container.RegisterInstance(new DataBaseService());

                _container.Options.AllowOverridingRegistrations = true;

                _container.Register<IPartnerRepository, PartnerRepository>(Lifestyle.Singleton);
                _container.Register<IPartnerService, PartnerService>(Lifestyle.Singleton);

                _container.Register<ReportService>(Lifestyle.Singleton);

                _container.Verify();

            }

            return _container;

        }
    }
}
