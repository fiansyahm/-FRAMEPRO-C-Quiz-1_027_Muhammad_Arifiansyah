using System.Data.SqlServerCe;

namespace MyDreamStartUp.Db
{
    public class DBConnection
    {
        public SqlCeConnection? conn;
        public DBConnection()
        {
            //constructor
        }
        ~DBConnection()
        {
            //destructor
            conn = null;
        }
        public void Disconnect()
        {
            conn.Close();
        }
        public string ConnectToDatabase()
        {
            try
            {
                conn = new SqlCeConnection(@"Data Source=DESKTOP-DLSRO9G\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True");
                conn.Open();
                return "Connected";
            }
            catch (SqlCeException e)
            {
                conn = null;
                return e.Message;
            }
        }
    }
}