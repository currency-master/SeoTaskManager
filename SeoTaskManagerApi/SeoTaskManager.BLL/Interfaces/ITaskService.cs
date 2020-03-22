using SeoTaskManager.Domain.Models;
using System.Collections.Generic;

namespace SeoTaskManager.BLL.Interfaces
{
    public interface ITaskService
    {
        IEnumerable<UserTask> GetNewTasks(int userId);

        bool ProcessTaskResult(int userId, IEnumerable<UserTask> userTasks);
    }
}