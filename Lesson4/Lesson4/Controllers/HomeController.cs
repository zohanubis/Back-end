using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.Mvc;
using Lesson4.Models;
using System.Configuration;

namespace Lesson4.Controllers
{
    public class HomeController : Controller
    {
        //string conCtr = ConfigurationManager.ConnectionStrings["Connect1"].ConnectionString;
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
        public ActionResult ShowDetailsDeparment(string id)
        {
            ConnectDeparment obj = new ConnectDeparment();
            Deparment dept = obj.Details(id);
            ViewBag.SNV = obj.SoNV(id);
            return View(dept);
        }
        //------------------------------------------------------------------
        public ActionResult ShowDDLDept()
        {
            ConnectDeparment obj = new ConnectDeparment();
            List<Deparment> deptList = obj.getData();
            return View(deptList);
        }
        public ActionResult ShowListEmplByDept(string id)
        {
            ConnectDeparment obj = new ConnectDeparment();
            Deparment dept = obj.Details(id);
            List<Employee> listEmp = obj.ListEmplByDept(id);
            ViewBag.empList = listEmp;
            return View(dept);
        }
        //--------------------------------------------------------------
        public ActionResult CreateEmployee() { return View(); }
        [HttpPost]
        public ActionResult CreateEmployee(FormCollection fc)
        {
            ConnectEmployee obj = new ConnectEmployee();
            var name = fc["FullName"];
            var gender = fc["Gender"];
            var city = fc["City"];
            var deptID = int.Parse(fc["DeptID"]);

            int kt = obj.InsertEmployees(name, gender, city, deptID);
            if(kt == 1)
            {
                ViewBag.ThongBao = "Thêm thành công";
            }
            else
            {
                ViewBag.ThongBao = "Thêm không thành công";            }
            return View();
        }
    }
}