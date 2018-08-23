using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationEF
{
    static class CustomerDB
    {
        public static List<Customer> GetAllCustomers()
        {
            BookRegistrationEntities context = new BookRegistrationEntities();
            List<Customer> customers = context.Customer.ToList();
            return customers;
        }
    }
}
