using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationListViewApp.DAL;
using WindowsFormsApplicationListViewApp.Models;

namespace WindowsFormsApplicationListViewApp.BLL
{
   public class CatagoryManager
    {
       CatagoryGateway catagoryGateway=new CatagoryGateway();
       public string SaveCatagory(SetupCatagory aCatagory)
       {
           if (!catagoryGateway.IsCatagoryNameExist(aCatagory))
           {
               string message= catagoryGateway.SaveCatagory(aCatagory);
           return message;
           }
           else
           {
               return "Name is already exist";
           }
       }

       public List<SetupCatagory> GetAllCatagory()
       {

           return catagoryGateway.GetAllCatagory();
       }

       public string UpdateCatagory(SetupCatagory aCatagory)
       {
           int rowAffected = catagoryGateway.UpdateCatagory(aCatagory);
           if (rowAffected>0)
           {
               return "updated successfully";
           }
           return "pdate failed";


       }

       public string DeleteCatagory(SetupCatagory aCatagory)
       {
           int rowAffected = catagoryGateway.DeleteCatagory(aCatagory);
           if (rowAffected>0)
           {
               return "deleted successfully";
           }
           return "failed to delete";
       }
    }
}
