namespace Diary.Repository
{
    public interface TaskRepoInterface<T>
    {
        public Task<T> GetTask<T>();
        public Task<T> Create(T _object);
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        public void Delete(T _object);
    }
}
