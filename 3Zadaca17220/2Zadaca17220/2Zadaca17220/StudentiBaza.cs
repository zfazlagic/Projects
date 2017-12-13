using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;

namespace _2Zadaca17220
{
  public  class StudentiBaza
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

        public StudentiBaza() { }

        //Ucitavanje bachelora iz baze podataka
        public void UcitajBachelora()
        {

            OracleCommand command = new OracleCommand("SELECT * FROM studenti", konekcija);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    StudentBachelor s = new StudentBachelor();
                    s.index = reader.GetString(0);
                    s.ime = reader.GetString(1);
                    s.prezime = reader.GetString(2);
                    s.DatumRodjenja = Convert.ToDateTime(reader.GetString(3));
                    s.DZavrsetka = Convert.ToDateTime(reader.GetString(4));
                    s.DatumUpisa = Convert.ToDateTime(reader.GetString(5));
                    s.username = reader.GetString(6);
                    s.password = reader.GetString(7);
                    Fakultet.studenti.Add(s);
                }
            }

        }

        //brise zaposlenika iz baze sa indexom u listi
        public int obrisiBachelora(int index)
        {
            try
            {
                OracleCommand cmd = konekcija.CreateCommand();
                string sqlDelete = "delete from studenti where broj_indexa= :broj_indexa";
                cmd.CommandText = sqlDelete;

                OracleParameter broj_indexa = new OracleParameter();
                broj_indexa.Value = Fakultet.studenti[index].index;
                broj_indexa.ParameterName = "broj_indexa";
                cmd.Parameters.Add(broj_indexa);
                int k = cmd.ExecuteNonQuery();
                cmd.Dispose();
                Fakultet.studenti.RemoveAt(index);
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
                string sqlInsert = "update studenti set Ime=:k_Ime, Prezime=:k_Prezime, Broj_indexa=:broj_indexa,"
                    + " Datum_rodjenja=:Datum_rodjenja, Username=:k_Username,Password=:k_Password,Datum_zavrsetka=:Datum_zavrsetka,Datum_upisa=Datum_upisa where Broj_indexa=:Broj_indexa ";
                cmd.CommandText = sqlInsert;
                OracleParameter broj_indexa = new OracleParameter();
                broj_indexa.Value = Fakultet.studenti[index].index;
                broj_indexa.ParameterName = "broj_indexa";

                OracleParameter k_Ime = new OracleParameter();
                k_Ime.Value = Fakultet.studenti[index].ime;
                k_Ime.ParameterName = "k_Ime";

                OracleParameter k_p = new OracleParameter();
                k_p.Value = Fakultet.studenti[index].prezime;
                k_p.ParameterName = "k_Prezime";

                OracleParameter Datum_zavrsetka = new OracleParameter();
                Datum_zavrsetka.Value = Fakultet.studenti[index].DZavrsetka;
                Datum_zavrsetka.ParameterName = "Datum_zavrsetka";

                OracleParameter Datum_upisa = new OracleParameter();
                Datum_upisa.Value = Fakultet.studenti[index].DatumUpisa;
                Datum_upisa.ParameterName = "Datum_upisa";

                OracleParameter k_Username = new OracleParameter();
                k_Username.Value = Fakultet.studenti[index].username;
                k_Username.ParameterName = "k_Username";

                OracleParameter k_Password = new OracleParameter();
                k_Password.Value = Fakultet.studenti[index].password;
                k_Password.ParameterName = "k_Password";

                OracleParameter k_DatumRodjenja = new OracleParameter();
                k_DatumRodjenja.Value = Fakultet.studenti[index].DatumRodjenja;
                k_DatumRodjenja.ParameterName = "Datum_rodjenja";


                cmd.Parameters.Add(k_Ime);
                cmd.Parameters.Add(k_p);
                cmd.Parameters.Add(Datum_upisa);
                cmd.Parameters.Add(Datum_zavrsetka);
                cmd.Parameters.Add(k_Username);
                cmd.Parameters.Add(k_Password);
                cmd.Parameters.Add(k_DatumRodjenja);
                cmd.Parameters.Add(broj_indexa);
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
        public int spasiStudentaBachelora(StudentBachelor studentb)
        {
          


            OracleCommand cmd = konekcija.CreateCommand();
            string sqlInsert = "insert into studenti (Ime, Prezime, Broj_indexa, Datum_rodjenja, Username,Password,Datum_zavrsetka,Datum_upisa) ";
            sqlInsert += "values (:ime, :prezime, :index, :datumrodj, :k_Username, :k_Password, :datumzav, :datumup)";
            cmd.CommandText = sqlInsert;


            OracleParameter ime = new OracleParameter();
            ime.Value = studentb.ime;
            ime.ParameterName = "ime";

            OracleParameter prezime = new OracleParameter();
            prezime.Value = studentb.prezime;
            prezime.ParameterName = "prezime";

            OracleParameter index = new OracleParameter();
            index.Value = studentb.index;
            index.ParameterName = "index";

            OracleParameter datumrodj = new OracleParameter();
            datumrodj.Value = studentb.DatumRodjenja;
            datumrodj.ParameterName = "datumrodj";

            OracleParameter k_Username = new OracleParameter();
            k_Username.Value = studentb.username;
            k_Username.ParameterName = "k_Username";

            OracleParameter k_Password = new OracleParameter();
            k_Password.Value = studentb.password;
            k_Password.ParameterName = "k_Password";

            OracleParameter datumzav = new OracleParameter();
            datumzav.Value = studentb.DZavrsetka;
            datumzav.ParameterName = "datumzav";

            OracleParameter datmup = new OracleParameter();
            datmup.Value = studentb.DatumUpisa;
            datmup.ParameterName = "datumup";
            cmd.Parameters.Add(ime);
            cmd.Parameters.Add(prezime);
            cmd.Parameters.Add(index);
            cmd.Parameters.Add(datumrodj);
            cmd.Parameters.Add(k_Username);
            cmd.Parameters.Add(k_Password);
            cmd.Parameters.Add(datumzav);
            cmd.Parameters.Add(datmup);
            int k = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return k;
        
    }
    public void dataSetPrimjer()
    {
        dataAdapter = new OracleDataAdapter("SELECT * FROM studenti", konekcija);
        OracleCommandBuilder builder = new OracleCommandBuilder(dataAdapter);
        dataAdapter.InsertCommand = builder.GetInsertCommand();
        dataAdapter.UpdateCommand = builder.GetUpdateCommand();
        dataAdapter.DeleteCommand = builder.GetDeleteCommand();


        DataSet = new DataSet();
        dataAdapter.Fill(DataSet);
    }

        public void kreirajPocetneTabele()
        {
            //sekvenca koja id inkrementuje za 1
            OracleCommand cmd = konekcija.CreateCommand();
            cmd.CommandText = "CREATE SEQUENCE SequenceTest_Sequence " +
                        "START WITH 1 INCREMENT BY 1";
            cmd.ExecuteNonQuery();
            cmd = konekcija.CreateCommand();
            //kreiranje tabele
            cmd.CommandText = "CREATE TABLE studenti(broj_indexa varchar2(20) PRIMARY KEY not null,ime varchar2(20) not null,prezime varchar2(20) not null,datum_rodjenja date not null,datum_zavrsetka date not null,datum_upisa date not null, mjesto zavrsetka varchar2(20),username varchar2(20),password varchar2(20),id number)";
            cmd.ExecuteNonQuery();
            cmd = konekcija.CreateCommand();
            //trigger koji koristi sekvencu
            cmd.CommandText = "CREATE OR REPLACE TRIGGER trigger_name BEFORE INSERT ON studenti FOR EACH ROW BEGIN :new.id := SequenceTest_Sequence.nextval;END;";
            cmd.ExecuteNonQuery();
        }
        public void obrisiTabele()
        {
            //pocistiti bazu prije zavrsetka programa
            OracleCommand cmd = konekcija.CreateCommand();
            cmd.CommandText = "DROP TABLE studenti";
            cmd.ExecuteNonQuery();
            cmd = konekcija.CreateCommand();
            cmd.CommandText = "DROP SEQUENCE SequenceTest_Sequence ";
            cmd.ExecuteNonQuery();
        }
    }
}
