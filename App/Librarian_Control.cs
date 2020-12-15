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
    public partial class Librarian_Control : UserControl
    {
        LibrarianRepo r;
        string liID = null;
        Librarian librarian;
        public Librarian_Control()
        {
            InitializeComponent();
            this.r = new LibrarianRepo();
            List<Librarian> listofLibrarian = r.GetAllLibrarian();
            librarianDG.DataSource = listofLibrarian;
        }

        private void admin_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Name.Equals("register_Btn"))
            {
                bool Isopen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text=="admin_Reg")
                    {
                        Isopen = true;
                        f.BringToFront();
                        break;
                    }
                    
                }
                if (Isopen==false)
                {
                    Librarian_Reg adr = new Librarian_Reg();
                    adr.Show();
                }
            }
            if (button.Name.Equals("changePass_Btn"))
            {
                bool Isopen = false;
                foreach (Form C in Application.OpenForms)
                {
                    if (C.Text=="Change_Password")
                    {
                        Isopen = true;
                        C.BringToFront();
                        break;
                    }
                    
                }
                if (Isopen==false)
                {
                    Change_Password cp = new Change_Password();
                    cp.Show();
                }
            }
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            librarian = new Librarian();
            //  librarian.Image = Convert.ToByte[] (librarianDG.Rows[e.RowIndex].Cells[0].Value.ToString()); 
            // librarian.Image = new MemoryStream((byte[])librarianDG.Rows[e.RowIndex].Cells[0].Value);

            librarian.Id = librarianDG.Rows[e.RowIndex].Cells[1].Value.ToString();
            liID = librarian.Id;
            librarian.LastName = librarianDG.Rows[e.RowIndex].Cells[2].Value.ToString();
            librarian.FirstName = librarianDG.Rows[e.RowIndex].Cells[3].Value.ToString();
            librarian.Surname = librarianDG.Rows[e.RowIndex].Cells[4].Value.ToString();
            librarian.UserName = librarianDG.Rows[e.RowIndex].Cells[5].Value.ToString();
            librarian.Contact = (librarianDG.Rows[e.RowIndex].Cells[6].Value.ToString()).Substring(4);
            librarian.Email = librarianDG.Rows[e.RowIndex].Cells[7].Value.ToString();
            librarian.Address = librarianDG.Rows[e.RowIndex].Cells[8].Value.ToString();
            librarian.Salary =  Convert.ToDouble(librarianDG.Rows[e.RowIndex].Cells[9].Value.ToString());
           // librarian.Password = librarianDG.Rows[e.RowIndex].Cells[10].Value.ToString();
           // librarian.Confirm = librarianDG.Rows[e.RowIndex].Cells[11].Value.ToString();

           // MessageBox.Show("you are selected");
            register_Btn.Visible = false;
            deleteBTN.Visible = true;
            updateBTN.Visible = true;
            cancelBTN.Visible = true;
            
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("select Librarian ");
            }
            else
            {

                bool Isopen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "Librarian_Reg")
                    {
                        Isopen = true;
                        f.BringToFront();
                        break;
                    }

                }
                if (Isopen == false)
                {
                    Librarian_Reg lr = new Librarian_Reg(librarian, "update");
                    lr.Show();
                }

            }

        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (r.RemoveLibrarian(liID))
            {
                MessageBox.Show(liID);
                MessageBox.Show("Librarian Deleted");

            }
            else
            {
                MessageBox.Show("Can Not Delete");
            }
        }

        private void searchLibrarianTBTextChanged(object sender, EventArgs e)
        {
            List<Librarian> listOfLibrarian = r.GetAllLibrarian();
            String keyword = this.searchLibrarianTB.Text;
            List<Librarian> searchedLibrarian = listOfLibrarian.FindAll(x => (x.Id.ToLower()).Contains(keyword.ToLower()) || (x.UserName.ToLower()).Contains(keyword.ToLower()) || (x.FirstName.ToLower()).Contains(keyword.ToLower()) || (x.Contact.ToLower()).Contains(keyword.ToLower()) || (x.Address.ToLower()).Contains(keyword.ToLower()));
            librarianDG.DataSource = searchedLibrarian;
        }

        private void searchLibrarianTBEnter(object sender, EventArgs e)
        {
            if (searchLibrarianTB.Text == "Search Librarian")
            {
                searchLibrarianTB.Text = "";
                searchLibrarianTB.ForeColor = Color.Black;

            }
        }

        private void searchLibrarianTBLeave(object sender, EventArgs e)
        {
            if (searchLibrarianTB.Text == "")
            {
                searchLibrarianTB.Text = "Search Librarian";
                searchLibrarianTB.ForeColor = Color.Silver;

            }
        }       
    }
}
