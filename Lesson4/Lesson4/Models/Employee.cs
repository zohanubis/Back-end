using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Lesson4.Models
{
    public class Employee
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Gender { get; set; }
        public string City { get; set; }
       
    }
}