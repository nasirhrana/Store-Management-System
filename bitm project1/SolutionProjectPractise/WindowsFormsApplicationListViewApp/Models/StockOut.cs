using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationListViewApp.Models
{
   public class StockOut
    {
       public int Id { get; set; }
       public string ItemName { get; set; }
       public string CompanyName { get; set; }
       public int Quantity { get; set; }
       public int ReorderLevel { get; set; }
    }
}
