using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace School.Models
{
    public partial class Person
    {
        public Person()
        {
            CourseInstructors = new HashSet<CourseInstructor>();
            StudentGrades = new HashSet<StudentGrade>();
        }
        [Display(Name = "ID")]
        public int PersonID { get; set; }
        [Display(Name = "Apellido")]
        [Required()]
        public string LastName { get; set; }
        [Display(Name = "Nombre")]
        [Required()]
        public string FirstName { get; set; }
        public DateTime? HireDate { get; set; }
        [Display(Name = "Fecha de alta")]
        public DateTime? EnrollmentDate { get; set; }

        public virtual OfficeAssignment OfficeAssignment { get; set; }
        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }
        public virtual ICollection<StudentGrade> StudentGrades { get; set; }
    }
}