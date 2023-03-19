using _01_SirketApi.Entity.Entity;
using _02_SirketApp.Model.Interface;
using _02_SirketApp.Model.Model;

namespace _02_SirketApp.Model.Repository
{
    public class CocukRepository : SirketAppContext, IRepositroy<Cocuk>
    {
        public void Add(Cocuk t)
        {
            Cocuks.Add(t);
            SaveChanges();
        }

        public void Delete(Cocuk t)
        {
            var value = Cocuks.Where(x => x.Id == t.Id).FirstOrDefault();
            if (value != null)
            {
                Cocuks.Remove(value);
                SaveChanges();
            }
            else
                throw new Exception("Sanırım value değeri boş kontrol edermisin?");
        }

        public List<Cocuk> GetById(int id)
        {
            return Cocuks.Where(x => x.Id == id).ToList();
        }

        public List<Cocuk> GetList()
        {
            return Cocuks.ToList();
        }

        public void Update(Cocuk t)
        {
            var value = Cocuks.Where(x => x.Id == t.Id).FirstOrDefault();
            value!.Adi = t.Adi;
            value.Soyadi = t.Soyadi;
            value.Cinsiyet = t.Cinsiyet;
            value.DogumTarihi = t.DogumTarihi;
            value.IlId = t.IlId;
            value.IlceId = t.IlceId;
            value.PersonelId = t.PersonelId;
            SaveChanges();
        }
    }
}
