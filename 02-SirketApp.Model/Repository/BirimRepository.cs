using _01_SirketApi.Entity.Entity;
using _02_SirketApp.Model.Interface;
using _02_SirketApp.Model.Model;

namespace _02_SirketApp.Model.Repository
{
    public class BirimRepository : SirketAppContext, IRepositroy<Birim>
    {

        public void Add(Birim t)
        {
            Birims.Add(t);
            SaveChanges();
        }

        public void Delete(Birim t)
        {
            var value = Birims.Where(x=>x.Id == t.Id).FirstOrDefault();
            Birims.Remove(value!);
            SaveChanges();
        }

        public List<Birim> GetById(int id)
        {
            return Birims.Where(x => x.Id == id).ToList();
        }

        public List<Birim> GetList()
        {
            return Birims.ToList();
        }

        public void Update(Birim t)
        {
            var value = Birims.Where(x => x.Id == t.Id).FirstOrDefault();
            value!.BirimAdi = t.BirimAdi;
            SaveChanges();
        }
    }
}
