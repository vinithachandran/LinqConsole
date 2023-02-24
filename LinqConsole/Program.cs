using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<InvoiceGroup> invoiceGroupss = new List<InvoiceGroup>();
            List<Invoice> Lstinvoices = new List<Invoice>();
            List<Observation> Lstobservation = new List<Observation>();

            Lstobservation.Add(new Observation { GuestName = "Vinitha", TravelAgent = "ABC", NumberOfNights = 5 });
            Lstobservation.Add(new Observation { GuestName = "Vinitha", TravelAgent = "ABC", NumberOfNights = 5 });
            Lstobservation.Add(new Observation { GuestName = "Thanvika", TravelAgent = "ABC", NumberOfNights = 5 });

             Lstinvoices.Add(new Invoice { Observations = Lstobservation });



            invoiceGroupss.Add(new InvoiceGroup { Invoices = Lstinvoices });
            invoiceGroupss.Add(new InvoiceGroup { IssueDate = System.DateTime.Now });


          


        var dup = Lstobservation
       .GroupBy(x => new { x.GuestName })

       .Select(group => new { GuestName = group.Key, Count = group.Count() })
       .OrderByDescending(x => x.Count);

            foreach (var x in dup)
            {
                if (x.Count > 1)
                {
                    Console.WriteLine(x.Count + " " + x.GuestName);
                }
            }          

            
        }
    }
}
