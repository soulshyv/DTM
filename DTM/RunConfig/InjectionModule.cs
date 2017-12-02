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
            Container.Register<IUserManager, UserManager>(Lifestyle.Singleton);
            Container.Register<IMd5Encryption, Md5Encryption>();
            Container.Register<IDbManager, DbManager>(Lifestyle.Singleton);
            Container.Register<DtmLoginWindow>();
        }
    }
}
