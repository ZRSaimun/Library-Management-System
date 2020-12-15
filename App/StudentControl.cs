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
    public partial class StudentControl : UserControl
    {
        StudentRepo stu;
        string stID = null;
        Student student;
        
        public StudentControl()
        {
            InitializeComponent();


            this.stu = new StudentRepo();
            List<Student> listofStudent = stu.GetAllStudent();
            studentTable.DataSource = listofStudent;
        }

        private void Student_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Name.Equals("register_Btn"))
            {
                bool Isopen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "Student_Reg")
                    {
                        Isopen = true;
                        f.BringToFront();
                        break;
                    }

                }
                if (Isopen == false)
                {
                    Student_Reg sr = new Student_Reg();
                    sr.Show();
                }
            }
        }

        private void StudentCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            //bookID = BookTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            //MessageBox.Show(bookID);

            student= new Student();
            //book.Image = Convert.ToByte[] (BookTable.Rows[e.RowIndex].Cells[0].Value.ToString()); 
            //book.Image = new MemoryStream((byte[])BookTable.Rows[e.RowIndex].Cells[0].Value);

            student.Id = studentTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            stID = student.Id;
            student.Firstname = studentTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            student.Surname = studentTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            student.Lastname = studentTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            student.Type = studentTable.Rows[e.RowIndex].Cells[5].Value.ToString();
            student.Contact = (studentTable.Rows[e.RowIndex].Cells[6].Value.ToString()).Substring(4);
            student.Dept = studentTable.Rows[e.RowIndex].Cells[7].Value.ToString();
            student.Year = studentTable.Rows[e.RowIndex].Cells[8].Value.ToString();
            student.Due = Convert.ToInt32(studentTable.Rows[e.RowIndex].Cells[9].Value.ToString());
            student.Borrowed = Convert.ToInt32(studentTable.Rows[e.RowIndex].Cells[10].Value.ToString());

           // MessageBox.Show("you are selected");
            register_Btn.Visible = false;
            deleteBTN.Visible = true;
            updateBTN.Visible = true;
            cancelBTN.Visible = true;

        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (stu == null)
            {
                MessageBox.Show("select Student ");
            }
            else
            {

                bool Isopen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "Student_Reg")
                    {
                        Isopen = true;
                        f.BringToFront();
                        break;
                    }

                }
                if (Isopen == false)
                {
                    Student_Reg stur = new Student_Reg(student, "update");
                    stur.Show();
                }

            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (stu.RemoveStudent(stID))
            {
                MessageBox.Show(stID);
                MessageBox.Show("Student Deleted");

            }
            else
            {
                MessageBox.Show("Can Not Delete");
            }
        }

        private void searchStudentTBTextChanged(object sender, EventArgs e)
        {
            List<Student> listOfStudent = stu.GetAllStudent();
            String keyword = this.searchStudentTB.Text;
            List<Student> searchedStudent = listOfStudent.FindAll(x => (x.Id.ToLower()).Contains(keyword.ToLower()) || (x.Firstname.ToLower()).Contains(keyword.ToLower()) || (x.Dept.ToLower()).Contains(keyword.ToLower()) || (x.Lastname.ToLower()).Contains(keyword.ToLower()) || (x.Contact.ToLower()).Contains(keyword.ToLower()));
            studentTable.DataSource = searchedStudent;
        }

        private void searchStudentTBEnter(object sender, EventArgs e)
        {
            if (searchStudentTB.Text == "Search Student")
            {
                searchStudentTB.Text = "";
                searchStudentTB.ForeColor = Color.Black;

            }
        }

        private void searchStudentTBLeave(object sender, EventArgs e)
        {
            if (searchStudentTB.Text == "")
            {
                searchStudentTB.Text = "Search Student";
                searchStudentTB.ForeColor = Color.Silver;

            }
        }

  

        
    }
}
