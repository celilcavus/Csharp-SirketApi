using _01_SirketApi.Entity.Entity;
using _02_SirketApp.Model.Interface;
using _02_SirketApp.Model.Model;

namespace _02_SirketApp.Model.Repository
{
    public class ProjeRepository : SirketAppContext, IRepositroy<Proje>
    {
        public void Add(Proje t)
        {
            Projes.Add(t);
            SaveChanges();
        }

        public void Delete(Proje t)
        {
            var value = Projes.Where(x => x.Id == t.Id).FirstOrDefault();
            if (value != null)
            {
                Projes.Remove(value);
                SaveChanges();
            }
            else
                throw new Exception("Null Değeriniz olabilir kontrol edermisiniz");
        }

        public List<Proje> GetById(int id)
        {
            return Projes.Where(x => x.Id == id).ToList();
        }

        public List<Proje> GetList()
        {
            return Projes.ToList();
        }

        public void Update(Proje t)
        {
            var value = Projes.Where(x => x.Id == t.Id).FirstOrDefault();
            if (value != null)
            {
                value.ProjeAdi = t.ProjeAdi;
                value.ProjeBitisTarihi = t.ProjeBitisTarihi;
                value.ProjeTarihi = t.ProjeTarihi;
                SaveChanges();
            }
            else
                throw new Exception("Null Değeriniz olabilir kontrol edermisiniz");
        }
    }
}
