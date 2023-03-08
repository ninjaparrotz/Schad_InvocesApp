using Schad_InvocesApp.DbContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Schad_InvocesApp.app
{
    internal class CustomerType: EntityOperations
    {
        public string Description { get; set; }

        private static CustomerType _customerType = null;


        public CustomerType(int id, string description)
        {
            Id = id;
            Description = description;
        }
        public CustomerType(string description)
        {
            Description = description;
        }
        public CustomerType(int id)
        {
            this.Id = id;
            Description = string.Empty;
        }
        public CustomerType()
        {
            Id = 0;
            Description = null;
        }


        public static CustomerType GetInstance(int id, string description)
        {
            if (_customerType == null)
            {
                _customerType = new CustomerType(id, description);
            }
            else
            {
                _customerType.Id = id;
                _customerType.Description = description;
            }
            return _customerType;
        }
        public static CustomerType GetInstance(string description)
        {
            if (_customerType == null)
            {
                _customerType = new CustomerType(description);
            }
            return _customerType;
        }
        public static CustomerType GetInstance(int id)
        {
            if (_customerType == null)
            {
                _customerType = new CustomerType(id);
            }
            else
            {
                _customerType.Id = id;
            }
            return _customerType;
        }
        public static CustomerType GetInstance()
        {
            if (_customerType == null)
            {
                _customerType = new CustomerType();
            }
            return _customerType;
        }


        public override void Create()
        {
            using (schad_InvocesEntities _dB = EntityConection.getInstance())
            {
                DbContext.CustomerType _eCustomerT = new DbContext.CustomerType();
                _eCustomerT.Description = this.Description;
                _dB.CustomerTypes.Add(_eCustomerT);
                _dB.SaveChanges();
            }
            EntityConection._Dbcontext = null;
        }
        public override void Update()
        {
            using (schad_InvocesEntities _dB = EntityConection.getInstance())
            {
                var _eCustomer = _dB.CustomerTypes.Find(this.Id);
                _eCustomer.Description = this.Description;
                _dB.SaveChanges();
            }
            EntityConection._Dbcontext = null;
        }
        public override void Delete()
        {
            using(schad_InvocesEntities _dB = EntityConection.getInstance())
            {
                DbContext.CustomerType _ec = new DbContext.CustomerType()
                { Id = this.Id, Description = this.Description };
                _dB.CustomerTypes.Attach(_ec);
                _dB.CustomerTypes.Remove(_ec);
                _dB.SaveChanges();
            }
            EntityConection._Dbcontext = null;
        }
        public static DataTable GetAll()
        {
            using(var _dB = EntityConection.getInstance())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Id");
                dt.Columns.Add("Description");

                List<DbContext.CustomerType> customersT = _dB.CustomerTypes.ToList();
                foreach (DbContext.CustomerType customerType in customersT)
                {
                    dt.Rows.Add(customerType.Id, customerType.Description);
                }
                EntityConection._Dbcontext = null;
                return dt;
            }
        }
        public  List<DbContext.CustomerType> IGetAll()
        {
            using (var _dB = EntityConection.getInstance())
            {
                List<DbContext.CustomerType> customersT = _dB.CustomerTypes.ToList();

                return customersT;
            }
        }
    }
}
