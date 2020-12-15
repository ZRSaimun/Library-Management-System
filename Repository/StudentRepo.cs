using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Interface;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace Repository
{
   public class StudentRepo : IStudentRepo 
    {
        
        DatabaseConnectionClass dcc;

        public StudentRepo()
        {
            dcc = new DatabaseConnectionClass();
        }
        public SqlCommand myCommand { get; set; }


      

        public bool InsertStudent(Student student, byte[] images)
        {
            string query = "INSERT into Student VALUES ('" + @student.Image + "', '" + student.Id + "', '" + student.Firstname + "', '" + student.Surname + "', '" + student.Lastname + "', '" + student.Contact + "', '" + student.Dept + "', '" + student.Year + "','" + student.Type + "', '" + student.Due + "', '" + student.Borrowed + "')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
            string sqlQuery = "Insert into Student(Image)values(@image) WHERE Id='" + student.Id + "'";
            try
            {
                myCommand = new SqlCommand(sqlQuery);
                myCommand.Parameters.Add(new SqlParameter("@image", images));
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                // MessageBox.Show(N.ToString() + "Data Saved Successfully..!"); 
            }
            catch
            {
                //MessageBox.Show("Please insert your image");
            }

           
        }

        public Student GetStudent(string id)
        {
            Student stu = null;
            string query = "SELECT * from Student WHERE ID = '" + id + "' ";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                stu = new Student();
                //stu.Image = sdr["Image"].ToString;
                //pictureBox1.Image = new Bitmap(ms)
                stu.Id = sdr["Id"].ToString();
                stu.Firstname = sdr["Firstname"].ToString();
                stu.Surname = sdr["Surname"].ToString();
                stu.Lastname = sdr["Lastname"].ToString();
                stu.Type = sdr["Type"].ToString();
                stu.Contact = sdr["Contact"].ToString();
                stu.Dept = sdr["Dept"].ToString();
                stu.Year = sdr["Year"].ToString();
                stu.Due = Convert.ToInt32(sdr["Due"].ToString());
                stu.Borrowed = Convert.ToInt32(sdr["Borrowed"].ToString());
            }

            dcc.CloseConnection();
            return stu;
        }

        public List<Student> GetAllStudent()
        {
            List<Student> listOfStudent = new List<Student>();

            string query = "SELECT * from Student";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Student stu = new Student();
                //stu.Image = sdr["Image"].ToString;
                //pictureBox1.Image = new Bitmap(ms)
                stu.Id = sdr["Id"].ToString();
                stu.Firstname = sdr["Firstname"].ToString();
                stu.Surname = sdr["Surname"].ToString();
                stu.Lastname = sdr["Lastname"].ToString();
                stu.Contact = sdr["Contact"].ToString();
                stu.Dept = sdr["Dept"].ToString();
                stu.Year = sdr["Year"].ToString();
                stu.Type = sdr["Type"].ToString();
                int s, z;

                bool sa = Int32.TryParse((sdr["Due"].ToString()),out s);
                bool za = Int32.TryParse((sdr["Borrowed"].ToString()), out z);
                
                stu.Due = s;
                stu.Borrowed = z;

                listOfStudent.Add(stu);
            }

            dcc.CloseConnection();

            return listOfStudent;
        }

        public bool UpdateStudentBorrow(string studentID, int copies)
        {
            int borrowed = 0; ;
            int due = 0;
            string query = "SELECT Borrowed,Due from Student WHERE ID = '" + studentID + "' ";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                due = Convert.ToInt32(sdr["Due"].ToString());
                borrowed = Convert.ToInt32(sdr["Borrowed"].ToString());
            }
            dcc.CloseConnection();

            borrowed += copies;
            string query2 = "UPDATE Student SET Borrowed = '" + borrowed + "' WHERE ID = '" + studentID + "' ";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query2);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }



        }

       
        public bool InsertRecords(Student student)
        {
            string q = "Insert into Records(StudentID) VALUES('" +student.Id+ "')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(q);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

        public bool UpdateStudent(Student student)
        {
            string query2 = "UPDATE Student SET Image = '" + @student.Image + "', Firstname='" + student.Firstname + "', Surname='" + student.Surname + "', Lastname='" + student.Lastname + "', Contact= '" + student.Contact + "', Dept='" + student.Dept + "', Year='" + student.Year + "', Type='" + student.Type + "', Due ='" + student.Due + "', Borrowed = '" + student.Borrowed + "' WHERE Id = '" + student.Id + "' ";

            
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query2);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

        public bool RemoveStudent(string studentId)
        {
            string query3 = "DELETE from Student WHERE Id = '" + studentId + "'";
            //myCommand = new SqlCommand();
            //  myCommand.Parameters.Add(new SqlParameter("@book.Image",book.Image));
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query3);
                dcc.CloseConnection();
                return true;
                
            }
            catch (Exception exp)
            {
                return false;
            }
        }

    }
}
