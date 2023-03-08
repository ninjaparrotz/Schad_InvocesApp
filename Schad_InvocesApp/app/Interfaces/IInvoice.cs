using Schad_InvocesApp.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schad_InvocesApp.app.Interfaces
{
    internal interface IInvoice: IInvoiceHeader
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal TotalItbis { get; set; }
        public decimal TotalSubTotal { get; set; }
        public decimal Total { get; set; }
        void Create();
    }
    internal interface IInvoiceHeader
    {
        public Customer Customer { get; set; }
       
    }
}
