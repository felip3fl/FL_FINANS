namespace FL.Point.Data.Inferfaces.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task Add(T entity);
        Task Delete(T entity);

    }
}
