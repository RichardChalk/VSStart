using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSStart.Models;

namespace VSStart.Data
{
    public class Database
    {
        public List<Customer> Customers { get; } = new();
    }
}
