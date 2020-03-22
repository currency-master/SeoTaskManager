using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SeoTaskManager.BLL.Interfaces;
using SeoTaskManager.Domain.Models;
using SeoTaskManagerApi.Models;
using System.Collections.Generic;

namespace SeoTaskManagerApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ParserTasksController : BaseApiController
    {
        private readonly ITaskService _taskService;
        private readonly IMapper _mapper;

        public ParserTasksController(ITaskService taskService, IMapper mapper)
        {
            _taskService = taskService;
            _mapper = mapper;
        }

        // GET: api/UserTasks/GetNewTasks
        /// <summary>
        /// Returns list of new unfinished Tasks
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<ParserTaskResponse> GetNewTasks()
        {
            IEnumerable<UserTask> newTasks = _taskService.GetNewTasks(GetUserId());
            return _mapper.Map<IEnumerable<ParserTaskResponse>>(newTasks);
        }

        // POST: api/UserTasks/PostTaskResult
        /// <summary>
        /// Receives list of completed tasks results
        /// </summary>
        /// <param name="userTaskResult"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PostTaskResult([FromBody] List<TaskResult> userTaskResult)
        {
            // some service call with GetUserId() param
            return Ok();
        }
    }
}