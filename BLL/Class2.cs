using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
   
   public class Class2
    {
        dluserlogin dl = new dluserlogin();
        public byte login(string pusername, string ppassword)
        {
            return dl.login(pusername, ppassword);
        }
        public void Register(userlogin ul)
        {
             dl.Register(ul);
        }

    }
}
