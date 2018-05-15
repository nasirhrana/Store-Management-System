using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationListViewApp.DAL;
using WindowsFormsApplicationListViewApp.Models;
using WindowsFormsApplicationListViewApp.ViewModel;

namespace WindowsFormsApplicationListViewApp.BLL
{
   public class StockInManager
    {
       private StockInGateway aStockInGateway=new StockInGateway();


       public List<ItemWithCompany> GetAllItemCompany()
       {
           return aStockInGateway.GetAllItemCompany();
           
       }
       public List<StockWithItem> GetAllQuantity()
       {
           return aStockInGateway.GetAllQuantity();
           
       }

       //public int GetReorderLevel(int id)
       //{
       //    int value = aStockInGateway.GetReorderLevel(id);
       //    return value;
       //}

       public int GetReorderLevel(SetupItem aItem)
       {
           int message = aStockInGateway.GetReorderLevel(aItem);
           return message;
       }
       public int GetAvailableQuantity(StockIn aStockIn)
       {
           int message = aStockInGateway.GetAvailableQuantity(aStockIn);
           return message;
       }
       public string UpdateQuantity(StockIn aStockIn)
       {
           int rowAffected =aStockInGateway. UpdateQuantity(aStockIn);
           if (rowAffected > 0)
           {
               return "updated successfully";
           }
           return "pdate failed";


       }
    }
}
