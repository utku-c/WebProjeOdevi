﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models
{
    public class UserCreateRequestModel
    {
        [Required(ErrorMessage ="NameSurname_Required")]
        [DisplayName("NameSurname")]
        public string NameSurname { get; set; }


        [Required(ErrorMessage = "JobTitle_Required")]
        [DisplayName("JobTitle")]
        public string JobTitle { get; set; }

    }
}
