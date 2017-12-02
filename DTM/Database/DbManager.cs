using System;
using System.Threading.Tasks;
using DTM.Encryption;
using MySql.Data.MySqlClient;

namespace DTM.Database
{
    public sealed class DbManager : IDbManager
    {
        private const string ConnectionString = @"Server=localhost;Port=3306;Database=jdr;Uid=root;Pwd=root";

        public DbManager()
        {
            try
            {
                Conn = new MySqlConnection(ConnectionString);
                Conn.Open();
            }
            catch (Exception)
            {
                Conn.Close();
                throw new Exception("Une erreur est survenue pendant la connexion à la base de données");
            }
        }

        private MySqlConnection Conn { get; }

        public async Task<string> GetUser(string username)
        {
            const string sql = @"SELECT Pwd FROM Users WHERE UserName=@username";
            var cmd = new MySqlCommand(sql, Conn);
            cmd.Parameters.AddWithValue("@username", username);
            var reader = await cmd.ExecuteReaderAsync();

            if (reader == null)
                throw new Exception("Une erreur est survenue");

            if (!reader.HasRows || reader.FieldCount != 1)
            {
                reader.Close();
                return null;
            }

            reader.Read();
            var ret = reader["Pwd"].ToString();
            reader.Close();
            return ret;
        }

        public async Task GetAllPerso(object perso)
        {
            await Task.CompletedTask;
        }

        public async Task GetPersoByName(object perso)
        {
            await Task.CompletedTask;
        }

        public async Task GetStatsPerso(object perso)
        {
            await Task.CompletedTask;
        }

        public async Task GetCaracPerso(object perso)
        {
            await Task.CompletedTask;
        }

        public async Task GetJaugePerso(object perso)
        {
            await Task.CompletedTask;
        }

        public async Task GetDonsPerso(object perso)
        {
            await Task.CompletedTask;
        }

        public async Task GetAllDons()
        {
            await Task.CompletedTask;
        }

        public async Task PassifsPerso(object perso)
        {
            await Task.CompletedTask;
        }

        public async Task GetAllPassifs()
        {
            await Task.CompletedTask;
        }

        public async Task GetAllDemons()
        {
            await Task.CompletedTask;
        }

        public async Task GetDemonPerso(object perso)
        {
            await Task.CompletedTask;
        }

        public async Task GetInventairePerso(object perso)
        {
            await Task.CompletedTask;
        }

        public async Task GetAllInventaires()
        {
            await Task.CompletedTask;
        }

        public async Task GetItemByNom(object perso)
        {
            await Task.CompletedTask;
        }

        public async Task GetItemsPerso(object perso)
        {
            await Task.CompletedTask;
        }

        public async Task GetAllItemsByPerso()
        {
            await Task.CompletedTask;
        }

        public async Task GetSkillsPerso(object perso)
        {
            await Task.CompletedTask;
        }

        public async Task GetAllSkills()
        {
            await Task.CompletedTask;
        }

        public async Task GetAllEllements()
        {
            await Task.CompletedTask;
        }

        public async Task GetElementPerso(object perso)
        {
            await Task.CompletedTask;
        }

        //public static DbManager GetInstance()
        //{
        //    return Instance;
        //}
    }
}