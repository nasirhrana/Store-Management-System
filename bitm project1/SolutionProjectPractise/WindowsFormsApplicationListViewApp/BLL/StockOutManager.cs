using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationListViewApp.DAL;
using WindowsFormsApplicationListViewApp.Models;

namespace WindowsFormsApplicationListViewApp.BLL
{
   public class StockOutManager
    {
       private StockOutGateway aStockOutGateway=new StockOutGateway();
       public string Insert(Sell aStockOut)
       {
           string message = aStockOutGateway.SaveCatagory(aStockOut);
           return message;
       }
       public string Update(StockOut aStockOut)
       {
           string message = aStockOutGateway.Update(aStockOut);
           return message;
       }
    }
}
