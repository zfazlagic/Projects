using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2Zadaca17220
{
    [Serializable]
    public class StudentBachelor : Student
    {
        public StudentBachelor() { }
        public StudentBachelor(string ime, string prezime, DateTime datumr) : base(ime, prezime, datumr){}

        public override string DodijeliIndex(int n)
        {
            int a = 10000;
            n += a;
            index = Convert.ToString(n);
            return index;
        }
        
    }
}
