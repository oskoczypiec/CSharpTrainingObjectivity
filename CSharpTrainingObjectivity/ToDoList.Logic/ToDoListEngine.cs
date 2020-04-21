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
            return taskList.Where(x => x.Title.Contains(query) || x.Description.Contains(query)).ToList();
        }

        public List<ToDoTask> FindTask(string query, Objectivity.CSharp.Interfaces.TaskStatus status, DateTime date)
        {
            return taskList.Select(x => x.)
        }

        public List<ToDoTask> GetAllTasks()
        {
            return taskList.Where(x => x.Title != string.Empty).ToList();
        }

        public List<ToDoTask> GetTaskDueToday()
        {
            return taskList.Where(x => x.DueDate == DateTime.Today).ToList();
        }

        public List<ToDoTask> GetTasks(DateTime date)
        {
            return taskList.Where(x => x.CreatedDate == date || x.DoneDate == date || x.DueDate == date || x.ModifiedDate == date).ToList();
        }

        public List<ToDoTask> GetTasks(DateTime start, DateTime end)
        {
            return taskList.Where(x => x.CreatedDate == start && x.DoneDate == end).ToList();
        }

        public void UpdateTask(ToDoTask task)
        {
            throw new NotImplementedException();
        }
    }
}
