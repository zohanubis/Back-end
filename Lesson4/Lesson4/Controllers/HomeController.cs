using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.Mvc;
using Lesson4.Models;

namespace Lesson4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Error() { return View(); }
        public ActionResult ShowEmployees()
        {
            List<Employee> listEmployee = new List<Employee>();
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    string conStr = "Data Source=ZOHANUBIS;Initial Catalog=QL_NhanSu;Integrated Security=True";
                    con.ConnectionString = conStr;
                    string sql = "SELECT * FROM tbl_Employee";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        var emp = new Employee();
                        emp.ID = (int)row["Id"];
                        emp.Name = row["Name"].ToString();
                        emp.Gender = row["Gender"].ToString();
                        emp.City = row["City"].ToString();
                        listEmployee.Add(emp);
                    }
                }
                return View(listEmployee);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }
        public ActionResult ShowEmployees1()
        {
            ConnectEmployee obj = new ConnectEmployee();
            List<Employee> empList = obj.getData();
            Session["sl"] = obj.getSL();
            return View(empList);
        }
        public ActionResult ShowDeparment()
        {
            ConnectDeparment obj = new ConnectDeparment();
            List<Deparment> empList = obj.getData();
            Session["sl"] = obj.getSL();
            return View(empList);
        }
    }
}