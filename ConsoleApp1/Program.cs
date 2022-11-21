using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta atl1 = new Atleta();

            atl1.Name= "Usain";
            atl1.Lastname = "Bolt";
            atl1.Age = 39;

            atl1.showPropAtleta();

            Dipendente dip1 = new Dipendente();
            dip1.Name = "Goku";
            dip1.Lastname = "Kakarot";
            dip1.Stipendio = 200000;
            dip1.DataAssunzione = new DateTime(1998, 11, 12);
            dip1.showPropDipendente();

            Console.ReadLine();
        }
    }
}
