using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Repository;
using System.Data.SqlClient;

namespace App
{
    public partial class borrowcontrol : UserControl
    {
        string firstName = null;
        BookRepo bookRepo;
        Book book;
        StudentRepo studentRepo;
        Records r;
        DataTable dt = new DataTable();
        int indexRow;
        int borrowCount = 0;
        
        public borrowcontrol()
        {
            InitializeComponent();
            AutoComplete();
           // borrowDateLB.Text = borrowedDate.Value.ToString();

         //   string a = Convert.ToString(borrowedDate.Value.Date);
           // string[] s = a.Split(' '); 
          //  MessageBox.Show(s[0]);
           // MessageBox.Show(startDate);

            this.bookRepo = new BookRepo();
            List<Book> listofBook = bookRepo.GetAllBooks();
            booksDG.DataSource = listofBook;
            
            dt.Columns.Add("BookID", typeof(string));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Classification", typeof(string));
            

        }

        private void AutoComplete()
        {
            studentSearchTB.AutoCompleteMode = AutoCompleteMode.Suggest;
            studentSearchTB.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            DatabaseConnectionClass dcc;
            dcc = new DatabaseConnectionClass();
            string query = "SELECT Id from Student";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {


                firstName = sdr["Id"].ToString();
                coll.Add(firstName);

            }

            dcc.CloseConnection();
            studentSearchTB.AutoCompleteCustomSource = coll;

        }
        

        private void studentSearch_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void StudentSearch_Click(object sender, EventArgs e)
        {
            StudentRepo studentRepo = new StudentRepo();
            string id = studentSearchTB.Text;
            //MessageBox.Show(id);
           // Student s = new Student();
           // var obj = studentRepo.GetAllStudent();
            Student s = studentRepo.GetStudent(id);
            if (s== null)
            {
                MessageBox.Show("invalid"); 
            }
            else
            {
            student_Name.Text = s.Firstname;
            student_Department.Text = s.Dept;
            student_Due.Text = Convert.ToString(s.Due); 
            student_Borrowed.Text = Convert.ToString(s.Borrowed); 
            }
            
          




        }



        private void AddBook_Click(object sender, EventArgs e)
        {
            DataGridViewRow dRow = booksDG.Rows[indexRow];
            /*if (booksDG.Rows[indexRow].Cells[1].Value.ToString().Equals(borrowListDG.Rows[0].Cells[0].Value.ToString() ))
            {
                MessageBox.Show("already Inserted");
            }
            else
            {
                MessageBox.Show("not Inserted");
            }*/

            borrowCount= borrowCount+1;
            TotalCopiesLB.Text = Convert.ToString(borrowCount);
            dRow.Cells[2].Value = Convert.ToString((Convert.ToInt32(dRow.Cells[2].Value.ToString()) - 1));

            dt.Rows.Add(book.BookId, book.Title,book.Classification);
            borrowListDG.DataSource = dt;

            dueDate.Value = DateTime.Today.AddDays(+7);
            //dueDateLB.Text = dueDate.Value.ToString();
            //dueDateLB.Text = Convert.ToString(Convert.ToInt32(borrowDateLB.Text) + 7); 
        }


