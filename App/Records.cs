using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;
using Entity;

namespace App
{
    public partial class Records : UserControl
    {
        string studentid =null;
        BookRepo bk;
        BorrowRecords brecords;
        public Records()
        {
            InitializeComponent();

            this.bk = new BookRepo();
            List<BorrowRecords> listofRecords = bk.GetAllRecords();
            RecordsTableDG.DataSource = listofRecords;

        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            brecords = new BorrowRecords();
            

            brecords.StudentID = RecordsTableDG.Rows[e.RowIndex].Cells[2].Value.ToString();
            studentid = brecords.StudentID;
            //stID = student.Id;
            brecords.BookID1 = RecordsTableDG.Rows[e.RowIndex].Cells[3].Value.ToString();
            brecords.BookID2 = RecordsTableDG.Rows[e.RowIndex].Cells[4].Value.ToString();
            brecords.BookID3 = RecordsTableDG.Rows[e.RowIndex].Cells[5].Value.ToString();
            brecords.BorrowDate = RecordsTableDG.Rows[e.RowIndex].Cells[0].Value.ToString();
            brecords.DueDate = RecordsTableDG.Rows[e.RowIndex].Cells[1].Value.ToString();

            // MessageBox.Show("you are selected");

            viewDetailsBTN.Visible = true;
        }

        private void viewDetailsBTN_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Name.Equals("viewDetailsBTN"))
            {
                bool Isopen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "Records_Details")
                    {
                        Isopen = true;
                        f.BringToFront();
                        break;
                    }

                }
                if (Isopen == false)
                {
                    Records_Details rd = new Records_Details(studentid);
                    rd.Show();
                }
            }
        }

        private void searchRecordsTBTextChanged(object sender, EventArgs e)
        {
            List<BorrowRecords> listofRecords = bk.GetAllRecords();
            String keyword = this.searchRecordsTB.Text;
            List<BorrowRecords> searchedStudent = listofRecords.FindAll(x => (x.StudentID.ToLower()).Contains(keyword.ToLower()) || (x.BorrowDate.ToLower()).Contains(keyword.ToLower()) || (x.DueDate.ToLower()).Contains(keyword.ToLower()) || (x.BookID3.ToLower()).Contains(keyword.ToLower()) || (x.BookID2.ToLower()).Contains(keyword.ToLower()) || (x.BookID2.ToLower()).Contains(keyword.ToLower()) );
            RecordsTableDG.DataSource = searchedStudent;
        }

        private void searchRecordsTBEnter(object sender, EventArgs e)
        {
            if (searchRecordsTB.Text == "Search Here")
            {
                searchRecordsTB.Text = "";
                searchRecordsTB.ForeColor = Color.Black;

            }
        }

        private void searchRecordsTBLeave(object sender, EventArgs e)
        {
            if (searchRecordsTB.Text == "")
            {
                searchRecordsTB.Text = "Search Here";
                searchRecordsTB.ForeColor = Color.Silver;

            }
        }


    }
}
