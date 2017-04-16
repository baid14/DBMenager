using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    class dodatkoweDane : Decorator
    {
        public dodatkoweDane(Idane data) : base(data)
        {

        }

        public string mail(string email)
        {
            return email;
        }


    }
}
