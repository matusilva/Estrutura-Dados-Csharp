using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicionario
{
    interface IDicionario
    {
        Object findElement(int k);
        void insertItem(int k, Object o);
        Object removeElement(int k);
        int size();
        Boolean isEmpty();
    }
}
