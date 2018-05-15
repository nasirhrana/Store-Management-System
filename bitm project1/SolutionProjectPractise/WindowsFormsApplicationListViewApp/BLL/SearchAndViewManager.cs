using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationListViewApp.DAL;
using WindowsFormsApplicationListViewApp.ViewModel;

namespace WindowsFormsApplicationListViewApp.BLL
{
    public class SearchAndViewManager
    {
        SearchAndViewGateway aSearchAndViewGateway=new SearchAndViewGateway();

        public List<Search> GetAll(Search aSearch)
        {
            return aSearchAndViewGateway.GetAll(aSearch);
        }
        public List<Company> GetAllCompany()
        {
            return aSearchAndViewGateway.GetAllCompany();
        }
        public List<Catagory> GetAllCatagory()
        {
            return aSearchAndViewGateway.GetAllCatagory();
        }
    }
}
