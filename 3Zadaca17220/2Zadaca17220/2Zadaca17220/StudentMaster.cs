using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Zadaca17220
{
    [Serializable]
    public class StudentMaster : Student
    {
        public string MjestoZavrsetka { get; set; }

        public StudentMaster() { }
        public StudentMaster(string ime, string prezime, DateTime datumr) : base(ime, prezime, datumr){ }



        public override string DodijeliIndex(int b)
        {

            int n = 100;
            b += n;
            index = Convert.ToString(b) + "/" + index;
            return index;

        }
        public string DodijeliNoviIndex(int b)
        {


            int a = 10000;
            a += b;
            string novi = Convert.ToString(a);
            int n = 100;
            b += n;
            index = Convert.ToString(b) + "/" + novi;
            return index;


        }
    }
}

