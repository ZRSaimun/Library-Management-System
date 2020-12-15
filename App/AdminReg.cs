using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Repository;
using System.Windows.Forms;

namespace App
{
    public partial class AdminReg : Form
    {
        public AdminReg()
        {
            InitializeComponent();
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

        private void Register_Click(object sender, EventArgs e)
        {

            Admin a = new Admin();

            a.Id = idTB.Text;
            a.Name = nameTB.Text;
            a.Contact = contactTB1.Text + contactTB2.Text;
            a.Password = passwordTB.Text;

            AdminRepo aRepo = new AdminRepo();



            MessageBox.Show(""+a.Id+a.Name+a.Contact+a.Password);
            if (aRepo.InsertAdmin(a) && aRepo.InsertLogin(a))
            {
                MessageBox.Show("admin inserted");
            }
            else
            {
                MessageBox.Show("admin not inserted");
            }







        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
