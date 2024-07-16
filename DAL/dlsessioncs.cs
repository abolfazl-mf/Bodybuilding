using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public class dlsessioncs
    {
        db db1 = new db();
        public string register(SessionUsers p)
        {
            if (!exist(p))
            {

                if (p.age <= 70)
                {


                    db1.sessionUsers.Add(p);
                    db1.SaveChanges();
                    return "ثبت اطلاعات با موفقیت انجام شد";



                }
                else
                {
                    return "سن وارد شده بیشتر از 70 سال است";
                }
            }
            return "اطلاعات وارد شده تکراری است";
        }
        public bool exist(SessionUsers p)
        {

            var q = db1.sessionUsers.Where(i => i.nationalcode == p.nationalcode);
            {
                if (q.Count() == 1)


                {
                    return true;


                }
                return false;
            }

        }
        public List<SessionUsers> search(string pphone_number, string pnational_code)
        {

            return (from i in db1.sessionUsers where i.phonenumber.Contains(pphone_number) && i.nationalcode.Contains(pnational_code) select i).ToList();

        }
        public List<SessionUsers> search43365(string psport)
        {

            return (from i in db1.sessionUsers where i.sport.Contains(psport) select i).ToList();

        }
        public List<SessionUsers> searchindebtedness(string pvisible)
        {

            return (from i in db1.sessionUsers where i.visibility.Contains(pvisible) select i).ToList();

        }
        public SessionUsers searchbyid(int id)
        {
            return db1.sessionUsers.Where(i => i.id == id).Single();
        }
        public List<SessionUsers> readall()
        {
            return db1.sessionUsers.ToList();
        }
        public string update(int id, SessionUsers p)
        {


            if (EditExist(p, id) != true)
            {
                if (p.age <= 70)
                {

                    var q = db1.sessionUsers.Where(i => i.id == id);
                    if (q.Count() == 1)
                    {
                        SessionUsers c1 = new SessionUsers();
                        c1 = q.Single();
                        c1.name = p.name;
                        c1.family = p.family;
                        c1.age = p.age;
                        c1.phonenumber = p.phonenumber;
                        c1.nationalcode = p.nationalcode;
                        c1.sport = p.sport;
                        c1.kindOfGive = p.kindOfGive;
                        c1.receive = p.receive;
                        c1.give = p.give;
                        c1.fathername = p.fathername;
                        c1.prepayment = p.prepayment;
                        c1.indebtedness = p.indebtedness;
                        c1.bimeh = p.bimeh;
                        c1.visibility = p.visibility;
                        c1.onregister = p.onregister;
                        c1.offregister = p.offregister;
                        c1.manager = p.manager;
                        c1.session = p.session;
                        c1.sessionsprice = p.sessionsprice;
                        c1.managerprice = p.managerprice;


                        db1.SaveChanges();

                    }

                }
                else
                {
                    return "سن وارد شده بیشتر از 70 است";
                }

            }
            return "ویرایش اطلاعات با موفقیت انجام شد";
        }
        public string delete(int id)
        {

            var q = db1.sessionUsers.Where(i => i.id == id);
            if (q.Count() == 1)
            {
                SessionUsers cr = new SessionUsers();
                db1.sessionUsers.Remove(q.Single());
                db1.SaveChanges();
                return "حذف اطلاعات با موفقیت انجام شد";
            }
            return "حذف اطلاعات با موفقیت انجام شد.";
        }
        public bool EditExist(SessionUsers cr, int id)
        {

            SessionUsers cr1 = new SessionUsers();
            var q = db1.sessionUsers.Where(i => i.id == id);
            cr1 = q.Single();
            if (cr1.nationalcode != cr.nationalcode)
            {
                var q2 = db1.sessionUsers.Where(i => i.nationalcode == cr.nationalcode);
                if (q2.Count() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (db1.sessionUsers.Where(x => x.nationalcode == cr.nationalcode).Count() > 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
