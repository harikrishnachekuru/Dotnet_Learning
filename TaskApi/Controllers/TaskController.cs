using Microsoft.AspNetCore.Mvc;
using TaskApi.Models;
using TaskApi.Data;

namespace TaskApi.Controllers
{
    [ApiController]
    [Route("tasks")]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTaskDetails()
        {
            return Ok(new { tasks = TaskData.Tasks });
        }

        [HttpGet("{taskId}")]
        public IActionResult GetTasksById(string taskId)
        {
            var Task = TaskData.Tasks.FirstOrDefault(x => x.Id == taskId);
            if (Task == null) return NotFound();

            return Ok(Task);
        }

        [HttpGet("Ordering")]
        public IActionResult GetOrdering()
        {
            List<string> result = new();
            HashSet<string> visited = new();

            void DFS(string taskId)
            {
                if (visited.Contains(taskId)) return;

                visited.Add(taskId);

                var Task = TaskData.Tasks.FirstOrDefault(x => x.Id == taskId);
                if (Task == null) return;

                foreach(var dep in Task.Dependencies)
                {
                    DFS(dep);
                }
                result.Add(taskId);
            }
            foreach(var t in TaskData.Tasks)
            {
                DFS(t.Id);
            }
            return Ok(result);
        }

    }
}