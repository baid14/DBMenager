using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
   public interface IObserwowany
    {
        void dodajObserwatora(IObserwator o);
        void usunObserwator(IObserwator o);
        void powiadomObserwatorow();
    }
}
