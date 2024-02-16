using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Core.Interfaces
{
    public interface ITaskRepo
    {
        Task GetTaskById(int taskId);
        IEnumerable<Task> GetAllTasks();
        void CreateTask(Task task);
        void UpdateTask(Task task);
        void DeleteTask(int taskId);
    }
}
