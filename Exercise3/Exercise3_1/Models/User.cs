using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Exercise3_1.Models
{
    public class User
    {
        [Required()]
        [StringLength(10, ErrorMessage = "Chiều dài tên không quá 50 ký tự")]
        public string FullName { get; set; }
        public string PassWord { get; set; }

    }
}