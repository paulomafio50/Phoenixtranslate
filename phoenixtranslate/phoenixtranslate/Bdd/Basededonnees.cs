using System.Data.SQLite;
using System;
namespace phoenixtranslate.Bdd
{
    public class Basededonnees 
    {
        public Basededonnees()
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=Bdd\\bDD.db; Version = 3; New = True; Compress = True; ");
             string motfr= "";
             string moteng= "";
           
        }


     public static void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE SampleTable(Col1 VARCHAR(20), Col2 INT)";
           string Createsql1 = "CREATE TABLE SampleTable1(Col1 VARCHAR(20), Col2 INT)";
           sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();

        }

        public static void InsertData(SQLiteConnection conn,string motfr, string moteng)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            
            sqlite_cmd.CommandText = "INSERT INTO Traduction(Francais, Anglais) VALUES("+motfr+", "+moteng+"); ";
           sqlite_cmd.ExecuteNonQuery();

           
        }

        public static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Traduction";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader);
            }
            conn.Close();
        }
    }
}
    

    