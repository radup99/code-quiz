namespace CodeQuizApi.Repositories
{
    public interface IRepository<T>
    {
        public Task<T> GetById(int id);
        public Task Add(T t);
    }
}
