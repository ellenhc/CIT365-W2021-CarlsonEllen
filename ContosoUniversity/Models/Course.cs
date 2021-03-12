using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; } // foreign key

        public Department Department { get; set; } // Department navigation property 
        public ICollection<Enrollment> Enrollments { get; set; } //  course can have any number of students enrolled
        public ICollection<CourseAssignment> CourseAssignments { get; set; } // course may be taught by multiple instructors
    }
}
