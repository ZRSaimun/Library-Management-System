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
    public partial class AdminPanel : UserControl
    {
        AdminRepo ad;
        public AdminPanel()
        {
            InitializeComponent();

            this.ad = new AdminRepo();
            List<Admin> listofAdmin = ad.GetAllAdmin();
            adminDGV.DataSource = listofAdmin;
        }

        private void register_Btn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Name.Equals("register_Btn"))
            {
                bool Isopen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "AdminReg")
                    {
                        Isopen = true;
                        f.BringToFront();
                        break;
                    }

                }
                if (Isopen == false)
                {
                    AdminReg ar = new AdminReg();
                    ar.Show();
                }
            }
        }

        private void adminSearchTextChanged(object sender, EventArgs e)
        {
            List<Admin> listOfAdmin = ad.GetAllAdmin();
            String keyword = this.adminSearch.Text;
            List<Admin> searchedAdmin = listOfAdmin.FindAll(x => (x.Id.ToLower()).Contains(keyword.ToLower()) || (x.Name.ToLower()).Contains(keyword.ToLower()) || (x.Contact.ToLower()).Contains(keyword.ToLower()) );
            adminDGV.DataSource = searchedAdmin; 
        }

        private void adminSearchEnter(object sender, EventArgs e)
        {
            if (adminSearch.Text == "Search Admin")
            {
                adminSearch.Text = "";
                adminSearch.ForeColor = Color.Black;

            }
        }

        private void adminSearchLeave(object sender, EventArgs e)
        {
            if (adminSearch.Text == "")
            {
                adminSearch.Text = "Search Admin";
                adminSearch.ForeColor = Color.Silver;

            }
        }
    }
}
