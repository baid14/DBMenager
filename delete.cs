using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    class delete : IObserwator
    {
        connect polacz;
       
        string sql2;
        

        public delete(string sql)
        {
            polacz = new connect();
            sql2 = sql;
        }
        public void aktualizacjaDanych()
        {
            polacz.pobierzdane(sql2);
            polacz.powiadomObserwatorow();
        }

    }
}
