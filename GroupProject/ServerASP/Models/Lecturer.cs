﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ServerASP.Models
{
    public class Lecturer
    {
        
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string SecondName { get; set; }

            public virtual ICollection<Delivery> LecturerDelivery { get; set; }
        }
}