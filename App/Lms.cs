using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Lms : Form
    {
        
        public Lms(string admin)
        {
            InitializeComponent();
            adminPanel1.Hide();
            sidepanel.Height = admin_Panel_BTN.Height;
            sidepanel.Top = admin_Panel_BTN.Top;
            admin_Panel_BTN.BringToFront();

            Librarian_Control1.Hide();
            book_Control1.Hide();
            borrowcontrol1.Hide();
            records1.Hide();
            studentControl1.Hide();
            customize();
        }
        public Lms(int Librarian)
        {
            InitializeComponent();
            admin_Panel_BTN.Visible = false;
            librarian_Btn.Visible = false;
           panelAdminSubMenu.Visible = false;
           customize();
        }

        private void customize()
        {
            panelAdminSubMenu.Visible = false;
        }
        private void hidesubmenu()
        {
            if (panelAdminSubMenu.Visible == true)
            {
                panelAdminSubMenu.Visible = false;
            } 
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible==false)
            {
                hidesubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void dashboardBTN_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void adminListBTN_Click(object sender, EventArgs e)
        {
            adminPanel1.Show();
            hidesubmenu();
            welcomeLB.Hide();
        }

        private void changepassBTN_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        } 
        private void borrow_Btn_Click(object sender, EventArgs e)
        {
            
            borrowcontrol1.Show();
            book_Control1.Hide();
            records1.Hide();
            Librarian_Control1.Hide();
            studentControl1.Hide();
            adminPanel1.Hide();
            sidepanel.Height = borrow_Btn.Height;
            sidepanel.Top = borrow_Btn.Top;
            borrowcontrol1.BringToFront();
            welcomeLB.Visible = false;
          
        }

        private void book_Btn_Click(object sender, EventArgs e)
        {
            Book_Control book_Co = new Book_Control();
            
            book_Control1.Show();
            borrowcontrol1.Hide();
            records1.Hide();
            Librarian_Control1.Hide();
            studentControl1.Hide();
            adminPanel1.Hide();
            sidepanel.Height = book_Btn.Height;
            sidepanel.Top = book_Btn.Top;
            book_Control1.BringToFront();
            welcomeLB.Hide();
        }
        private void records_Btn_Click(object sender, EventArgs e)
        {
            records1.Show();
            borrowcontrol1.Hide();
            book_Control1.Hide();
            Librarian_Control1.Hide();
            studentControl1.Hide();
            adminPanel1.Hide();
            sidepanel.Height = records_Btn.Height;
            sidepanel.Top = records_Btn.Top;
            records1.BringToFront();
            welcomeLB.Hide();
        }

        private void librarian_Btn_Click(object sender, EventArgs e)
        {
            Librarian_Control1.Show();
            borrowcontrol1.Hide();
            book_Control1.Hide();
            records1.Hide();
            studentControl1.Hide();
            adminPanel1.Hide();
            sidepanel.Height = librarian_Btn.Height;
            sidepanel.Top = librarian_Btn.Top;
            librarian_Btn.BringToFront();
            welcomeLB.Hide();
            
        }
        private void student_Btn_Click(object sender, EventArgs e)
        {
            studentControl1.Show();
            Librarian_Control1.Hide();
            borrowcontrol1.Hide();
            book_Control1.Hide();
            records1.Hide();
            adminPanel1.Hide();
            sidepanel.Height = student_Btn.Height;
            sidepanel.Top = student_Btn.Top;
            student_Btn.BringToFront();
            welcomeLB.Hide();
        }

        private void admin_Panel_BTN_Click(object sender, EventArgs e)
        {
            adminPanel1.Hide();
            sidepanel.Height = admin_Panel_BTN.Height;
            sidepanel.Top = admin_Panel_BTN.Top;
            studentControl1.Hide();
            Librarian_Control1.Hide();
            borrowcontrol1.Hide();
            book_Control1.Hide();
            records1.Hide();
            admin_Panel_BTN.BringToFront();
            showSubMenu(panelAdminSubMenu);
            welcomeLB.Show();
        }
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Moved(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "Important notice", "Something important has come up.Click this to know more.", ToolTipIcon.Info);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
