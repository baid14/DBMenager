using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    public class Proxy : Idane
    {
        private readonly Idane dane;
            public Proxy(Idane dane)
        {
            dane = dane;
        }

        public string imie(string name)
        {
            return name;
        }
        public string pass(string pw)
        {
            return pw;
        }
    }
}
