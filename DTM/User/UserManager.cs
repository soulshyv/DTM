using System.Threading.Tasks;
using System.Security.Cryptography;
using DTM.Database;

namespace DTM.User
{
    public class UserManager : IUserManager
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsConnected { get; private set; }

        public UserManager(IDbManager dbManager)
        {
            DbManager = dbManager;
            IsConnected = false;
        }

        public IDbManager DbManager { get; }

        public async Task<int> Connect(string username, string password)
        {
            var res = await DbManager.GetUser(username);
            if (res == null) return -1;
            if ( != password) return 0;
            UserName = username;
            Password = password;
            IsConnected = true;
            return 1;
        }

        public bool Connected()
        {
            return IsConnected;
        }
    }
}
