using _01_SirketApi.Entity.Entity;
using _02_SirketApp.Model.Interface;
using _02_SirketApp.Model.Model;

namespace _02_SirketApp.Model.Repository
{
    public class GorevlendirmeRepository : SirketAppContext, IRepositroy<Gorevlendirme>
    {
        public void Add(Gorevlendirme t)
        {
            Gorevlendirmes.Add(t);
            SaveChanges();
        }

        public void Delete(Gorevlendirme t)
        {
            var value = Gorevlendirmes.Where(x => x.Id == t.Id).FirstOrDefault();
            if (value != null)
            {
                Gorevlendirmes.Remove(value);
                SaveChanges();
            }
            else
                throw new Exception("Değer Null Olabilir Lütfen Kontrol Edermisiniz?");


        }

        public List<Gorevlendirme> GetById(int id)
        {
            return Gorevlendirmes.Where(x => x.Id == id).ToList();
        }

        public List<Gorevlendirme> GetList()
        {
            return Gorevlendirmes.ToList();
        }

        public void Update(Gorevlendirme t)
        {
            var value = Gorevlendirmes.Where(x => x.Id == t.Id).FirstOrDefault();
            if (value != null)
            {
                value.PersonelNo = t.PersonelNo;
                value.ProjeId = t.ProjeId;
                SaveChanges();
            }
            else
                throw new Exception("Değer Null Olabilir Lütfen Kontrol Edermisiniz?");
        }
    }
}
