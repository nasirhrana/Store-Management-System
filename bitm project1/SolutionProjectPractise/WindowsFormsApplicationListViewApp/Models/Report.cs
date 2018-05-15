using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationListViewApp.Models
{
   public class Report
    {
       public string ItemName { get; set; }
       public int Quantity { get; set; }
       public DateTime FromDateTime { get; set; }
       public DateTime ToDateTime { get; set; }
    }
}
