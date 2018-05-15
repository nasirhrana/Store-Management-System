using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationListViewApp.ViewModel
{
   public class ItemWithCompany
    {
       public int Id { get; set; }
       public string ItemName { get; set; }
       public int ReorderLevel { get; set; }
       public string CompanyName { get; set; }
    }
}
