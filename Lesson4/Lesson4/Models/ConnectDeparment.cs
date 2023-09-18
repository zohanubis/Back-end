using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Lesson4.Models;
namespace Lesson4.Models
{
    public class ConnectDeparment
    {
        public string conStr = "Data Source=ZOHANUBIS;Initial Catalog=QL_NhanSu;Integrated Security=True";
        public List<Deparment> getData()
        {
            List<Deparment> listDeparments = new List<Deparment>();
            SqlConnection con = new SqlConnection(conStr);
            string sql = "SELECT * FROM tbl_Deparment";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Deparment dept = new Deparment();
                dept.DeptId = Convert.ToInt32(rdr.GetValue(0).ToString());
                dept.Name = rdr.GetValue(1).ToString();

                listDeparments.Add(dept);
            }
            return (listDeparments);

        }
        public int getSL()
        {
            SqlConnection con = new SqlConnection(conStr);
            string sql = "SELECT COUNT(*) FROM tbl_Deparment";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            int sl = (int)cmd.ExecuteScalar();
            con.Close();
            return sl;
        }

        public Deparment Details(string id)
        {
            List<Deparment> listDeparments = new List<Deparment>();
            SqlConnection con = new SqlConnection(conStr);
            string sql = "SELECT * FROM tbl_Deparment";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Deparment dept = new Deparment();
                dept.DeptId = Convert.ToInt32(rdr.GetValue(0).ToString());
                dept.Name = rdr.GetValue(1).ToString();

                listDeparments.Add(dept);
            }
            int ma = int.Parse(id);
            Deparment d = listDeparments.FirstOrDefault(i => i.DeptId == ma);
            return d;
        }
        public int SoNV(string id)
        {
            int ma = int.Parse(id);
            SqlConnection con = new SqlConnection(conStr);
            string sql = "SELECT COUNT(tbl_Employee.Id) AS SNV FROM tbl_Deparment,tbl_Employee WHERE tbl_Deparment.DeptId = tbl_Employee.DeptId and tbl_Deparment.DeptId= @MAPB";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            SqlParameter Par = cmd.CreateParameter();
            Par.ParameterName = "@MAPB";
            Par.Value = ma;
            cmd.Parameters.Add(Par);

            con.Open();
            int sl = (int)cmd.ExecuteScalar();
            con.Close();
            return sl;
        }
        public List<Employee> ListEmplByDept(string id)
        {
            int ma = int.Parse(id);
            List<Employee> listEmployees = new List<Employee>();
            SqlConnection con = new SqlConnection(conStr);
            string sql = "SELECT * FROM tbl_Employee WHERE DeptID = @MAPB";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            SqlParameter Par = cmd.CreateParameter();
            Par.ParameterName = "@MAPB";
            Par.Value = ma;
            cmd.Parameters.Add(Par);

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Employee emp = new Employee();
                emp.ID = Convert.ToInt32(rdr.GetValue(0).ToString());
                emp.Name = rdr.GetValue(1).ToString();
                emp.Gender = rdr.GetValue(2).ToString();
                emp.City = rdr.GetValue(3).ToString();

                listEmployees.Add(emp);
            }
            con.Close();
            return (listEmployees);
        }
        

    }
}