using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    class add : IObserwator
    {
        connect polacz;
        
        string sql2;
       

        public add(string sql)
        {
            sql2 = sql;
            polacz = new connect();
        }
        public void aktualizacjaDanych()
        {
            polacz.pobierzdane(sql2);
            polacz.powiadomObserwatorow();
        }


    }
}
