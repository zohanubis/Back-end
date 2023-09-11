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
                Deparment emp = new Deparment();
                emp.DeptId = Convert.ToInt32(rdr.GetValue(0).ToString());
                emp.Name = rdr.GetValue(1).ToString();
                
                listDeparments.Add(emp);
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
    }
}