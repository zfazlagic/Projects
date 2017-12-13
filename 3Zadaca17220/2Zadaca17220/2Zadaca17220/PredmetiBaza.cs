using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;

namespace _2Zadaca17220
{
  public  class PredmetiBaza
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

        public PredmetiBaza() { }

        //Ucitavanje predmeta iz baze podataka
        public void UcitajBachelora()
        {

            OracleCommand command = new OracleCommand("SELECT * FROM Predmeti", konekcija);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Predmeti s = new Predmeti();
                    s.idp = reader.GetInt32(0);
                    s.naziv = reader.GetString(1);
                    s.ects = reader.GetInt32(2);
                    s.max = reader.GetInt32(3);
                    s.brP = reader.GetInt32(4);
                    s.brV = reader.GetInt32(5);
                   
                    Fakultet.predmetttt.Add(s);
                }
            }

        }

        //brise zaposlenika iz baze sa indexom u listi
        public int obrisiBachelora(int index)
        {
            try
            {
                OracleCommand cmd = konekcija.CreateCommand();
                string sqlDelete = "delete from Predmeti where sifra_predmeta= :sifra";
                cmd.CommandText = sqlDelete;

                OracleParameter sifra = new OracleParameter();
                sifra.Value = Fakultet.predmetttt[index].idp;
                sifra.ParameterName = "sifra";
                cmd.Parameters.Add(sifra);
                int k = cmd.ExecuteNonQuery();
                cmd.Dispose();
                Fakultet.predmetttt.RemoveAt(index);
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
                string sqlInsert = "update Predmeti set Ime=:k_Ime, ecta=:ects, max_studenti:max,"
                    + "broj_predavanja=:brp,broj_vjezbi=:brv";
                cmd.CommandText = sqlInsert;
              

                OracleParameter k_Ime = new OracleParameter();
                k_Ime.Value = Fakultet.predmetttt[index].naziv;
                k_Ime.ParameterName = "k_Ime";

                OracleParameter ects = new OracleParameter();
                ects.Value = Fakultet.predmetttt[index].ects;
                ects.ParameterName = "ects";

                OracleParameter max = new OracleParameter();
                max.Value = Fakultet.predmetttt[index].max;
                max.ParameterName = "max";

                OracleParameter brp = new OracleParameter();
                brp.Value = Fakultet.predmetttt[index].brP;
                brp.ParameterName = "brp";

                OracleParameter brv = new OracleParameter();
                brv.Value = Fakultet.predmetttt[index].brV;
                brv.ParameterName = "brv";

               


                cmd.Parameters.Add(k_Ime);
                cmd.Parameters.Add(ects);
                cmd.Parameters.Add(max);
                cmd.Parameters.Add(brp);
                cmd.Parameters.Add(brv);
           
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
        public int spasiStudentaBachelora(Predmeti p)
        {
           


            OracleCommand cmd = konekcija.CreateCommand();
            string sqlInsert = "insert into studenti (ime,ects,max_studenti,broj_predavanja,broj_vjezbi) ";
            sqlInsert += "values (:s2.nextval, :ime, :ects, :max, :brp, :brv)";
            cmd.CommandText = sqlInsert;


            OracleParameter ime = new OracleParameter();
            ime.Value = p.naziv;
            ime.ParameterName = "ime";

            OracleParameter ects = new OracleParameter();
            ects.Value = p.ects;
            ects.ParameterName = "ects";

            OracleParameter max = new OracleParameter();
            max.Value = p.max;
            max.ParameterName = "max";

            OracleParameter brp = new OracleParameter();
            brp.Value = p.brP;
            brp.ParameterName = "brp";

            OracleParameter brv = new OracleParameter();
            brv.Value = p.brV;
            brv.ParameterName = "brv";
            
            cmd.Parameters.Add(ime);
            cmd.Parameters.Add(ects);
            cmd.Parameters.Add(max);
            cmd.Parameters.Add(brp);
            cmd.Parameters.Add(brv);
           
            int k = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return k;

        }
        public void dataSetPrimjer()
        {
            dataAdapter = new OracleDataAdapter("SELECT * FROM predmeti", konekcija);
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
            cmd.CommandText = "DROP TABLE predmeti";
            cmd.ExecuteNonQuery();
            cmd = konekcija.CreateCommand();
            cmd.CommandText = "DROP SEQUENCE ss ";
            cmd.ExecuteNonQuery();
        }
    }
}
