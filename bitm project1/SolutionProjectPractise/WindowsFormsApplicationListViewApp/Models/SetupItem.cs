using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationListViewApp
{
    public class SetupItem
    {
        public int Id { get; set; }
        public int CatagoryNameId { get; set; }
        public int CompanyNameId { get; set; }
        public string Name { get; set; }
        public int ReorderLevel { get; set; }
        public int Quantity { get; set; }
    }
}
