using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objectivity.CSharp.Interfaces;
using Objectivity.CSharp.Interfaces.Properties;

namespace ToDoList.Logic
{
    public class ToDoListEngine : ToDoListEngineInterface
    {
        List<ToDoTask> taskList;
        public ToDoListEngine()
        {
            taskList = new List<ToDoTask>();
        }
        public void AddTask(ToDoTask task)
        {
            taskList.Add(task);
        }

        public List<ToDoTask> FindTask(string query)
        {
            throw new NotImplementedException();
        }

        public List<ToDoTask> FindTask(string query, Objectivity.CSharp.Interfaces.TaskStatus status, DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<ToDoTask> GetAllTasks()
        {
            throw new NotImplementedException();
        }

        public List<ToDoTask> GetTaskDueToday()
        {
            throw new NotImplementedException();
        }

        public List<ToDoTask> GetTasks(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<ToDoTask> GetTasks(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public void UpdateTask(ToDoTask task)
        {
            throw new NotImplementedException();
        }
    }
}
