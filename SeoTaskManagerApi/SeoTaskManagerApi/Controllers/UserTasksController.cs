using Microsoft.AspNetCore.Mvc;
using SeoTaskManagerApi.Models;
using System.Collections.Generic;

namespace SeoTaskManagerApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserTasksController : BaseApiController
    {
        // GET: api/UserTasks/GetUserTasks
        /// <summary>
        /// Respond with all current user tasks
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<TaskResult> GetUserTasks()
        {
            // some service call with GetUserId() param
            return null;
        }

        // POST: api/UserTasks/CreateUserTask
        /// <summary>
        /// Create new task
        /// </summary>
        /// <param name="userTaskRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateUserTask([FromBody] UserTaskRequest userTaskRequest)
        {
            // some service call with GetUserId() param
            return null;
        }

        // PUT: api/UserTasks/UpdateUserTask
        /// <summary>
        /// Update existing user task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="taskResult"></param>
        /// <returns></returns>
        [HttpPut("{id}")] // or just post
        public IActionResult UpdateUserTask(int id, [FromBody] TaskResult taskResult)
        {
            // some service call with GetUserId() param
            return null;
        }

        // DELETE: api/UserTasks/DeleteUserTask/{id}
        /// <summary>
        /// Delete eisting user task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="taskResult"></param>
        /// <returns></returns>
        [HttpDelete("{id}")] // or just post
        public IActionResult DeleteUserTask(int id, [FromBody] TaskResult taskResult)
        {
            // some service call with GetUserId() param
            return null;
        }
    }
}