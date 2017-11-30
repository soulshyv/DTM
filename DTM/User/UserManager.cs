using DTM.Database;

namespace DTM.User
{
    public class UserManager : IUserManager
    {
        private string UserName { get; set; }
        private string Password { get; set; }
        public IDbManager DbManager { get; }

        public UserManager(IDbManager dbManager)
        {
            DbManager = dbManager;
        }
    }
}
