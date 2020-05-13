using S10.DataAccessLayer.Interfaces;
using S10.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10.DataAccessLayer.Implementations
{
    public class TahDao : ITahDao, IDisposable
    {
        private readonly SQLiteConnection sqLiteConnection;

        public TahDao(string connection)
        {
            sqLiteConnection = new SQLiteConnection(connection);
            sqLiteConnection.Open();
        }

        public void VytvorTabulku()
        {
            SQLiteCommand prikaz = sqLiteConnection.CreateCommand();
            prikaz.CommandText = @"CREATE TABLE 'Tah' (
                'Id' INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE, 'Datum' Text NULL,
                'Cislo1' INTEGER NULL, 'Cislo2' INTEGER NULL, 'Cislo3' INTEGER NULL, 'Cislo4' INTEGER NULL,
                'Cislo5' INTEGER NULL, 'Cislo6' INTEGER NULL, 'Cislo7' INTEGER NULL, 'Cislo8' INTEGER NULL,
                'Cislo9' INTEGER NULL, 'Cislo10' INTEGER NULL, 'Cislo11' INTEGER NULL, 'Cislo12' INTEGER NULL,
                'Cislo13' INTEGER NULL, 'Cislo14' INTEGER NULL, 'Cislo15' INTEGER NULL, 'Cislo16' INTEGER NULL,
                'Cislo17' INTEGER NULL, 'Cislo18' INTEGER NULL, 'Cislo19' INTEGER NULL, 'Cislo20' INTEGER NULL
                ); ";

            prikaz.ExecuteNonQuery();
        }

        /// <summary>
        /// Uloží 20 čísel tahu, snaží se použít update, pokud nenajde používá insert
        /// </summary>
        public void Uloz(Tah tah)
        {
            if (tah.Datum == null)
            {
                tah.Datum = DateTime.Now.Date.ToString().Split(' ')[0];
            }

            SQLiteCommand prikaz = sqLiteConnection.CreateCommand();
            prikaz.Parameters.Add(new SQLiteParameter("@Id", tah.Id));
            prikaz.Parameters.Add(new SQLiteParameter("@Datum", tah.Datum));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo1", tah.Cislo1));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo2", tah.Cislo2));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo3", tah.Cislo3));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo4", tah.Cislo4));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo5", tah.Cislo5));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo6", tah.Cislo6));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo7", tah.Cislo7));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo8", tah.Cislo8));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo9", tah.Cislo9));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo10", tah.Cislo10));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo11", tah.Cislo11));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo12", tah.Cislo12));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo13", tah.Cislo13));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo14", tah.Cislo14));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo15", tah.Cislo15));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo16", tah.Cislo16));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo17", tah.Cislo17));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo18", tah.Cislo18));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo19", tah.Cislo19));
            prikaz.Parameters.Add(new SQLiteParameter("@Cislo20", tah.Cislo20));

            //Update
            prikaz.CommandText = @"UPDATE Tah SET Datum = @Datum, Cislo1 = @Cislo1, Cislo2 = @Cislo2, Cislo3 = @Cislo3, Cislo4 = @Cislo4, Cislo5 = @Cislo5, 
                Cislo6 = @Cislo6, Cislo7 = @Cislo7, Cislo8 = @Cislo8, Cislo9 = @Cislo9, Cislo10 = @Cislo10, Cislo11 = @Cislo11, Cislo12 = @Cislo12,
                Cislo13 = @Cislo13, Cislo14 = @Cislo14, Cislo15 = @Cislo15, Cislo16 = @Cislo16, Cislo17 = @Cislo17, Cislo18 = @Cislo18, 
                Cislo19 = @Cislo19, Cislo20 = @Cislo20 WHERE Id = @Id; ";
            int upraveno = prikaz.ExecuteNonQuery();

            if (upraveno < 1)
            {
                //Insert
                prikaz.CommandText = @"INSERT INTO Tah (Datum, Cislo1, Cislo2, Cislo3, Cislo4, Cislo5, Cislo6, Cislo7, Cislo8, Cislo9, Cislo10, Cislo11, 
                    Cislo12, Cislo13, Cislo14, Cislo15, Cislo16, Cislo17, Cislo18, Cislo19, Cislo20) VALUES (@Datum, @Cislo1, @Cislo2, @Cislo3, @Cislo4, 
                    @Cislo5, @Cislo6, @Cislo7, @Cislo8, @Cislo9, @Cislo10, @Cislo11, @Cislo12, @Cislo13, @Cislo14, @Cislo15, @Cislo16, @Cislo17, 
                    @Cislo18, @Cislo19, @Cislo20); ";
                prikaz.ExecuteNonQuery();

                prikaz.CommandText = "select last_insert_rowid()";      //Navrácení posledního vloženého id
                tah.Id = (Int64)prikaz.ExecuteScalar();
            }
        }

        public Tah DejPodleId(long idTahu)
        {
            Tah tah = new Tah();

            SQLiteCommand prikaz = sqLiteConnection.CreateCommand();
            prikaz.CommandText = "SELECT * FROM Tah WHERE Id = @IdTahu; ";
            prikaz.Parameters.Add(new SQLiteParameter("@IdTahu", idTahu));

            using (SQLiteDataReader reader = prikaz.ExecuteReader())
            {
                reader.Read();  //stačí pouze jeden záznam
                tah = reader.GetTah();
            }

            return tah;
        }

        /// <summary>
        /// Navrátí všechny 
        /// </summary>
        public IList<Tah> DejVsechny()
        {
            IList<Tah> tahy = new List<Tah>();

            SQLiteCommand prikaz = sqLiteConnection.CreateCommand();
            prikaz.CommandText = "SELECT * FROM Tah ORDER BY Id DESC";

            using (SQLiteDataReader reader = prikaz.ExecuteReader())
            {
                while (reader.Read())
                {
                    tahy.Add(reader.GetTah());
                }
            }

            return tahy;
        }

        public int SmazPodleId(long idTahu) //TODO vytvořit hromadné mazání podle pole ids
        {
            SQLiteCommand prikaz = sqLiteConnection.CreateCommand();
            prikaz.CommandText = @"DELETE FROM Tah WHERE Id = @Id; ";
            prikaz.Parameters.Add(new SQLiteParameter("@Id", idTahu));
            
            return prikaz.ExecuteNonQuery();
        }

        public void Dispose()
        {
            sqLiteConnection.Close();
        }
    }

    public static class TahDaoExtensions
    {
        public static Tah GetTah(this SQLiteDataReader reader)
        {
            Tah tah = new Tah();
            tah.Id = reader.GetInt64(0);
            tah.Datum = reader.GetString(1);
            tah.Cislo1 = reader.SafeGetInt32(2);
            tah.Cislo2 = reader.SafeGetInt32(3);
            tah.Cislo3 = reader.SafeGetInt32(4);
            tah.Cislo4 = reader.SafeGetInt32(5);
            tah.Cislo5 = reader.SafeGetInt32(6);
            tah.Cislo6 = reader.SafeGetInt32(7);
            tah.Cislo7 = reader.SafeGetInt32(8);
            tah.Cislo8 = reader.SafeGetInt32(9);
            tah.Cislo9 = reader.SafeGetInt32(10);
            tah.Cislo10 = reader.SafeGetInt32(11);
            tah.Cislo11 = reader.SafeGetInt32(12);
            tah.Cislo12 = reader.SafeGetInt32(13);
            tah.Cislo13 = reader.SafeGetInt32(14);
            tah.Cislo14 = reader.SafeGetInt32(15);
            tah.Cislo15 = reader.SafeGetInt32(16);
            tah.Cislo16 = reader.SafeGetInt32(17);
            tah.Cislo17 = reader.SafeGetInt32(18);
            tah.Cislo18 = reader.SafeGetInt32(19);
            tah.Cislo19 = reader.SafeGetInt32(20);
            tah.Cislo20 = reader.SafeGetInt32(21);

            return tah;
        }

        public static int? SafeGetInt32(this SQLiteDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetInt32(colIndex);

            return null;
        }
    }
}
