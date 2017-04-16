using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    abstract class Decorator : Idane
    {
        protected Idane dane;

        public Decorator(Idane data)
        {
            dane = data;
        }

        public string imie(string name)
        {
            return dane.imie(name);
        }

        public string pass(string pw)
        {
            return dane.pass(pw);
        }
    }
}
