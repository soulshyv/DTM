using System;
using System.Threading.Tasks;
using DTM.User;
using MySql.Data.MySqlClient;

namespace DTM.Database
{
    public sealed class DbManager : IDbManager
    {
        private const string ConnectionString = @"server=localhost;user=root;database=jdr;password=0SoulshyV0";
        private MySqlConnection Conn { get; }
        private static readonly DbManager Instance = new DbManager();

        private DbManager()
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

        public static DbManager GetInstance()
        {
            return Instance;
        }

        public async Task<string> GetUser(string username)
        {
            const string sql = @"SELECT Password FROM Users WHERE UserName=@username";
            var cmd = new MySqlCommand(sql, Conn);
            cmd.Parameters.AddWithValue("@username", username);
            var reader = await cmd.ExecuteReaderAsync();

            if (reader == null)
                throw new Exception("Une erreur est survenue");

            if(reader.HasRows && reader.FieldCount == 1)
                return reader["Password"].ToString();

            return null;
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
    }
}
