﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTodoListApp
{
    public class TodoList
    {

        private readonly List<TodoTask> _todoItems;
        private int _taskCounter = 0;
        public IEnumerable<TodoTask> All => _TodoItems; //https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.all?view=net-6.0
        public List<TodoTask> _TodoItems { get => _todoItems;}
       

        public TodoList()
        {
            _todoItems = new List<TodoTask>();
            string defaultTask = $"Task number {_taskCounter}";
            TodoTask item = new(defaultTask);
        }
        public void AddItemToList(TodoTask item)
        {
            _todoItems.Add(new TodoTask(item.TaskDescription) { Id = _taskCounter++ });
        }

        public void RemoveItemFromList(TodoTask item)
        {
            _todoItems.Remove(item with { Id = --_taskCounter});
        }

        public void CompleteItem(int id)
        {
            var item = _todoItems.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _todoItems.Remove(item);
            }
        }


    }
}
