using DTM.Database;
using DTM.Encryption;
using DTM.Forms;
using DTM.User;
using SimpleInjector;

namespace DTM.RunConfig
{
    public static class InjectionModule
    {
        public static Container Container = new Container();

        public static void Init()
        {
            Container.Register<IMd5Encryption, Md5Encryption>(Lifestyle.Scoped);
            Container.Register<IDbManager, DbManager>(Lifestyle.Scoped);
            Container.Register<IUserManager, UserManager>(Lifestyle.Singleton);
            Container.Register<DtmLoginWindow>(Lifestyle.Scoped);
            Container.Register<DtmMainWindow>();

            Container.Verify();
        }
    }
}