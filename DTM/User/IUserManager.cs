using System.Threading.Tasks;
using DTM.Database;

namespace DTM.User
{
    public interface IUserManager
    {
        string UserName { get;}
        string Password { get;}
        bool IsConnected { get;}
        IDbManager DbManager { get; }

        Task<int> Connect(string username, string password);
        bool Connected();
    }
}