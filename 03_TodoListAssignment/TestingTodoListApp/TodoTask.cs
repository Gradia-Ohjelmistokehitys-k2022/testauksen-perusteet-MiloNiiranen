using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestingTodoListApp
{
    public record TodoTask
    {
        public int Id  { get; set; }
        public string TaskDescription { get; init; }
        public bool IsCompleted { get; init; }

        public TodoTask(string taskDescription)
        {
            TaskDescription = taskDescription;
        }
        public override string ToString()
        {
            return $"Id: {Id} + Task: {TaskDescription} + Did you do it?: {IsCompleted}";
        }
    }

}





