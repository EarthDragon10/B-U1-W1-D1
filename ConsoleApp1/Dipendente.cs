using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dipendente
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Lastname;
        public string Lastname
        {
            get { return _Lastname; } 
            set { _Lastname = value; }
        }

        private double _Stipendio;
        public double Stipendio
        {
            get { return _Stipendio; }
            set { _Stipendio = value; }
        }

        private DateTime _DataAssunzione;
        public DateTime DataAssunzione
        {
            get { return _DataAssunzione; }
            set { _DataAssunzione = value; }
        }

        public void showPropDipendente ()
        {
            Console.WriteLine($"Il dipendente si chiama {Name} {Lastname}, ha lo stipendio di " + Stipendio + " ed é stato assunto in data " + DataAssunzione.ToString());
        }
    }
}
