using _01_SirketApi.Entity.Entity;
using _02_SirketApp.Model.Interface;
using _02_SirketApp.Model.Model;

namespace _02_SirketApp.Model.Repository
{
    public class IlceRepository : SirketAppContext, IRepositroy<Ilce>
    {
        public void Add(Ilce t)
        {
            Ilces.Add(t);
            SaveChanges();
        }

        public void Delete(Ilce t)
        {
            var value = Ilces.Where(x => x.Id == t.Id).FirstOrDefault();
            if (value != null)
            {
                Ilces.Remove(value);
                SaveChanges();
            }
            else
                throw new Exception("Null Değer olabilir lütfen kontrol ediniz..");
        }

        public List<Ilce> GetById(int id)
        {
            return Ilces.Where(x => x.Id == id).ToList();
        }

        public List<Ilce> GetList()
        {
            return Ilces.ToList();
        }

        public void Update(Ilce t)
        {
            var value = Ilces.Where(x => x.Id == t.Id).FirstOrDefault();
            if (value != null)
            {
                value.IlceAdi = t.IlceAdi;
                value.IlId = t.IlId;
                SaveChanges();
            }
            else
                throw new Exception("Null Değer olabilir lütfen kontrol ediniz..");
        }
    }
}
