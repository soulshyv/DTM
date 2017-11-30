﻿using DTM.Database;
using DTM.User;
using Ninject.Modules;

namespace DTM.RunConfig
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDbManager>().ToSelf().InSingletonScope();
            Bind<IUserManager>().To<UserManager>();
        }
    }
}
