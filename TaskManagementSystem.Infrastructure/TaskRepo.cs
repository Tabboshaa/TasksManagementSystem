using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Core.Interfaces;

namespace TaskManagementSystem.Infrastructure
{
    public class TaskRepo : ITaskRepo
    {
        public IEnumerable<Task> GetAllTasks()
        {
            throw new NotImplementedException();
        }

        public Task GetTaskById(int taskId)
        {
            throw new NotImplementedException();
        }
        public void CreateTask(Task task)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(int taskId)
        {
            throw new NotImplementedException();
        }

        public void UpdateTask(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
