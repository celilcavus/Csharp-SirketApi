using _01_SirketApi.Entity.Entity;
using _02_SirketApp.Model.Interface;
using _02_SirketApp.Model.Model;

namespace _02_SirketApp.Model.Repository
{
    public class PersonelRepository : IRepositroy<Personel>
    {
        SirketAppContext db = new SirketAppContext();
        public void Add(Personel t)
        {
            db.Personels.Add(t);
            db.SaveChanges();
        }

        public void Delete(Personel t)
        {
            var returnValue = db.Personels.FirstOrDefault(x => x.Id == t.Id);
            db.Personels.Remove(returnValue!);
            db.SaveChanges();
        }

        public List<Personel> GetById(int id)
        {
            return db.Personels.Where(x => x.Id == id).ToList();
        }

        public List<Personel> GetList()
        {
            return db.Personels.ToList();
        }

        public void Update(Personel t)
        {
            var returnValue = db.Personels.FirstOrDefault(x => x.Id == t.Id);
            returnValue.Ad = t.Ad;
            returnValue.Soyad = t.Soyad;
            returnValue.dogumTarihi = t.dogumTarihi;
            returnValue.baslamaTarihi = t.baslamaTarihi;
            returnValue.BirimNo = t.BirimNo;
            returnValue.UnvanNo = t.UnvanNo;
            returnValue.CalismaSaati = t.CalismaSaati;
            returnValue.Maas = t.Maas;
            returnValue.Prim = t.Prim;
            db.SaveChanges();
        }
    }
}
