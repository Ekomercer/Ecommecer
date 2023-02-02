namespace E_Commerce.Data._2.Repsitory.Interface.BaseInterface
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetBy(int id);
        Task<T> GetAll();
        Task<bool> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(int id);
    }
}
