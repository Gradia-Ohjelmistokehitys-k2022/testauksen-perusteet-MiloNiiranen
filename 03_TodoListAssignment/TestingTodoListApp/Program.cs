using System.Collections.Generic;
using System.Linq;
using TestingTodoListApp;

namespace TodoListNS
{

    public class Program
    {
        public static void Main()
        {
            TodoList todoList = new TodoList();

            todoList.AddItemToList(new TodoTask("Do the dishes"));
            todoList.AddItemToList(new TodoTask("Wash your clothes"));
            var list = todoList.All;
            var anotherList = todoList._TodoItems;
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            foreach (var item in anotherList)
            {
                Console.WriteLine(item);
            }

        }

    }
}
