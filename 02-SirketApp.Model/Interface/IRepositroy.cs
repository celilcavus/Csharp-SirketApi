namespace _02_SirketApp.Model.Interface
{
    public interface IRepositroy<T>
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetList();

        List<T> GetById(int id);
    }
}
