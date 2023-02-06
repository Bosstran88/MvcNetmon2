using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Exam")]
    public class Exam
    {
        public long Id { get; set; }
        public int  Score { get; set; }

        public long StudentId { get; set; }
        
        public int SubjetcId { get; set; }

    }
}
