using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager_FL_MG_JW
{
    internal class createDBIfNotCreated()
    {
        public static void CreateDB()
        {
            string dbPfad = Path.Combine(Application.StartupPath, "contactManagerDB.db");
            if (!File.Exists(dbPfad))
            {
                SQLiteConnection.CreateFile(dbPfad);
            }

            using (var connection = new SQLiteConnection($"Data Source={dbPfad};Version=3;"))
            {
                connection.Open();

                string createTableSql = @"
                       CREATE TABLE IF NOT EXISTS Global (
                        Anrede TEXT,
                        Titel TEXT,
                        Vorname TEXT,
                        Name TEXT,
                        Geschlecht TEXT,
                        `E-Mail` TEXT,
                        Geburtstag INTEGER,
                        Status TEXT
                );";

                var command = new SQLiteCommand(createTableSql, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
