namespace CodeQuizApi.Repositories
{
    public interface IRepository<T>
    {
        public Task<T?> GetById(int id);
        public Task Add(T t);
        public Task RemoveById(int id);
        public Task Update(int id, T t);
    }
}
