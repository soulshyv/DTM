using DTM.Database;

namespace DTM.User
{
    public interface IUserManager
    {
        IDbManager DbManager { get; }
    }
}