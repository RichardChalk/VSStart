using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSStart.Data;
using VSStart.Models;

namespace VSStart.Features.Customers.GetAll
{
    public class GetAllCustomersHandler
    {
        private readonly Database _db;

        public GetAllCustomersHandler(Database db)
        {
            _db = db;
        }

        public List<Customer> Handle(GetAllCustomers request)
        {
            // Kommer senare
            return new();
        }
    }
}
