using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Atleta
    {
        private string _name;
        private string _lastname;
        private double age;

        public string Name { get => _name; set => _name = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public double Age { get => age; set => age = value; }

        public void showPropAtleta()
        {
            Console.WriteLine($"L'atleta si chiama {Name} {Lastname} ed ha anni " + age);
        }
    }
}
