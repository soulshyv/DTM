using System.Threading.Tasks;
using System.Security.Cryptography;
using DTM.Database;
using DTM.Encryption;

namespace DTM.User
{
    public class UserManager : IUserManager
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsConnected { get; private set; }

        public UserManager(IDbManager dbManager, IMd5Encryption encryption)
        {
            DbManager = dbManager;
            Encryption = encryption;
            IsConnected = false;
        }

        public IDbManager DbManager { get; }
        public IMd5Encryption Encryption { get; }

        public async Task<int> Connect(string username, string password)
        {
            var res = await DbManager.GetUser(username);
            if (res == null) return -1;
            if (Encryption.Encrypt(res) != password) return 0;
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
