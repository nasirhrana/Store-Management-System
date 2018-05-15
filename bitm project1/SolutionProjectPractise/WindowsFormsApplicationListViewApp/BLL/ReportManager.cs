using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationListViewApp.DAL;
using WindowsFormsApplicationListViewApp.Models;

namespace WindowsFormsApplicationListViewApp.BLL
{
   public class ReportManager
    {
       
           public List<Report> ViewSwals(Report aProjectModels)
           {
               ReportGateway reportGateway = new ReportGateway();

               List<Report> viewReport = reportGateway.ViewSwals(aProjectModels);
               return viewReport;
           }
       
    }
}
