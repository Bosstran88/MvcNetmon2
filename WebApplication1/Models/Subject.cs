using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Subject")]
    public class Subject
    {
            public int SubjectId { get; set; }
            [Required][StringLength(150, MinimumLength = 8)] public string SubjectName { get; set; }
            [Required][StringLength(20, MinimumLength = 2)] public string SubjectCode { get; set; }
            [StringLength(500)] public string Description { get; set; }
            [Required][DataType(DataType.Date)][DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")] 
            public DateTime StartDate { get; set; }
            [Required]
            [DataType(DataType.Date)][DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")] 
            public DateTime EndDate { get; set; }
            public ICollection<Exam> Exams { get; set; }

        }
    }

