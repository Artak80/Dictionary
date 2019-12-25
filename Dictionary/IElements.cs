using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    interface IElements<Tkey, Tvalue>
    {
        void AddbyKeyFirst(Tkey x, Tvalue y);
        Tkey AddbyKey(Tkey z, Tvalue s);
    }
}
