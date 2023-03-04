using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schad_InvocesApp.app
{
    internal class Customer
    {
        public int Id { get; set; }
        protected string Name { get; set; }

        protected string Address { get; set; }

        protected bool Status { get; set; } 

        protected CustomerType CustomerType { get; set; }

        Customer(int id, string name, string address, bool status, CustomerType customerType)
        {
            Id = id;
            Name = name;
            Address = address;
            Status = status;
            CustomerType = customerType;
        }

        public void create(Customer customer)
        {

        }

    }
}
