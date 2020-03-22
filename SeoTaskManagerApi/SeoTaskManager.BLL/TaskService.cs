using SeoTaskManager.BLL.Interfaces;
using SeoTaskManager.Domain.Models;
using System.Collections.Generic;

namespace SeoTaskManager.BLL
{
    public class TaskService : ITaskService
    {
        public IEnumerable<UserTask> GetNewTasks(int userId)
        {
            //return userTaskRepository.GetNewTasks();
            return new List<UserTask>() { new UserTask() { Id = 1, GoodName = "111", KeyWord = "Red" }, new UserTask() { Id = 2, GoodName = "222", KeyWord = "Blue" } };
        }

        public bool ProcessTaskResult(int userId, IEnumerable<UserTask> userTasks)
        {
            //var result = true;
            //try
            //{
            //    foreach (var item in userTasks)
            //    {
            //        userTaskRepository.Update(item);
            //    }
            //    userTaskRepository.SaveAll();
            //}
            //catch (SqlException)
            //{
            //    result = false;
            //}

            return true;
        }
    }
}