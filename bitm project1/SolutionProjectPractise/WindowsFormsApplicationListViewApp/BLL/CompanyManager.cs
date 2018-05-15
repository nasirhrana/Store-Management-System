using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationListViewApp.DAL;
using WindowsFormsApplicationListViewApp.Models;

namespace WindowsFormsApplicationListViewApp.BLL
{
    public class CompanyManager
    {
        private CompanyGateway aCompanyGateway = new CompanyGateway();

        public string SaveCompany(SetupCompany aCompany)
        {
            if (!aCompanyGateway.IsCompanyNameExist(aCompany))
            {
                string message = aCompanyGateway.SaveCompany(aCompany);
                return message;
            }
            else
            {
                return "Name is already exist";
            }
        }


        public List<SetupCompany> GetAllCompany()
        {

            return aCompanyGateway.GetAllCompany();
        }
    }

}
