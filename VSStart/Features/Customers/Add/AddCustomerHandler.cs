using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSStart.Data;

namespace VSStart.Features.Customers.Add
{
    public class AddCustomerHandler
    {
        private readonly Database _db;

        public AddCustomerHandler(Database db)
        {
            _db = db;
        }

        public void Handle(AddCustomer request)
        {
            // Kommer senare
        }
    }
}