        private void OnTableCell_Click(object sender, DataGridViewCellEventArgs e)
        {

            indexRow = e.RowIndex;
            book = new Book();
            book.BookId = booksDG.Rows[e.RowIndex].Cells[1].Value.ToString();
            book.Title = booksDG.Rows[e.RowIndex].Cells[3].Value.ToString();
            book.Classification = booksDG.Rows[e.RowIndex].Cells[4].Value.ToString();
            book.Copies = Convert.ToInt32(booksDG.Rows[e.RowIndex].Cells[2].Value.ToString());



            MessageBox.Show(book.BookId + book.Title + "" + Convert.ToString(book.Copies));
            
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
           // DataGridViewRow dRow = borrowListDG.Rows[0];

            if (borrowListDG.Rows.Count == 0)
            {
                MessageBox.Show("Select a book");
            }
            else
            {

                studentRepo = new StudentRepo();
                book = new Book();

                //book.Image = Convert.ToByte[] (BookTable.Rows[e.RowIndex].Cells[0].Value.ToString()); 
                //book.Image = new MemoryStream((byte[])BookTable.Rows[e.RowIndex].Cells[0].Value);

                book.BookId = booksDG.Rows[indexRow].Cells[1].Value.ToString();
                book.Copies = Convert.ToInt32(booksDG.Rows[indexRow].Cells[2].Value.ToString());
                book.Title = booksDG.Rows[indexRow].Cells[3].Value.ToString();
                book.Author = booksDG.Rows[indexRow].Cells[4].Value.ToString();
                book.Classification = booksDG.Rows[indexRow].Cells[5].Value.ToString();
                book.Publisher = booksDG.Rows[indexRow].Cells[6].Value.ToString();
                book.Subtitle = booksDG.Rows[indexRow].Cells[7].Value.ToString();
                book.Copyright = booksDG.Rows[indexRow].Cells[8].Value.ToString();
                book.Place = booksDG.Rows[indexRow].Cells[9].Value.ToString();
                book.PublishDate = booksDG.Rows[indexRow].Cells[10].Value.ToString();




                if (Convert.ToInt32(student_Borrowed.Text)==3 )
                {
                    MessageBox.Show("Already 3 Books has been Taken");
                }
                else
                {
                    BorrowRecords b = new BorrowRecords();
                    b.BookID1 = null;
                    b.BookID2 = null;
                    b.BookID3 = null;
                    // b.BookID1 = borrowListDG.Rows[0].Cells[0].Value.ToString();
                    //b.BookID2 = borrowListDG.Rows[1].Cells[0].Value.ToString();
                    // b.BookID3 = borrowListDG.Rows[2].Cells[0].Value.ToString();
                    b.StudentID = studentSearchTB.Text;
                    b.BorrowDate = borrowedDate.Text;
                    b.DueDate = dueDate.Text;


                    if (borrowListDG.Rows[0] == null)
                    {
                        b.BookID1 = null;
                    }
                    else
                    {
                        b.BookID1 = borrowListDG.Rows[0].Cells[0].Value.ToString();
                    }
                    if (borrowListDG.Rows[1].Displayed == false)
                    {
                        b.BookID2 = null;
                    }
                    else
                    {
                        MessageBox.Show("2 not null");
                        b.BookID2 = borrowListDG.Rows[1].Cells[0].Value.ToString();
                    }
                    if (borrowListDG.Rows[2].Displayed == false)
                    {
                        b.BookID3 = null;
                    }
                    else
                    {
                        b.BookID3 = borrowListDG.Rows[2].Cells[0].Value.ToString();
                    }



                    /*string a = Convert.ToString(borrowedDate.Value.Date);
                    string[] s = a.Split(' ');
                    MessageBox.Show(s[0]);
                
                    MessageBox.Show(b.BorrowDate+"");*/


                    bool borrowResult = bookRepo.UpdateBook(book.BookId, book.Copies);
                    bool borrowResult1 = bookRepo.UpdateRecords(b);
                    bool borrowResult2 = studentRepo.UpdateStudentBorrow(studentSearchTB.Text, Convert.ToInt32(TotalCopiesLB.Text));



                    if (borrowResult && borrowResult1 && borrowResult2)
                    {
                        MessageBox.Show("Borrowed Succesfully");
                    }
                    else
                    {
                        MessageBox.Show("Cannot Borrow");
                    }
                }

               
            }    
        }

        private void BookSearchTextChanged(object sender, EventArgs e)
        {
            //bookSearchTB
            List<Book> listOfBook = bookRepo.GetAllBooks();
            String keyword = this.bookSearchTB.Text;
            List<Book> searchedBook = listOfBook.FindAll(x => (x.BookId.ToLower()).Contains(keyword.ToLower()) || (x.Title.ToLower()).Contains(keyword.ToLower()) || (x.PublishDate.ToLower()).Contains(keyword.ToLower()) || (x.Place.ToLower()).Contains(keyword.ToLower()));
            booksDG.DataSource = searchedBook;
                  
        }

        private void bookSearchTBEnter(object sender, EventArgs e)
        {
            if (bookSearchTB.Text=="Search Book Here")
            {
                bookSearchTB.Text ="";
                bookSearchTB.ForeColor = Color.Black;
                
            }
        }

        private void bookSearchTBLeave(object sender, EventArgs e)
        {
            if (bookSearchTB.Text == "")
            {
                bookSearchTB.Text = "Search Book Here";
                bookSearchTB.ForeColor = Color.Silver;

            }
        }

        private void studentSearchTBEnter(object sender, EventArgs e)
        {
            if (studentSearchTB.Text == "Search Student ID")
            {
                studentSearchTB.Text = "";
                studentSearchTB.ForeColor = Color.Black;

            }
        }

        private void studentSearchTBLeave(object sender, EventArgs e)
        {
            if (studentSearchTB.Text == "")
            {
                studentSearchTB.Text = "Search Student ID";
                studentSearchTB.ForeColor = Color.Silver;

            }
        }

    }
}
