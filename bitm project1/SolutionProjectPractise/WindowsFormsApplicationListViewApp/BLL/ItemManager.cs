using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApplicationListViewApp.DAL;
using WindowsFormsApplicationListViewApp.Models;

namespace WindowsFormsApplicationListViewApp.BLL
{
    
   public class ItemManager
    {
      private ItemGateway aGateway=new ItemGateway();

       public string SaveItem(SetupItem aItem)
       {
           if (!aGateway.IsItemNameExist(aItem))
           {
               string message = aGateway.SaveItem(aItem);
               return message;
           }
           else
           {
               return "failed to add";
           }
           
       }
       public List<SetupCatagory> GetAllCatagory()
       {
           return aGateway.GetAllCatagory();
       }
       public List<SetupCompany> GetAllCompany()
       {
           return aGateway.GetAllCompany();
       }

       
       
    }
}
