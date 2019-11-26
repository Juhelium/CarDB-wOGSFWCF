
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;



namespace uyjk.model
{
    
    public class DatabaseController
    {
        
        SqlConnection dbYhteys = new SqlConnection();
        //private readonly object sqlDbType;
        //uyjk.CompositeType asia = new uyjk.CompositeType();
        
        public bool connectDatabase()
        {

            try
            {
                dbYhteys.ConnectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=autokauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                dbYhteys.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                dbYhteys.Close();
                return false;

            }

        }

        public int setidcount(int id)
        {
            
            Auto idcar = new Auto();
            id = idcar.Id;
            return id;
        }
        public void disconnectDatabase()
        {
            dbYhteys.Close();
        }

        public int saveAutoIntoDatabase(Auto newAuto)
        {
            //bool palaute = false;
            int affected = 0;
            try
            {
                using (dbYhteys) //(Hinta, Rekisteri_paivamaara, Moottorin_tilavuus, Mittarilukema, AutonMerkkiID, AutonMalliID, VaritID, PolttoaineID)
                {
                    connectDatabase();
                    string vie = "INSERT INTO auto VALUES(@hinta, @rekisteripav , @moottoritil, @mittariluk, @autonmerk, @autonmall, @varit, @polttoaine)";
                    
                    using (SqlCommand VieAuto = new SqlCommand(vie, dbYhteys))
                    {
                        VieAuto.Parameters.AddWithValue("@hinta", newAuto.Hinta);
                        VieAuto.Parameters.AddWithValue("@rekisteripav", newAuto.Pvm);
                        VieAuto.Parameters.AddWithValue("@moottoritil", newAuto.Mottoritila);
                        VieAuto.Parameters.AddWithValue("@mittariluk", newAuto.Mittarilukema);
                        VieAuto.Parameters.AddWithValue("@autonmerk", newAuto.Merkki);
                        VieAuto.Parameters.AddWithValue("@autonmall", newAuto.Malli);
                        VieAuto.Parameters.AddWithValue("@varit", newAuto.Color);
                        VieAuto.Parameters.AddWithValue("@polttoaine", newAuto.Fuel);
                        affected=VieAuto.ExecuteNonQuery();
                    }
                }
                //palaute = true;
            }
            catch (Exception ex)
            {
                //palaute = false;
                Console.WriteLine(ex);
            }
            
            return affected;
        }

        public List<Merkki> getAllAutoMakersFromDatabase()
        {
            List<Merkki> merkit = new List<Merkki>();

            using (dbYhteys)
            {
                connectDatabase();
                string query = "SELECT * FROM AutonMerkki";
                using (SqlCommand haemerkit = new SqlCommand(query, dbYhteys))
                {
                    using (SqlDataReader reader = haemerkit.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Merkki autonmerkki = new Merkki();
                            autonmerkki.Id = (int)reader.GetValue(0);
                            autonmerkki.Valmistaja = reader.GetString(1);
                            merkit.Add(autonmerkki);
                        }
                    }
                }
                disconnectDatabase();
            }
            return merkit;
        }

