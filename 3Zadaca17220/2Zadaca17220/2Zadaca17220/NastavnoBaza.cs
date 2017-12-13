using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;

namespace _2Zadaca17220
{
  public  class NastavnoBaza
    {
        OracleConnection konekcija;
        OracleDataReader reader;
        DataSet dataSet;
        OracleDataAdapter dataAdapter;

        public OracleDataAdapter DataAdapter
        {
            get { return dataAdapter; }
            set { dataAdapter = value; }
        }
        public DataSet DataSet
        {
            get { return dataSet; }
            set { dataSet = value; }
        }

        public NastavnoBaza() { }

        //Ucitavanje bachelora iz baze podataka
        public void UcitajBachelora()
        {

            OracleCommand command = new OracleCommand("SELECT * FROM nastavnici", konekcija);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    StalnoZaposleni s = new StalnoZaposleni();
                    s.sifra = reader.GetInt32(0);
                    s.ime = reader.GetString(1);
                    s.prezime = reader.GetString(2);
                    s.titula = reader.GetString(3);
                    s.pozicija = reader.GetString(4);
                    s.strucna = reader.GetString(5);
                    s.username = reader.GetString(6);
                    s.password = reader.GetString(7);
                    Fakultet.nastavno.Add(s);
                }
            }

        }

        //brise zaposlenika iz baze sa indexom u listi
        public int obrisiBachelora(int index)
        {
            try
            {
                OracleCommand cmd = konekcija.CreateCommand();
                string sqlDelete = "delete from nastavnici where sifra= :sifra";
                cmd.CommandText = sqlDelete;

                OracleParameter sifra = new OracleParameter();
                sifra.Value = Fakultet.nastavno[index].sifra;
                sifra.ParameterName = "sifra";
                cmd.Parameters.Add(sifra);
                int k = cmd.ExecuteNonQuery();
                cmd.Dispose();
                Fakultet.nastavno.RemoveAt(index);
                return k;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //salje se id studenta iz baze
        public int editZaposlenika(int index)
        {
            try
            {
                OracleCommand cmd = konekcija.CreateCommand();
                string sqlInsert = "update nastavnici set Ime=:k_Ime, Prezime=:k_Prezime,sifra=:sifra,"
                    + "titula=:titula, Username=:k_Username,Password=:k_Password,pozicija=:pozicija,strucna=strucna where sifra=:sifra ";
                cmd.CommandText = sqlInsert;
                OracleParameter sifra = new OracleParameter();
                sifra.Value = Fakultet.nastavno[index].sifra;
                sifra.ParameterName = "sifra";

                OracleParameter k_Ime = new OracleParameter();
                k_Ime.Value = Fakultet.nastavno[index].ime;
                k_Ime.ParameterName = "k_Ime";

                OracleParameter k_p = new OracleParameter();
                k_p.Value = Fakultet.nastavno[index].prezime;
                k_p.ParameterName = "k_Prezime";

                OracleParameter titula = new OracleParameter();
                titula.Value = Fakultet.nastavno[index].titula;
                titula.ParameterName = "titula";

                OracleParameter pozicija = new OracleParameter();
                pozicija.Value = Fakultet.nastavno[index].pozicija;
                pozicija.ParameterName = "pozicija";

                OracleParameter k_Username = new OracleParameter();
                k_Username.Value = Fakultet.nastavno[index].username;
                k_Username.ParameterName = "k_Username";

                OracleParameter k_Password = new OracleParameter();
                k_Password.Value = Fakultet.nastavno[index].password;
                k_Password.ParameterName = "k_Password";

                OracleParameter strucna = new OracleParameter();
                strucna.Value = Fakultet.nastavno[index].strucna;
                strucna.ParameterName = "strucna";


                cmd.Parameters.Add(k_Ime);
                cmd.Parameters.Add(k_p);
                cmd.Parameters.Add(sifra);
                cmd.Parameters.Add(titula);
                cmd.Parameters.Add(k_Username);
                cmd.Parameters.Add(k_Password);
                cmd.Parameters.Add(pozicija);
                cmd.Parameters.Add(strucna);
                int k = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return k;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void otvoriKonekciju()
        {
            try
            {
                konekcija = new OracleConnection();
                konekcija.ConnectionString = @"Data Source=
                (DESCRIPTION =
                        (ADDRESS = (PROTOCOL = TCP)(HOST = 80.65.65.66)(PORT = 1521))
                        (CONNECT_DATA =
                        (SERVER = DEDICATED)
                        (SERVICE_NAME = etflab.db.lab.etf.unsa.ba)
    
                        )
                    );
                User Id= zf17220;
                Password= ntplv8HT;
                Persist Security Info=True;";
                konekcija.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void zatvoriKonekciju()
        {
            try
            {
                konekcija.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int spasiStudentaBachelora(StalnoZaposleni s)
        {



            OracleCommand cmd = konekcija.CreateCommand();
            string sqlInsert = "insert into studenti (Ime, Prezime, sifra, titula, Username,Password,pozicija,strucna) ";
            sqlInsert += "values (:ime, :prezime, :sifra, :titula, :k_Username, :k_Password, :pozicija, :strucna)";
            cmd.CommandText = sqlInsert;


            OracleParameter sifra = new OracleParameter();
            sifra.Value =s .sifra;
            sifra.ParameterName = "sifra";

            OracleParameter k_Ime = new OracleParameter();
            k_Ime.Value = s.ime;
            k_Ime.ParameterName = "ime";

            OracleParameter k_p = new OracleParameter();
            k_p.Value = s.prezime;
            k_p.ParameterName = "prezime";

            OracleParameter titula = new OracleParameter();
            titula.Value = s.titula;
            titula.ParameterName = "titula";

            OracleParameter pozicija = new OracleParameter();
            pozicija.Value = s.pozicija;
            pozicija.ParameterName = "pozicija";

            OracleParameter k_Username = new OracleParameter();
            k_Username.Value = s.username;
            k_Username.ParameterName = "k_Username";

            OracleParameter k_Password = new OracleParameter();
            k_Password.Value = s.password;
            k_Password.ParameterName = "k_Password";

            OracleParameter strucna = new OracleParameter();
            strucna.Value = s.strucna;
            strucna.ParameterName = "strucna";
            cmd.Parameters.Add(k_Ime);
            cmd.Parameters.Add(k_p);
            cmd.Parameters.Add(sifra);
            cmd.Parameters.Add(titula);
            cmd.Parameters.Add(k_Username);
            cmd.Parameters.Add(k_Password);
            cmd.Parameters.Add(pozicija);
            cmd.Parameters.Add(strucna);
            int k = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return k;

        }
        public void dataSetPrimjer()
        {
            dataAdapter = new OracleDataAdapter("SELECT * FROM nastavnici", konekcija);
            OracleCommandBuilder builder = new OracleCommandBuilder(dataAdapter);
            dataAdapter.InsertCommand = builder.GetInsertCommand();
            dataAdapter.UpdateCommand = builder.GetUpdateCommand();
            dataAdapter.DeleteCommand = builder.GetDeleteCommand();


            DataSet = new DataSet();
            dataAdapter.Fill(DataSet);
        }

      
        public void obrisiTabele()
        {
            //pocistiti bazu prije zavrsetka programa
            OracleCommand cmd = konekcija.CreateCommand();
            cmd.CommandText = "DROP TABLE nastavnici";
            cmd.ExecuteNonQuery();
            cmd = konekcija.CreateCommand();
            cmd.CommandText = "DROP SEQUENCE sek ";
            cmd.ExecuteNonQuery();
        }
    }
}
