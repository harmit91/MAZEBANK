using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PP1E
{
    class SavingsAccounts:CollectionBase
    {
        public void Add(Savings savings)
        {
            List.Add(savings);
        }
    }
}
