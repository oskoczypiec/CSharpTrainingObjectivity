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
        private List<ToDoTask> taskList;

        public ToDoListEngine()
        {
            this.taskList = new List<ToDoTask>();
        }

        public void AddTask(ToDoTask task)
        {
            this.taskList.Add(task);
        }

        public List<ToDoTask> FindTask(string query)
        {
            return this.taskList.Where(x => x.Title.Contains(query) || x.Description.Contains(query)).ToList();
        }

        public List<ToDoTask> FindTask(string query, Objectivity.CSharp.Interfaces.TaskStatus status, DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<ToDoTask> GetAllTasks()
        {
            return this.taskList.Where(x => x.Title != string.Empty).ToList();
        }

        public List<ToDoTask> GetTaskDueToday()
        {
            return this.taskList.Where(x => x.DueDate == DateTime.Today).ToList();
        }

        public List<ToDoTask> GetTasks(DateTime date)
        {
            return this.taskList.Where(x => x.CreatedDate == date || x.DoneDate == date || x.DueDate == date || x.ModifiedDate == date).ToList();
        }

        public List<ToDoTask> GetTasks(DateTime start, DateTime end)
        {
            return this.taskList.Where(x => x.CreatedDate == start && x.DoneDate == end).ToList();
        }

        public void UpdateTask(ToDoTask task)
        {
            throw new NotImplementedException();
        }
    }
}
