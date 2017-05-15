using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonBok
{
    class Person
    {

        private int telefonNummer;

        public int TelefonNummer
        {
            get { return telefonNummer; }
            set { telefonNummer = value; }
        }
        private string namn;
        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }

        public Person(string namn, int nummer)
        {
            this.Namn = namn;
            this.TelefonNummer = nummer;
        }

        public List<string> strängar = new List<string>();
        
    }
}
