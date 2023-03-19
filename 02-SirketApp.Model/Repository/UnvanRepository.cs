using _01_SirketApi.Entity.Entity;
using _02_SirketApp.Model.Interface;
using _02_SirketApp.Model.Model;

namespace _02_SirketApp.Model.Repository
{
    public class UnvanRepository : SirketAppContext, IRepositroy<Unvan>
    {
        public void Add(Unvan t)
        {
            Unvans.Add(t);
            SaveChanges();
        }

        public void Delete(Unvan t)
        {
            var value = Unvans.Where(x => x.Id == t.Id).FirstOrDefault();
            if (value != null)
            {
                Unvans.Remove(value);
                SaveChanges();
            }
            else
                throw new Exception("Null Değer Olabilir Lütfen Kontrol edermisiniz?");
        }

        public List<Unvan> GetById(int id)
        {
            return Unvans.Where(x => x.Id == id).ToList();
        }

        public List<Unvan> GetList()
        {
            return Unvans.ToList();
        }

        public void Update(Unvan t)
        {
            var value = Unvans.Where(x => x.Id == t.Id).FirstOrDefault();
            if (value != null)
            {
                value.UnvanAdi = t.UnvanAdi;
                SaveChanges();
            }
            else
                throw new Exception("Null Değer Olabilir Lütfen Kontrol edermisiniz?");
        }
    }
}
