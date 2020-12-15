using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Student_Reg : Form
    {
        
        StudentRepo studentRepo=new StudentRepo();
        String imageLocation = "";
        Student stu;
        private StudentRepo stu1;
        private string p;
        public Student_Reg()
        {
            InitializeComponent();
        }

        public Student_Reg(Student stu, string p)
        {
            InitializeComponent();
            //MessageBox.Show(stu.Id);
            // TODO: Complete member initialization
            this.stu = stu;
            this.p = p;
            idTB.Text = stu.Id;
            typeTB.Text = stu.Type;
            firstnameTB.Text = stu.Firstname;
            surnameTB.Text = stu.Surname;
            lastnameTB.Text = stu.Lastname;
            contactTB2.Text = stu.Contact;
            deptTB.Text = stu.Dept;
            yearTB.Text = stu.Year;
            idTB.Enabled = false;
            updateBTN.Visible = true;
            studentRegisterBTN.Visible = false;
        }

        private void upload_Btn_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void studentRegisterBTN_Click_1(object sender, EventArgs e)
        {
            byte[] images = null;
           // FileStream Stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
           // BinaryReader brs = new BinaryReader(Stream);
           // images = brs.ReadBytes((int)Stream.Length);

            stu = new Student();
            stu.Image = images;
            stu.Type = typeTB.Text;
            stu.Id = idTB.Text;
            stu.Firstname = firstnameTB.Text;
            stu.Surname = surnameTB.Text;
            stu.Lastname = lastnameTB.Text;
            stu.Contact = contactTB1.Text + contactTB2.Text;
            stu.Dept = deptTB.Text;
            stu.Year = yearTB.Text;
            
           // MessageBox.Show(deptTB.Text);
            try
            {
                 //int i = Convert.ToInt32(idTB.Text);

                if (studentRepo.InsertStudent(stu, images))
                {

                    if (studentRepo.InsertRecords(stu))
                    {
                        MessageBox.Show("Register");
                    }

                    else
                    {
                        MessageBox.Show("Cant insert into Records");
                    }
                }

                else
                {
                    MessageBox.Show("Cant insert into Student");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data" + exp.StackTrace);

            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            byte[] images = null;

            Student student1 = new Student();
            stu.Image = images;
            student1.Id = idTB.Text;
            student1.Type = typeTB.Text;
            student1.Firstname = firstnameTB.Text;
            student1.Surname = surnameTB.Text;
            student1.Lastname = lastnameTB.Text;
            student1.Contact =  contactTB2.Text;
            student1.Dept = deptTB.Text;
            student1.Year = yearTB.Text;


            stu = new Student();
            stu.Image = images;
            stu.Type = typeTB.Text;
            stu.Id = idTB.Text;
            stu.Firstname = firstnameTB.Text;
            stu.Surname = surnameTB.Text;
            stu.Lastname = lastnameTB.Text;
            stu.Contact = "+880" + contactTB2.Text;
            stu.Dept = deptTB.Text;
            stu.Year = yearTB.Text;



            try
            {
                //int i = Convert.ToInt32(idTB.Text);

               
                    if (studentRepo.UpdateStudent(stu))
                    {
                        MessageBox.Show("Update");
                    }

                    else
                    {
                        MessageBox.Show("Cant Update ");
                    }
                
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data" + exp.StackTrace);

            }
        }

        private void studentCancelBTN_Click(object sender, EventArgs e)
        {

            
            /*Librarian_Control1.Show();
            borrowcontrol1.Hide();
            book_Control1.Hide();
            records1.Hide();
            studentControl1.Hide();
            adminPanel1.Hide();
            sidepanel.Height = librarian_Btn.Height;
            sidepanel.Top = librarian_Btn.Top;
            librarian_Btn.BringToFront();
            welcomeLB.Hide();*/
        }
    }
}
