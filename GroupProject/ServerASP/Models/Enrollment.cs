﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ServerASP.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("StudentEnrolled")]
        public int StudentId { get; set; }
        [ForeignKey("EnrolledOn")]
        public int ModuleId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(TypeName = "date")]
        public DateTime? EnrollmentDate { get; set; }
        public virtual Student StudentEnrolled { get; set; }
        public virtual Module EnrolledOn { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }
    }
}