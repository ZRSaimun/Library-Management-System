using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Repository;
using System.IO;

namespace App
{
    public partial class Book_Control : UserControl
    {
        BookRepo bk;
        string bookID =null;
        Book book;
        public Book_Control()
        {

            InitializeComponent();
            cancelBTN.Visible = false;
            removeBTN.Visible = false;
            updateBTN.Visible = false;

            this.bk = new BookRepo();
            List<Book> listofBook = bk.GetAllBooks();
            BookTable.DataSource = listofBook;

            

         
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Name.Equals("newbook_Btn"))
            {
                bool Isopen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "Book_List")
                    {
                        Isopen = true;
                        f.BringToFront();
                        break;
                    }

                }
                if (Isopen == false)
                {
                    Book_List bl = new Book_List();
                    bl.Show();
                }
            }
        }


        private void CancelBTN_Click(object sender, EventArgs e)
        {
            newbook_Btn.Visible = true;
            removeBTN.Visible = false;
            updateBTN.Visible = false;
            cancelBTN.Visible = false;
        }

        private void RemoveBTN_Click(object sender, EventArgs e)
        {
             if (bk.RemoveBook(bookID))
            {
                MessageBox.Show("Book Removed");
           
            }
            else
            {
                MessageBox.Show("Can Not Remove");
            }
        }

        private void OnTableCell_Click(object sender, DataGridViewCellEventArgs e)
        {

           bookID = BookTable.Rows[e.RowIndex].Cells[1].Value.ToString(); 
            //MessageBox.Show(bookID);

            book = new Book();
            //book.Image = Convert.ToByte[] (BookTable.Rows[e.RowIndex].Cells[0].Value.ToString()); 
            //book.Image = new MemoryStream((byte[])BookTable.Rows[e.RowIndex].Cells[0].Value);

            book.BookId= BookTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            book.Copies = Convert.ToInt32(BookTable.Rows[e.RowIndex].Cells[2].Value.ToString());  
            book.Title= BookTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            book.Author= BookTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            book.Classification= BookTable.Rows[e.RowIndex].Cells[5].Value.ToString();
            book.Publisher= BookTable.Rows[e.RowIndex].Cells[6].Value.ToString();
            book.Subtitle= BookTable.Rows[e.RowIndex].Cells[7].Value.ToString();
            book.Copyright= BookTable.Rows[e.RowIndex].Cells[8].Value.ToString();
            book.Place= BookTable.Rows[e.RowIndex].Cells[9].Value.ToString();
            book.PublishDate= BookTable.Rows[e.RowIndex].Cells[10].Value.ToString();

            //MessageBox.Show("Umme kulsum mou");
            newbook_Btn.Visible = false;
            refreshBTN.Visible = false;
            removeBTN.Visible = true;
            updateBTN.Visible = true;
            cancelBTN.Visible = true;



        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {

            if (book == null)
            {
                MessageBox.Show("select a book");
            }
            else
            {
                
                    bool Isopen = false;
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Text == "Book_List")
                        {
                            Isopen = true;
                            f.BringToFront();
                            break;
                        }

                    }
                    if (Isopen == false)
                    {
                        Book_List bl = new Book_List(book,"update");
                        bl.Show();
                    }
                
            }
 
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {

            BindingSource bSource = new BindingSource();
            bSource.DataSource = BookTable;


            BookTable.DataSource = bSource;
            
            BookTable.Update();
            BookTable.Refresh();
        }

        private void searchBookTBTextChanged(object sender, EventArgs e)
        {
            List<Book> listOfBook = bk.GetAllBooks();
            String keyword = this.searchBookTB.Text;
            List<Book> searchedBook = listOfBook.FindAll(x => (x.BookId.ToLower()).Contains(keyword.ToLower()) || (x.Title.ToLower()).Contains(keyword.ToLower()) || (x.PublishDate.ToLower()).Contains(keyword.ToLower()) || (x.Place.ToLower()).Contains(keyword.ToLower()) || (x.Author.ToLower()).Contains(keyword.ToLower()));
            BookTable.DataSource = searchedBook;
        }

        private void searchBookTbEnter(object sender, EventArgs e)
        {
            if (searchBookTB.Text == "Search Book")
            {
                searchBookTB.Text = "";
                searchBookTB.ForeColor = Color.Black;

            }
        }

        private void searchBookTBLeave(object sender, EventArgs e)
        {
            if (searchBookTB.Text == "")
            {
                searchBookTB.Text = "Search Book";
                searchBookTB.ForeColor = Color.Silver;

            }
        }
    }
}
