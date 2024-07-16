using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Data.Entity;


namespace BLL
{
    public class blpersonel
    {
        dlpersonelcs dl = new dlpersonelcs(); 
        public string register(personel p)
        {
            return dl.register(p);
        }
        public List<personel> search43365(string psport)
        {

            return dl.search43365(psport);

        }
        public List<personel> searchbodyprograms(string pbodyprogram)
        {

            return dl.searchbodyprograms(pbodyprogram);

        }
        public bool exist(personel p)
        {
            return dl.exist(p);
        }

        public List<personel> search(string pphone_number, string pnational_code)
        {
            return dl.search(pphone_number, pnational_code);
        }
        public List<personel> searchindebtedness(string pvisible)
        {

            return dl.searchindebtedness(pvisible);

        }

        public personel searchbyid(int id)
        {
            return dl.searchbyid(id);
        }
        public List<personel> readall()
        {
            return dl.readall();
        }
        public string update(int id, personel p)
        {
            return dl.update(id, p);
        }
        public string delete(int id)
        {
            return dl.delete(id);
        }
        public bool EditExist(personel cr, int id)
        {
            return dl.EditExist(cr, id);
        }
    }
}
