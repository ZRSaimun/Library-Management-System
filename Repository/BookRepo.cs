using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Data;

using System.ComponentModel;

using System.Drawing;
using System.IO;



namespace Repository
{
    public class BookRepo : IBookRepo
    {
        DatabaseConnectionClass dcc;

        public BookRepo()
        {
            dcc = new DatabaseConnectionClass();
        }




        public bool InsertBook(Book book, byte[] images)
        {
            string query = "INSERT into Books VALUES ('" + @book.Image + "', '" + book.BookId + "', '" + book.Copies + "', '" + book.Title + "', '" + book.Author + "', '" + book.Classification + "', '" + book.Publisher + "', '" + book.Subtitle + "', '" + book.Copyright + "', '" + book.Place + "','" + book.PublishDate + "')";
            //myCommand = new SqlCommand();
            //  myCommand.Parameters.Add(new SqlParameter("@book.Image",book.Image));
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

            string sqlQuery = "Insert into Books(Image)values(@images) WHERE BookId='" + book.BookId + "'";
            try
            {
                myCommand = new SqlCommand(sqlQuery);
                myCommand.Parameters.Add(new SqlParameter("@images", images));
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                 //MessageBox.Show(n.ToString() + "Data Saved Successfully..!"); 
            }
            catch
            {
                //MessageBox.Show("Please insert your image");


            }

            dcc.CloseConnection();




        }
        public List<Book> GetAllBooks()
        {
            List<Book> listOfBook = new List<Book>();

            string query = "SELECT * from Books";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Book book = new Book();
                //book.Image = sdr["Image"].;
                // pictureBox1.Image = new Bitmap(ms)
                book.BookId = sdr["BookId"].ToString();
                book.Copies = Convert.ToInt32(sdr["Copies"].ToString());
                book.Title = sdr["Title"].ToString();
                book.Author = sdr["Author"].ToString();
                book.Classification = sdr["Classification"].ToString();
                book.Publisher = sdr["Publisher"].ToString();
                book.Subtitle = sdr["subtitle"].ToString();
                book.Copyright = sdr["Copyright"].ToString();
                book.Place = sdr["Place"].ToString();
                book.PublishDate = sdr["PublishDate"].ToString();



                listOfBook.Add(book);
            }

            dcc.CloseConnection();

            return listOfBook;



        }


        public List<Book> GetAllBooks(string studentID)
        {
            List<Book> listOfBook = new List<Book>();
            string bookID1=null;
            string bookID2 = null;
            string bookID3 =null;
            string query = "SELECT * from Records WHERE StudentID='"+studentID+"' ";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                
                bookID1 = sdr["BookID1"].ToString();
                bookID2 = sdr["BookID2"].ToString();
                bookID3 = sdr["BookID3"].ToString();
                
            }
            dcc.CloseConnection();

            if (bookID1== null)
            {

            }
            else
            {
                string query1 = "SELECT * from Books WHERE BookId = '" + bookID1 + "'";

                dcc.ConnectWithDB();
                sdr = dcc.GetData(query1);

                while (sdr.Read())
                {
                    Book book = new Book();
                    //book.Image = sdr["Image"].;
                    // pictureBox1.Image = new Bitmap(ms)
                    book.BookId = sdr["BookId"].ToString();
                    book.Copies = Convert.ToInt32(sdr["Copies"].ToString());
                    book.Title = sdr["Title"].ToString();
                    book.Author = sdr["Author"].ToString();
                    book.Classification = sdr["Classification"].ToString();
                    book.Publisher = sdr["Publisher"].ToString();
                    book.Subtitle = sdr["subtitle"].ToString();
                    book.Copyright = sdr["Copyright"].ToString();
                    book.Place = sdr["Place"].ToString();
                    book.PublishDate = sdr["PublishDate"].ToString();



                    listOfBook.Add(book);
                }
            }
            dcc.CloseConnection();

            if (bookID2==null)
            {

            }
            else
            {
                string query2 = "SELECT * from Books WHERE BookId = '" + bookID2 + "'";

                dcc.ConnectWithDB();
                sdr = dcc.GetData(query2);

                while (sdr.Read())
                {
                    Book book = new Book();
                    //book.Image = sdr["Image"].;
                    // pictureBox1.Image = new Bitmap(ms)
                    book.BookId = sdr["BookId"].ToString();
                    book.Copies = Convert.ToInt32(sdr["Copies"].ToString());
                    book.Title = sdr["Title"].ToString();
                    book.Author = sdr["Author"].ToString();
                    book.Classification = sdr["Classification"].ToString();
                    book.Publisher = sdr["Publisher"].ToString();
                    book.Subtitle = sdr["subtitle"].ToString();
                    book.Copyright = sdr["Copyright"].ToString();
                    book.Place = sdr["Place"].ToString();
                    book.PublishDate = sdr["PublishDate"].ToString();



                    listOfBook.Add(book);
                }
            }
            dcc.CloseConnection();

            if (bookID3==null)
            {
                
            }
            else
	{
        string query3 = "SELECT * from Books WHERE BookId = '" + bookID3 + "'";

        dcc.ConnectWithDB();
        sdr = dcc.GetData(query3);

        while (sdr.Read())
        {
            Book book = new Book();
            //book.Image = sdr["Image"].;
            // pictureBox1.Image = new Bitmap(ms)
            book.BookId = sdr["BookId"].ToString();
            book.Copies = Convert.ToInt32(sdr["Copies"].ToString());
            book.Title = sdr["Title"].ToString();
            book.Author = sdr["Author"].ToString();
            book.Classification = sdr["Classification"].ToString();
            book.Publisher = sdr["Publisher"].ToString();
            book.Subtitle = sdr["subtitle"].ToString();
            book.Copyright = sdr["Copyright"].ToString();
            book.Place = sdr["Place"].ToString();
            book.PublishDate = sdr["PublishDate"].ToString();



            listOfBook.Add(book);
	}
            }
            dcc.CloseConnection();