        public List<Malli> getAutoModelsByMakerId(int makerId)
        {
            makerId++;
            string hae = "SELECT * FROM AutonMallit WHERE AutonMerkkiID = @makerId";
            List<Malli> mallit = new List<Malli>();
            using (dbYhteys)
            {
                connectDatabase();
                using (SqlCommand haemallit = new SqlCommand(hae, dbYhteys))
                {
                    haemallit.Parameters.AddWithValue("@makerId", makerId);
                    using (SqlDataReader reader = haemallit.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            Malli autonmalli = new Malli();
                            autonmalli.MalliId = (int)reader.GetValue(0);
                            autonmalli.Malliname = reader.GetString(1);
                            mallit.Add(autonmalli);
                        }
                    }
                }
            }
            return mallit;
        }
        public List<polttoaine> GetAutoFuels(int id)
        {
            string hae = "SELECT * FROM Polttoaine";
            List<polttoaine> polttoaineet = new List<polttoaine>();
            using (dbYhteys)
            {
                connectDatabase();
                using (SqlCommand haepolttoaineet = new SqlCommand(hae, dbYhteys))
                {
                    using (SqlDataReader reader = haepolttoaineet.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            polttoaine autonpolttoaine = new polttoaine();
                            autonpolttoaine.FuelId = (int)reader.GetValue(0);
                            autonpolttoaine.FuelName = reader.GetString(1);
                            polttoaineet.Add(autonpolttoaine);
                        }
                    }
                }
            }
            return polttoaineet;
        }
        public List<vari> GetAutoColors()
        {
            string hae = "SELECT * FROM Varit";
            List<vari> autonvarit = new List<vari>();
            using (dbYhteys)
            {
                connectDatabase();
                using (SqlCommand haevarit = new SqlCommand(hae, dbYhteys))
                {
                    using (SqlDataReader reader = haevarit.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            vari autonvari = new vari();
                            autonvari.ColorId = (int)reader.GetValue(0);
                            autonvari.ColorName = reader.GetString(1);
                            autonvarit.Add(autonvari);
                        }
                    }
                }
            }
            return autonvarit;
        }
        public Auto GetNextAuto(int carid)
        {
            Auto autoni = new Auto();
            using (dbYhteys)
            {
                connectDatabase();
                string hae = "SELECT TOP 1 * FROM auto WHERE ID > @id";
                SqlCommand haeauto = new SqlCommand(hae, dbYhteys);
                haeauto.Parameters.AddWithValue("@id", carid);
                SqlDataReader reader = haeauto.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    autoni.Id = (int)reader.GetValue(0);
                    autoni.Hinta = (decimal)reader.GetValue(1);
                    autoni.Pvm = (DateTime)reader.GetValue(2);
                    autoni.Mottoritila = (decimal)reader.GetValue(3);
                    autoni.Mittarilukema = (int)reader.GetValue(4);
                    autoni.Merkki = (int)reader.GetValue(5);
                    autoni.Malli = (int)reader.GetValue(6);
                    autoni.Color = (int)reader.GetValue(7);
                    autoni.Fuel = (int)reader.GetValue(8);
                }
                else if (!reader.HasRows)
                {
                    reader.Close();
                    string haku = "SELECT TOP 1 * FROM auto";
                    SqlCommand haeEka = new SqlCommand(haku, dbYhteys);
                    SqlDataReader lukija = haeEka.ExecuteReader();
                    lukija.Read();
                    if (lukija.HasRows)
                    {
                        autoni.Id = (int)lukija.GetValue(0);
                        autoni.Hinta = (decimal)lukija.GetValue(1);
                        autoni.Pvm = (DateTime)reader.GetValue(2);
                        autoni.Mottoritila = (decimal)lukija.GetValue(3);
                        autoni.Mittarilukema = (int)lukija.GetValue(4);
                        autoni.Merkki = (int)lukija.GetValue(5);
                        autoni.Malli = (int)lukija.GetValue(6);
                        autoni.Color = (int)lukija.GetValue(7);
                        autoni.Fuel = (int)lukija.GetValue(8);
                    }
                }
            }
            return autoni;
        }

        public Auto GetPrevious(int carid)
        {
            Auto autoni = new Auto();
            using (dbYhteys)
            {
                connectDatabase();
                string hae = "SELECT TOP 1 * FROM auto WHERE ID < @id ORDER BY ID desc";
                SqlCommand haeauto = new SqlCommand(hae, dbYhteys);
                haeauto.Parameters.AddWithValue("@id", carid);
                SqlDataReader reader = haeauto.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    autoni.Id = (int)reader.GetValue(0);
                    autoni.Hinta = (decimal)reader.GetValue(1);
                    autoni.Pvm = (DateTime)reader.GetValue(2);
                    autoni.Mottoritila = (decimal)reader.GetValue(3);
                    autoni.Mittarilukema = (int)reader.GetValue(4);
                    autoni.Merkki = (int)reader.GetValue(5);
                    autoni.Malli = (int)reader.GetValue(6);
                    autoni.Color = (int)reader.GetValue(7);
                    autoni.Fuel = (int)reader.GetValue(8);
                }
                else if (!reader.HasRows)
                {
                    reader.Close();
                    //SELECT TOP 1 * FROM Table ORDER BY ID DESC
                    string haku = "SELECT TOP 1 * FROM auto ORDER BY ID DESC";
                    SqlCommand haevika = new SqlCommand(haku, dbYhteys);
                    SqlDataReader lukija = haevika.ExecuteReader();
                    lukija.Read();
                    if (lukija.HasRows)
                    {
                        autoni.Id = (int)lukija.GetValue(0);
                        autoni.Hinta = (decimal)lukija.GetValue(1);
                        autoni.Pvm = (DateTime)reader.GetValue(2);
                        autoni.Mottoritila = (decimal)lukija.GetValue(3);
                        autoni.Mittarilukema = (int)lukija.GetValue(4);
                        autoni.Merkki = (int)lukija.GetValue(5);
                        autoni.Malli = (int)lukija.GetValue(6);
                        autoni.Color = (int)lukija.GetValue(7);
                        autoni.Fuel = (int)lukija.GetValue(8);
                    }
                }
            }
            return autoni;
        }

        public int DeleteCar(int carId)
        {
            int affected = 0;
            using (dbYhteys)
            {
                connectDatabase();
                string del = "DELETE FROM auto WHERE ID=@id";
                SqlCommand delete = new SqlCommand(del, dbYhteys);
                delete.Parameters.AddWithValue("@id",carId);
                affected = delete.ExecuteNonQuery();
            }
            return affected;
        }
        public Auto HaeMerkkiJaMalliJaVariJaPolttoaine(int merkki, int malli, int vari, int polttoaine)
        {
            Auto auto2 = new Auto();
            using (dbYhteys)
            {
                connectDatabase();
                string hae = "SELECT * FROM AutonMerkki WHERE ID = @merkki";
                using (SqlCommand findmerkki = new SqlCommand(hae, dbYhteys))
                {
                    findmerkki.Parameters.AddWithValue("@merkki", merkki);
                    using (SqlDataReader reader = findmerkki.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            auto2.Merkki = (int)reader["0"];
                        }
                    }
                }
                hae = "SELECT * FROM AutonMallit WHERE ID = @malli";
                using (SqlCommand findmalli = new SqlCommand(hae, dbYhteys))
                {
                    findmalli.Parameters.AddWithValue("@malli", malli);
                    using (SqlDataReader reader = findmalli.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            auto2.Malli = (int)reader["0"];
                        }
                    }
                }
                hae = "SELECT * FROM Varit WHERE ID = @vari";
                using (SqlCommand findvari = new SqlCommand(hae, dbYhteys))
                {
                    findvari.Parameters.AddWithValue("@vari", vari);
                    using (SqlDataReader reader = findvari.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            auto2.Color = (int)reader["0"];
                        }
                    }
                }
                hae = "SELECT * FROM Polttoaine WHERE ID = @polttoaine";
                using (SqlCommand findvari = new SqlCommand(hae, dbYhteys))
                {
                    findvari.Parameters.AddWithValue("@polttoaine", polttoaine);
                    using (SqlDataReader reader = findvari.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            auto2.Fuel = (int)reader["0"];
                        }
                    }
                }
            }
            return auto2;
        }
    }
}


