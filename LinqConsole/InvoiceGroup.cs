using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class InvoiceGroup
    {
        public DateTime IssueDate { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
}
