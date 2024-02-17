using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Core.Entities;
using TaskManagementSystem.Core.Interfaces;
using TaskManagementSystem.Infrastructure.Context;

namespace TaskManagementSystem.Infrastructure.Repositories
{
    public class TaskRepo : ITaskRepo
    {
        private readonly TMSDbContext _context;

        public TaskRepo(TMSDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TaskEntity>> GetAllTasksAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<TaskEntity> GetTaskByIdAsync(Guid id)
        {
            return await _context.Tasks.FirstOrDefaultAsync(task => task.Id == id);
        }

        public async Task CreateTaskAsync(TaskEntity task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
        }

        public void DeleteTask(int taskId)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateTaskAsync(Guid id ,TaskEntity updatedTask)
        {
            var existingTask = await GetTaskByIdAsync(id);
            if (existingTask == null)
            {
                throw new Exception($"Task with ID {id} not found.");
            }

            existingTask.Title = updatedTask.Title;
            existingTask.Description = updatedTask.Description;
            existingTask.Status = updatedTask.Status;
            existingTask.Priority = updatedTask.Priority;
            existingTask.DeadLine = updatedTask.DeadLine;

            _context.Entry(existingTask).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(Guid id)
        {
            var existingTask = await GetTaskByIdAsync(id);
            if (existingTask == null)
            {
                throw new Exception($"Task with ID {id} not found.");
            }
            
            _context.Tasks.Remove(existingTask);
            await _context.SaveChangesAsync();
            
        }
    }
}
