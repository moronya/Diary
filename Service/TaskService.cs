using Diary.DAL;
using Diary.Models;
using Microsoft.AspNetCore.Mvc;

namespace Diary.Service
{
    public class TaskService
    {
        private ApplicationDbContext applicationDbContext;
        public TaskService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

      
       
    }
}
