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
    public partial class Form1 : Form
    {
        LoginRepo lr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Name.Equals("Exit_btn"))
            {
                Application.Exit();
            } 
            if (button.Name.Equals("Login_btn"))
            {

                ///0=admin, 1=librarian
               
                lr = new LoginRepo();
                string id = UserNameBox.Text;
                string pass = PasswordBox.Text;

                Login l = lr.GetUser(id, pass);


                if (l != null)
                {
                    if (l.Role==0)
                    {
                        Lms lms = new Lms("admin");
                        lms.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        Lms lms = new Lms(1);
                        lms.Show();
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect");
                }   
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
