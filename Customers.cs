using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PP1E
{
    public class Customers : CollectionBase
    {
        public void Add(Customer customer)
        {
            List.Add(customer);
        } 
    }
}
