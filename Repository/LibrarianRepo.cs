using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using Entity;
using Repository;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;


namespace Repository
{
    public class LibrarianRepo: ILibrarianRepo
    {
        DatabaseConnectionClass dcc;

        public LibrarianRepo()
        {
            dcc = new DatabaseConnectionClass();
        }
        public SqlCommand myCommand { get; set; }

        public bool InsertLibrarian(Librarian librarian, byte[] images)
        {
            string query = "INSERT into Librarian VALUES ( '" + librarian.Id + "','" + librarian.Email + "','" + librarian.Contact + "','" + librarian.Address + "','" + librarian.Salary + "', '" + librarian.FirstName + "',  '" + librarian.LastName + "',   '" + librarian.Password + "', '" + librarian.Confirm + "',  '" + @librarian.Image + "','" + librarian.Surname + "', '" + librarian.UserName + "')";
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
           /* string sqlQuery = "Insert into Librarian(Image)values(@image) WHERE Id='" + librarian.Id + "'";
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
            */
        }

       /* public bool InsertLogin(Librarian librarian)
        {
            string role = "1";
            string query1 = "INSERT into Login(Id,Password,Role) VALUES('" + librarian.Id + "','" + librarian.Password + "','" + role+"')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query1);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }*/
        public bool InsertLogin(Librarian l)
        {
            string role = "0";
            string query1 = "INSERT into Login(id,Password,Role) VALUES('" + l.Id + "','" + l.Password + "','" + role + "')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query1);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }

        }




        public bool RemoveLibrarian(string librarianID)
        {
            string query3 = "DELETE from Librarian WHERE Id = '" + librarianID + "'";
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

        public bool UpdateLibrarian(Librarian librarian)
        {
            string query2 = "UPDATE Librarian SET Id = '" + librarian.Id + "', Email ='" + librarian.Email + "', Contact='" + librarian.Contact + "', Address='" + librarian.Address + "', Salary= '" + librarian.Salary + "', FirstName='" + librarian.FirstName + "', LastName='" + librarian.LastName + "', Password='" + librarian.Password + "', Confirm ='" + librarian.Confirm + "', Image = '" + librarian.Image + "', Surname ='" + librarian.Surname + "', UserName = '" + librarian.UserName + "' WHERE Id = '" + librarian.Id + "' ";


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

        public List<Librarian> GetAllLibrarian()
        {
            List<Librarian> listOfLibrarian = new List<Librarian>();

            string query = "SELECT * from Librarian";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Librarian l = new Librarian();
                l.Id = sdr["Id"].ToString();
                l.Email = sdr["Email"].ToString();
                l.Contact = sdr["Contact"].ToString();
                l.Address = sdr["Address"].ToString();
                l.Salary = Convert.ToDouble(sdr["Salary"].ToString());
                l.FirstName = sdr["Firstname"].ToString();
                l.LastName = sdr["LastName"].ToString();
               // l.Password = sdr["Password"].ToString();
                //l.Confirm = sdr["Confirm"].ToString();
                l.Surname = sdr["Surname"].ToString();
                l.UserName = sdr["UserName"].ToString();


                

                listOfLibrarian.Add(l);
            }

            dcc.CloseConnection();

            return listOfLibrarian;


        }


        public Librarian GetLibrarian(string librarianID)
        {
            throw new NotImplementedException();
        }
    }
}
