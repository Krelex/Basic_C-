using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraZadaci4
{
    class Automobili : System.Collections.CollectionBase
    {
         public int add (Automobil auto)
        {
            return InnerList.Add(auto);
        }

        public void remove (Automobil auto)
        {
             InnerList.Remove(auto);
        }

        public Automobil this[int index]
        {
            get
            {
                return (Automobil)InnerList[index];
            }
        }

    }
}