            return listOfBook;
        }


        public bool RemoveBook(string bookID)
        {
            string qq = "DELETE FROM Books WHERE BookId='" + bookID + "';";
            //myCommand = new SqlCommand();
            //  myCommand.Parameters.Add(new SqlParameter("@book.Image",book.Image));
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(qq);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }

        }

        public bool UpdateBook(Book book)
        {
            string query2 = "UPDATE Books SET Copies = '" + book.Copies + "', Title = '" + book.Title + "', Author = '" + book.Author + "', Classification = '" + book.Classification + "', Publisher = '" + book.Publisher + "', subtitle = '" + book.Subtitle + "', Copyright = '" + book.Copyright + "', Place = '" + book.Place + "', PublishDate = '" + book.PublishDate + "' WHERE BookId = '" + book.BookId + "' ";
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
        public bool UpdateBook(string bookID, int copies)
        {
            string query2 = "UPDATE Books SET Copies = '" + copies + "' WHERE BookId = '" + bookID + "' ";
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

        public bool UpdateRecords(BorrowRecords br)
        {


            string tmp1 = Convert.ToString(br.BorrowDate);
            string[] bdate1 = tmp1.Split(' ');
            string bdate = bdate1[0];
            string tme2 = Convert.ToString(br.DueDate);
            string[] ddate1 = tme2.Split(' ');
            string ddate = ddate1[0];
            string query = "UPDATE Records SET BookID1='" + br.BookID1 + "',BookID2='" + br.BookID2 + "',BookID3= '" + br.BookID3 + "', BorrowDate=  '" + bdate + "',DueDate = '" + ddate + "' WHERE StudentID ='" + br.StudentID + "' ";
            //myCommand = new SqlCommand();
            //  myCommand.Parameters.Add(new SqlParameter("@book.Image",book.Image));
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


        }

        public bool UpdateRecords(string bookID,string studentID)
        {
            string bookID1 = null;
            string bookID2 = null;
            string bookID3 = null;
            string query = "SELECT * from Records WHERE StudentID='" + studentID + "' ";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                bookID1 = sdr["BookID1"].ToString();
                bookID2 = sdr["BookID2"].ToString();
                bookID3 = sdr["BookID3"].ToString();

            }
            dcc.CloseConnection();

            if (bookID1.Equals(bookID))
            {
                string qq = "UPDATE Records SET BookID1='"+null+"' FROM Records WHERE StudentID='" + studentID + "';";
                //myCommand = new SqlCommand();
                //  myCommand.Parameters.Add(new SqlParameter("@book.Image",book.Image));
                try
                {
                    dcc.ConnectWithDB();
                    int n = dcc.ExecuteSQL(qq);
                    dcc.CloseConnection();
                    return true;
                }
                catch (Exception exp)
                {
                    return false;
                }
            }
            else if (bookID2.Equals(bookID))
            {
                string qq = "UPDATE Records SET BookID1='" + null + "' FROM Records WHERE StudentID='" + studentID + "';";
                //myCommand = new SqlCommand();
                //  myCommand.Parameters.Add(new SqlParameter("@book.Image",book.Image));
                try
                {
                    dcc.ConnectWithDB();
                    int n = dcc.ExecuteSQL(qq);
                    dcc.CloseConnection();
                    return true;
                }
                catch (Exception exp)
                {
                    return false;
                }
            }
            else 
            {
                string qq = "UPDATE Records SET BookID1='" + null + "' FROM Records WHERE StudentID='" + studentID + "';";
                //myCommand = new SqlCommand();
                //  myCommand.Parameters.Add(new SqlParameter("@book.Image",book.Image));
                try
                {
                    dcc.ConnectWithDB();
                    int n = dcc.ExecuteSQL(qq);
                    dcc.CloseConnection();
                    return true;
                }
                catch (Exception exp)
                {
                    return false;
                }
            }







            

        }

        public List<BorrowRecords> GetAllRecords()
        {
            List<BorrowRecords> listOfRecords = new List<BorrowRecords>();

            string query = "SELECT * from Records";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                BorrowRecords r = new BorrowRecords();
                //book.Image = sdr["Image"].;
                // pictureBox1.Image = new Bitmap(ms)
                r.StudentID = sdr["StudentID"].ToString();
                r.BookID1 = sdr["BookID1"].ToString();
                r.BookID2 = sdr["BookID2"].ToString();
                r.BookID3 = sdr["BookID3"].ToString();
                r.BorrowDate= sdr["BorrowDate"].ToString();
                r.DueDate = sdr["DueDate"].ToString();
             //  r.BorrowDate = Convert.ToDateTime(bdate);
              // r.BorrowDate = Convert.ToDateTime(sdr["BorrowDate"].ToString());
               // DateTime.ParseExact(iString, "yyyy-MM-dd
               //r.BorrowDate = DateTime.ParseExact(bdate,"MM-dd-yyyy",null);
                
                //r.DueDate = Convert.ToDateTime(sdr["DueDate"].ToSt    ring());
              


                listOfRecords.Add(r);
            }

            dcc.CloseConnection();

            return listOfRecords;
        }
             
        
        
        
        public SqlCommand myCommand { get; set; } 
     
    }
}