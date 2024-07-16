using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class blsession
    {
        dlsessioncs dl = new dlsessioncs();


        public string register(SessionUsers p)
        {
            return dl.register(p);
        }
        public List<SessionUsers> search43365(string psport)
        {

            return dl.search43365(psport);

        }
        public bool exist(SessionUsers p)
        {
            return dl.exist(p);
        }

        public List<SessionUsers> search(string pphone_number, string pnational_code)
        {
            return dl.search(pphone_number, pnational_code);
        }
        public List<SessionUsers> searchindebtedness(string pvisible)
        {

            return dl.searchindebtedness(pvisible);

        }

        public SessionUsers searchbyid(int id)
        {
            return dl.searchbyid(id);
        }
        public List<SessionUsers> readall()
        {
            return dl.readall();
        }
        public string update(int id, SessionUsers p)
        {
            return dl.update(id, p);
        }
        public string delete(int id)
        {
            return dl.delete(id);
        }
        public bool EditExist(SessionUsers cr, int id)
        {
            return dl.EditExist(cr, id);
        }
    }
}
