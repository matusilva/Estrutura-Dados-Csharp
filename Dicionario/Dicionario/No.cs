using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicionario
{
    class No
    {
        private int k; //chave
        private Object o; // valor
        private Boolean available;

        public int getK()
        {
            return k;
        }
        public void setK(int k)
        {
            this.k = k;
        }
        public Object getO()
        {
            return o;
        }
        public void setO(Object o)
        {
            this.o = o;
        }
        public Boolean isAvailable()
        {
            return available;
        }
        public void setAvailable(Boolean available)
        {
            this.available = available;
        }
    }
}
