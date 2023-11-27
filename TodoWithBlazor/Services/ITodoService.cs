using TodoWithBlazor.Data;

namespace TodoWithBlazor.Services
{
    public interface ITodoService
    {
        public void Add(TodoItem item);
        public IEnumerable<TodoItem> GetAll();
    }
}
