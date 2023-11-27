using TodoWithBlazor.Data;

namespace TodoWithBlazor.Services
{
    public class TodoService : ITodoService
    {
        private readonly IList<TodoItem> _todoItems;
        public TodoService()
        {
            _todoItems = new List<TodoItem>
            {
                new TodoItem("first"),
                new TodoItem("Second"),
            };
        }
        public void Add(TodoItem item)
        {
            _todoItems.Add(item);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _todoItems.ToList();
        }
    }
}
