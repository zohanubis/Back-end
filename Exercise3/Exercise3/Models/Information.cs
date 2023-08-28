using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Exercise3.Models
{
    public class Information
    {
       [Required()]
       [StringLength(10,ErrorMessage = "Chiều dài tên không quá 50 ký tự")]
       public string FullName { get; set; }

        [Required()]
        [StringLength(10, ErrorMessage = "Chiều dài tên không quá 50 ký tự")]
        
        public string IDStudent { get; set; }
        [Required(ErrorMessage ="Bắt buộc nhập Email Address !")]
        [EmailAddress(ErrorMessage ="Địa chỉ email không hợp lệ")]

        public string Email { get; set; }
        public string FileImage { get; set; }
        public string Note { get; set; }
        public bool Check1 { get; set; }
        public bool Check2 { get; set; }
        public bool Check3 { get; set; }


        public string ChooseWorkTime { get; set; }
        [Required]
        public string SelectCourse { get; set; }
    }
}