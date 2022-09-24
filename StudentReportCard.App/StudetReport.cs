using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReportCard.App
{
    [Table ("tab_student_report")]
    public class StudetReport
    {
        [Column ("id")]
        [Required]
        public int Id { get; set; }
        [Column("first_name")]
        [Required]
        public string? FirstName { get; set; }
        [Column("last_nane")]
        [Required]
        public string? LastName { get; set; }
        [Column("patronymic")]
        [Required]
        public string? Patronymic { get; set; }
        [Column("date_time")]
        [Required]
        public DateTime Date { get; set; }
        [Column("assessment")]
        [Required]
        public int Assessment { get; set; }
    }
}
