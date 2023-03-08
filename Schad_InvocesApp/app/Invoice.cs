using Schad_InvocesApp.app.Interfaces;
using Schad_InvocesApp.DbContext;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Schad_InvocesApp.app
{
    internal class Invoice : IInvoice
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal TotalItbis { get; set; }
        public decimal TotalSubTotal { get; set; }
        public decimal Total { get; set; }


        private static Invoice _Invoice = null;

        public Invoice(int id, Customer customer, int qty, decimal price, decimal totalItbs, decimal totalst, decimal total)
        {
            this.Id = id;
            this.Customer = customer;
            this.Qty = qty;
            this.Price = price;
            this.TotalItbis = totalItbs;
            this.TotalSubTotal = totalst;
            this.Total = total;
        }

        public void Create()
        {
            using (schad_InvocesEntities _dB = EntityConection.getInstance())
            {
                using (var _dbContextTransaction = _dB.Database.BeginTransaction())
                {
                    try
                    {
                        DbContext.InvoiceDetail _einvD = new DbContext.InvoiceDetail();
                        DbContext.Invoice _einvH = new DbContext.Invoice();
                        _einvD.CustomerId = this.Customer.Id;
                        _einvD.Qty = this.Qty;
                        _einvD.Price = this.Price;
                        _einvD.TotalItbis = this.TotalItbis;
                        _einvD.SubTotal = this.TotalSubTotal;
                        _einvD.Total = this.Total;
                        _einvH.CustomerId = this.Customer.Id;
                        _einvH.TotalItbis = this.TotalItbis;
                        _einvH.SubTotal = this.TotalSubTotal;
                        _einvH.Total = this.Total;
                        _einvD.Invoice = _einvH;
                        _dB.InvoiceDetails.Add(_einvD);
                        _dB.SaveChanges();

                        _dbContextTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        _dbContextTransaction.Rollback();
                    }
                }
            }
        }

        public static void Build(int id, Customer customer, int qty, decimal price, decimal totalItbs, decimal totalst, decimal total)
        {
            if (_Invoice == null)
            {
                _Invoice = new Invoice(id, customer, qty, price, totalItbs, totalst, total);
            }
            else
            {
                _Invoice.Id = id;
                _Invoice.Customer = customer;
                _Invoice.Qty = qty;
                _Invoice.Price = price;
                _Invoice.TotalItbis = totalItbs;
                _Invoice.TotalSubTotal = totalst;
                _Invoice.Total = total;
            }
            _Invoice.Create();
        }
        public static IEnumerable GetAll()
        {
            using (schad_InvocesEntities _dB = EntityConection.getInstance())
            {
                try
                {
                    var person = (from i in _dB.Invoices
                                  join ib in _dB.InvoiceDetails
                                  on i.Id equals ib.Id
                                  join c in _dB.Customers
                                  on i.CustomerId equals c.Id
                                  select new
                                  {
                                      ID = i.Id,
                                      Customer = c.CustName,
                                      Qty = ib.Qty,
                                      TotalItbis = i.TotalItbis,
                                      TotalSub = i.SubTotal,
                                      Total = i.Total,
                                  }).ToList();
                    return person;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
