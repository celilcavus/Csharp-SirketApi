using _01_SirketApi.Entity.Entity;
using _02_SirketApp.Model.Interface;
using _02_SirketApp.Model.Model;

namespace _02_SirketApp.Model.Repository
{
    public class ILRepository : SirketAppContext, IRepositroy<Il>
    {
        public void Add(Il t)
        {
            Ils.Add(t);
            SaveChanges();
        }

        public void Delete(Il t)
        {
            var values = Ils.Where(x => x.Id == t.Id).FirstOrDefault();
            if (values != null)
            {
                Ils.Remove(values);
                SaveChanges();
            }
            else
                throw new Exception("Null Değer olabilir lütfen kontrol ediniz.");
        }

        public List<Il> GetById(int id)
        {
            return Ils.Where(x => x.Id == id).ToList();
        }

        public List<Il> GetList()
        {
            return Ils.ToList();
        }

        public void Update(Il t)
        {
            var values = Ils.Where(x => x.Id == t.Id).FirstOrDefault();
            if (values != null)
            {
                values.IlAdi = t.IlAdi;
            }
            else
                throw new Exception("Null Değer olabilir lütfen kontrol ediniz.");
        }
    }
}
