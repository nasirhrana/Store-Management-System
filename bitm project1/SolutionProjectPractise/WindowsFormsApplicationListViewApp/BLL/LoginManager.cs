using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationListViewApp.DAL;

namespace WindowsFormsApplicationListViewApp.BLL
{
   public class LoginManager
    {
       LoginGateway aGateway=new LoginGateway();
       public string Login(Login aLogin)
       {
           string message = aGateway.Login(aLogin);
           return message;
       }
    }
}
