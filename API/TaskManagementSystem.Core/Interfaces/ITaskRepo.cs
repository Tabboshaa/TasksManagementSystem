using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Core.Entities;

namespace TaskManagementSystem.Core.Interfaces
{
    public interface ITaskRepo
    {
        Task<TaskEntity> GetTaskByIdAsync(Guid id);
        Task<IEnumerable<TaskEntity>> GetAllTasksAsync();
        Task CreateTaskAsync(TaskEntity task);
        Task UpdateTaskAsync(Guid id, TaskEntity updatedTask);
        Task DeleteTaskAsync(Guid id);
    }
}
