using System;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public class SqlManager
    {
        public const string dataBaseManager = "Manager";
        public const string managerConnectionString = "Data Source=Manager";
        public async void execute()
        {
            try
            {
                AppCreateDB();
            }
            catch (Exception)
            {

            }
        }
        private async void AppCreateDB()
        {
            if (!File.Exists(dataBaseManager))
            {
                SQLiteConnection.CreateFile(dataBaseManager);
                await AppCreateTable();
            }
        }

        private async Task<bool> CreateNewTables()
        {
            string[] tables = new string[]
            {

            };

            SQLiteConnection conexao = new SQLiteConnection(managerConnectionString);
            conexao.Open();
            try
            {
                for (int i = 0; i < tables.Count(); i++)
                {
                    SQLiteCommand command = new SQLiteCommand(tables[i], conexao);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
            conexao.Close();
            return true;
        }

        private async Task<bool> AppCreateTable()
        {
            string[] tables = new string[]
            {

                "CREATE TABLE vendas (" +
                "contrato VARCHAR(255), " +
                "status VARCHAR(255), " +
                "contrato VARCHAR(255))",
                "CREATE INDEX vendas_indexs ON users(contrato, status)",

            };

            SQLiteConnection conexao = new SQLiteConnection(managerConnectionString);
            conexao.Open();
            try
            {
                for (int i = 0; i < tables.Count(); i++)
                {
                    SQLiteCommand command = new SQLiteCommand(tables[i], conexao);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
            conexao.Close();
            return true;
        }
        public void ExecuteSqlCommand(string query)
        {
            try
            {
                SQLiteConnection conexao = new SQLiteConnection(managerConnectionString);
                conexao.Open();
                SQLiteCommand command = new SQLiteCommand(query, conexao);
                command.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
