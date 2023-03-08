using Schad_InvocesApp.app.Interfaces;
using Schad_InvocesApp.DbContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Schad_InvocesApp.app
{
    internal class Customer : EntityOperations, ICustomer
    {
        public string Name { get; set; }

        protected string Address { get; set; }

        protected bool Status { get; set; }

        public CustomerType CustomerType { get; set; }

        private static Customer _customer { get; set; }


        public Customer(int Id, string name, string address, bool status, CustomerType customerType)
        {
            this.Id = Id;
            this.Name = name;
            this.Address = address;
            this.Status = status;
            this.CustomerType = customerType;
        }
        public Customer() { }

        public static Customer GetInstance(int Id, string name, string address, bool status, CustomerType customerType)
        {
            if (_customer == null)
            {
                _customer = new Customer(Id, name, address, status, customerType);
            }
            return _customer;
        }

        public override void Create()
        {
            using (schad_InvocesEntities _dB = EntityConection.getInstance())
            {
                DbContext.Customer _eCustomer = new DbContext.Customer();
                _eCustomer.Id = this.Id;
                _eCustomer.CustName = this.Name;
                _eCustomer.Adress = this.Address;
                _eCustomer.Status = this.Status;
                _eCustomer.CustomerType = new DbContext.CustomerType() { Id = CustomerType.Id, Description = CustomerType.Description };
                _dB.Customers.Add(_eCustomer);
                _dB.SaveChanges();
            }
            EntityConection._Dbcontext = null;
        }
        public override void Update()
        {
            using (schad_InvocesEntities _dB = EntityConection.getInstance())
            {
                var _eCustomer = _dB.Customers.Find(this.Id);
                _eCustomer.CustName = this.Name;
                _eCustomer.Status = this.Status;
                _eCustomer.CustomerTypeId = this.CustomerType.Id;
                _eCustomer.Adress = this.Address;
                _dB.SaveChanges();
            }
            EntityConection._Dbcontext = null;
        }
        public override void Delete()
        {
            using (schad_InvocesEntities _dB = EntityConection.getInstance())
            {
                DbContext.Customer _ec = new DbContext.Customer()
                { Id = this.Id, CustName = this.Name, Status = this.Status, CustomerTypeId = this.CustomerType.Id };
                _dB.Customers.Attach(_ec);
                _dB.Customers.Remove(_ec);
                _dB.SaveChanges();
            }
            EntityConection._Dbcontext = null;
        }
        public static DataTable GetAll()
        {
            using (var _dB = EntityConection.getNewInstance())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Id");
                dt.Columns.Add("Name");
                dt.Columns.Add("Address");
                dt.Columns.Add("Customer_Type");
                dt.Columns.Add("Status");

                List<DbContext.Customer> customers = _dB.Customers.ToList();
                foreach (DbContext.Customer customer in customers)
                {
                    dt.Rows.Add(customer.Id, customer.CustName, customer.Adress, customer.CustomerType.Description, (customer.Status) ? "Activo" : "Desactivado");
                }
                EntityConection._Dbcontext = null;
                return dt;
            }
        }
        public static List<DbContext.Customer> GetAllList()
        {
            using (var _dB = EntityConection.getNewInstance())
            {
                List<DbContext.Customer> customers = _dB.Customers.ToList();
                EntityConection._Dbcontext = null;
                return customers;
            }
        }
    }
}
