using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Diary.Models
{
    public class TaskActivity
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string description { get; set; }
        public DateTime posted { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
