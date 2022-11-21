using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animale
    {
        private string _classe;
        public string classe
        {
            get { return _classe; }
            set { _classe = value; }
        }

        private string _versoAnim;
        public string versoAnim
        {
            get { return _versoAnim; }
            set { _versoAnim = value; }
        }

        

        public void Verso ()
        {
            Console.WriteLine(versoAnim);
        }
    }
}
