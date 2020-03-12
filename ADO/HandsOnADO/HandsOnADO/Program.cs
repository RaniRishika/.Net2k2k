using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HandsOnADO
{
    class Program
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G33N13I\SQLEXPRESS;
Initial Catalog=PracticeDB;User ID=sa;Password=pass@word1");
        SqlCommand cmd = null;
        public  void Add()
        {
            try
            {
                cmd = new SqlCommand("Insert into project values(@id,@pname,@sdate,@edate)", con);
                //passing value to parameters
                cmd.Parameters.AddWithValue("@id", "P0006");
                cmd.Parameters.AddWithValue("@pname", "Boing");
                cmd.Parameters.AddWithValue("@sdate", DateTime.Parse("12.2.2019"));
                cmd.Parameters.AddWithValue("@edate", DateTime.Parse("10.2.2022"));
                con.Open();//open connection
                cmd.ExecuteNonQuery();//execute query(dml)
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();//close connection
            }
        }
        public void GetProjectById(string pid)
        {
           try
            {
                cmd = new SqlCommand("Select * from Project where Pid=@pid", con);
                cmd.Parameters.AddWithValue("@pid", pid);
                con.Open();
                SqlDataReader dr=cmd.ExecuteReader(); //execute select statment
                if (dr.HasRows) //check rows existence
                {
                    //Read records in datareader
                    dr.Read(); //ready only one record
                    Console.WriteLine("ID:{0} Name:{1} SDate:{2} EDate:{3}",
                        dr["pid"], dr["pname"], dr["sdate"], dr["edate"]);
                }
                else
                    Console.WriteLine("Invalid Project ID");
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void GetAllProjects()
        {
            try
            {
                cmd = new SqlCommand("Select * from Project", con);
                con.Open();
                SqlDataReader dr=cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        Console.WriteLine("ID:{0} Name:{1} SDate:{2} EDate:{3}",
                        dr["pid"], dr["pname"], dr["sdate"], dr["edate"]);
                    }
                }
                else
                    Console.WriteLine("Table Empty");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();//close connection
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            // obj.Add();
            //obj.GetProjectById("P0090");
            obj.GetAllProjects();
            Console.ReadKey();
        }
    }
}
