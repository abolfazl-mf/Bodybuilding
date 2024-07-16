using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;

namespace DAL
{
   public class dlpersonelcs
    {
        db db1 = new db();
        public string register(personel p)
        {
            if (!exist(p))
            {

                if (p.age <= 70)
                {


                    db1.personels.Add(p);
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
        public bool exist(personel p)
        {

            var q = db1.personels.Where(i => i.nationalcode == p.nationalcode);
            {
                if (q.Count() == 1)


                {
                    return true;


                }
                return false;
            }

        }
        public List<personel> search(string pphone_number, string pnational_code)
        {

            return (from i in db1.personels where i.phonenumber.Contains(pphone_number) && i.nationalcode.Contains(pnational_code) select i).ToList();

        } 
        public List<personel> search43365(string psport)
        {

            return (from i in db1.personels where i.sport.Contains(psport) select i).ToList();

        }
        public List<personel> searchbodyprograms(string pbodyprogram)
        {

            return (from i in db1.personels where i.bodyprogram.Contains(pbodyprogram) select i).ToList();

        }
        public List<personel> searchindebtedness(string pvisible)
        {

            return (from i in db1.personels where i.visibility.Contains(pvisible) select i).ToList();

        }
        public personel searchbyid(int id)
        {
            return db1.personels.Where(i => i.id == id).Single();
        }
        public List<personel> readall()
        {
            return db1.personels.ToList();
        }
        public string update(int id, personel p)
        {


            if (EditExist(p, id) != true)
            {
                if (p.age <= 70)
                {

                    var q = db1.personels.Where(i => i.id == id);
                    if (q.Count() == 1)
                    {
                        personel c1 = new personel();
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
                        c1.managerprice = p.managerprice;
                        c1.bodyprogram = p.bodyprogram;

                        db1.SaveChanges();

                    }

                }
                else {
                    return "سن وارد شده بیشتر از 70 است";
                }

            }
            return "ویرایش اطلاعات با موفقیت انجام شد";
        }
        public string delete(int id)
        {

            var q = db1.personels.Where(i => i.id == id);
            if (q.Count() == 1)
            {
                personel cr = new personel();
                db1.personels.Remove(q.Single());
                db1.SaveChanges();
                return "حذف اطلاعات با موفقیت انجام شد";
            }
            return "حذف اطلاعات با موفقیت انجام شد.";
        }
        public bool EditExist(personel cr, int id)
        {

            personel cr1 = new personel();
            var q = db1.personels.Where(i => i.id == id);
            cr1 = q.Single();
            if (cr1.nationalcode != cr.nationalcode)
            {
                var q2 = db1.personels.Where(i => i.nationalcode == cr.nationalcode);
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
                if (db1.personels.Where(x => x.nationalcode == cr.nationalcode).Count() > 1)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
