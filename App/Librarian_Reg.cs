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
    public partial class Librarian_Reg : Form
    {
        LibrarianRepo librarinrepo =new LibrarianRepo();
        Librarian librarian;
        public Librarian_Reg()
        {
            InitializeComponent();
            updateBTN.Visible = false;
            passError.Hide();
        }
        public Librarian_Reg(Librarian librarian, string p)
        {
            InitializeComponent();
//Update value pass
            this.librarian = librarian;
            librarianidLB.Text = librarian.Id;
            librarianidTB.Text = librarian.Id;
            firstnameTB.Text = librarian.FirstName;
            surnameTB.Text = librarian.Surname;
            lastnameTB.Text = librarian.LastName;
            usernameTB.Text = librarian.UserName;
            salaryTB.Text =Convert.ToString(librarian.Salary);
            contactTB2.Text = librarian.Contact;
            emailTB.Text = librarian.Email;
            passwordTB.Text = librarian.Password;
            confirmTB.Text = librarian.Confirm;
            addressTB.Text = librarian.Address;
            librarianidTB.Enabled = false;
            updateBTN.Visible = true;
            registerBTN.Visible = false;
            passError.Hide();
         
        }
        private void upload_Click(object sender, EventArgs e)
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

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Name.Equals("librarianidTB"))
            {
                char a = Convert.ToChar(Keys.Back);
                if ((e.KeyChar == a))
                {
                    librarianidLB.Text = librarianidLB.Text.Substring(0, librarianidLB.Text.Length - 1);
                }
                else
                {
                    librarianidLB.Text = librarianidLB.Text + e.KeyChar;
                }
            }
        }



        public bool NullCheck(Librarian Lr, string sal)
        {
            if (string.IsNullOrEmpty(Lr.Id) || string.IsNullOrEmpty(Lr.FirstName) || string.IsNullOrEmpty(Lr.LastName) || string.IsNullOrEmpty(Lr.LastName) ||
              string.IsNullOrEmpty(Convert.ToString(Lr.Salary)) || string.IsNullOrEmpty(Lr.Contact) ||
              string.IsNullOrEmpty(Lr.Password) || string.IsNullOrEmpty(Lr.Confirm) ||
              string.IsNullOrEmpty(Lr.Address) || string.IsNullOrEmpty(sal))
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        private void registerBTN_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            // FileStream Stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            // BinaryReader brs = new BinaryReader(Stream);
            // images = brs.ReadBytes((int)Stream.Length);
            librarian = new Librarian();
            librarian.Image = images;
            librarian.Id = librarianidTB.Text;
            librarian.LastName = lastnameTB.Text;
            librarian.FirstName = firstnameTB.Text;
            librarian.Surname = surnameTB.Text;
            librarian.UserName = usernameTB.Text;
            librarian.Contact = contactTB1.Text + contactTB2.Text;
            librarian.Email = emailTB.Text;
            librarian.Address = addressTB.Text;
            //  int s;
            // bool sa = Int32.TryParse((salaryTB.Text.ToString()), out s);
            string sal= salaryTB.Text;
            librarian.Password = passwordTB.Text;
            librarian.Confirm = confirmTB.Text;
            // MessageBox.Show(deptTB.Text);
            if (NullCheck(librarian,sal))
            {
                MessageBox.Show("Please Insert a valid info");
            }
            else
            {

                librarian.Salary = Convert.ToDouble(salaryTB.Text);
                if (librarian.Password.Equals(librarian.Confirm))
                {
                    try
                    {
                        //int i = Convert.ToInt32(idTB.Text);

                        if (librarinrepo.InsertLibrarian(librarian, images) && librarinrepo.InsertLogin(librarian))
                        {

                            MessageBox.Show("Register");
                        }

                        else
                        {
                            MessageBox.Show("Cant insert into database");
                        }
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Invalid Data" + exp.StackTrace);

                    }

                }
                else
                {
                    // MessageBox.Show("Password doesnt Match");
                    passError.Show();
                }
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            byte[] images = null;

            Librarian librarian1 = new Librarian();
            librarian1.Image = images;
            librarian1.Id = librarianidTB.Text;
            librarian1.LastName = lastnameTB.Text;
            librarian1.FirstName = firstnameTB.Text;
            librarian1.Surname = surnameTB.Text;
            librarian1.UserName = usernameTB.Text;
            librarian1.Contact = contactTB1.Text + contactTB2.Text;
            librarian1.Email = emailTB.Text;
            librarian1.Address = addressTB.Text;
            //  int s;
            // bool sa = Int32.TryParse((salaryTB.Text.ToString()), out s);
            librarian1.Salary = Convert.ToDouble(salaryTB.Text);
            librarian1.Password = passwordTB.Text;
            librarian1.Confirm = confirmTB.Text;


            librarian = new Librarian();
            librarian.Image = images;
            librarian.Id = librarianidTB.Text;
            librarian.LastName = lastnameTB.Text;
            librarian.FirstName = firstnameTB.Text;
            librarian.Surname = surnameTB.Text;
            librarian.UserName = usernameTB.Text;
            librarian.Contact =  "+880"+contactTB2.Text;
            librarian.Email = emailTB.Text;
            librarian.Address = addressTB.Text;
            //  int s;
            // bool sa = Int32.TryParse((salaryTB.Text.ToString()), out s);
            librarian.Salary = Convert.ToDouble(salaryTB.Text);
            librarian.Password = passwordTB.Text;
            librarian.Confirm = confirmTB.Text;


            if (librarian.Password.Equals(librarian.Confirm))
            {
              
             try
             {
                //int i = Convert.ToInt32(idTB.Text);


                if (librarinrepo.UpdateLibrarian(librarian))
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
            else
            {
                // MessageBox.Show("Password doesnt Match");
                passError.Show();
            }

        }
    }
}
