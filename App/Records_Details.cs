using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Repository;

namespace App
{
    public partial class Records_Details : Form
    {
        string bookid = null;
        string studentid = null;
        int copies = 0;
        BookRepo bk;
        Book book;
        StudentRepo srepo = new StudentRepo();
        
        //BorrowRecords brecords;
        public Records_Details(string studentid)
        {
            InitializeComponent();
            this.studentid = studentid;
            MessageBox.Show(studentid);

           Student s = srepo.GetStudent(studentid);

           id.Text = s.Id;
            student.Text = s.Firstname;
            name.Text = s.Lastname;
            dept.Text = s.Dept;
            year.Text = s.Year;
            contact.Text = s.Contact;
            borrowed.Text = Convert.ToString(s.Borrowed);
            due.Text = Convert.ToString(s.Due); 

            this.bk = new BookRepo();
           List<Book> listofRecords = bk.GetAllBooks(studentid);
           recordsDetailsDG.DataSource = listofRecords;
        }

        private void ReturnBook_Click(object sender, EventArgs e)
        {
            if (bk.UpdateRecords(bookid,studentid))
            {
                if (bk.UpdateBook(bookid, copies))
                {
                    MessageBox.Show("Book Returned");
                }
                else
                {
                    MessageBox.Show("Book copies not updated");
                }
            }
            else
            {
                MessageBox.Show("Book update not Deleted");
            }
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {


            bookid = recordsDetailsDG.Rows[e.RowIndex].Cells[1].Value.ToString();
            copies = Convert.ToInt32(recordsDetailsDG.Rows[e.RowIndex].Cells[2].Value.ToString());
            copies += 1;
        }


    }
}
