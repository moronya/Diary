using Diary.DAL;
using Diary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Diary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskActivityController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public TaskActivityController(ApplicationDbContext context)
        {
            this._context = context;
        }
    
        [HttpPost]
        public async Task<TaskActivity> createTask(TaskActivity taskActivity)
        {
            _context.Add(taskActivity);
            await _context.SaveChangesAsync();
            return taskActivity;
        }
        [HttpGet]
        public async Task<IEnumerable<TaskActivity>> getTask()
        {
            return await _context.taskActivities.ToListAsync();
        }
        // get one
        [HttpGet("{id}")]
        public async Task<ActionResult> getActivity(int id)
        {
            var task = await _context.taskActivities.FirstOrDefaultAsync(r => r.id == id);
            if (task == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(task);
            } 
        }
        // edit
        [HttpPut]
        public async Task<ActionResult> editActivity(TaskActivity task)
        {
            if(task == null || task.id == 0)
            {
                return BadRequest();
            }
            else
            {
                var editTask = await _context.taskActivities.FindAsync(task.id);
                if(editTask == null)
                {
                    return NotFound();
                }
                else
                {
                    editTask.description = task.description;
                    editTask.startDate = task.startDate;
                    editTask.endDate = task.endDate;
                    editTask.posted = task.posted;
                    await _context.SaveChangesAsync();
                    return Ok();
                }
            }
        }
        //delete
        [HttpDelete("{id}")]
        public async Task<ActionResult> deleteTask(int id)
        {
            var task = await _context.taskActivities.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            else
            {
                _context.taskActivities.Remove(task);
                await _context.SaveChangesAsync();
                return Ok();
            }

        }
    }
}
