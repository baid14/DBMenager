using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    class OperationAdapter : IWykonaj
    {
        ITypOperacji typ;

        public OperationAdapter(ITypOperacji typ)
        {
            this.typ = typ;
        }

        public void akcja()
        {
            {
                if (typ is add)
                {
                    this.typ.addline();
                }

                if (typ is delete)
                {
                    this.typ.deleteline();
                }


            }


        }
    }
}

