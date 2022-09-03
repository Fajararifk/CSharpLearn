using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_NorthwindDB
{
    public class Student
    {
        [Key]
        public int studentId { get; set; }
        [Required]
        public string fullName { get; set; }
        public int age { get; set; }
    }
}
