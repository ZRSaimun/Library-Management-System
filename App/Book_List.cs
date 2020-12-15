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
using System.IO;


namespace App
{
    public partial class Book_List : Form
    {
        BookRepo bookRepo=new BookRepo();
        String imageLocation = "";
        Book book;
        string status = null;
        public Book_List()
        {
            InitializeComponent();
            updateBTN.Visible = false;
        }
        public Book_List(Book book,string status)
        {
            InitializeComponent();
            this.book = book;
            this.status = status;
            updateBTN.Visible = true;
            addBook.Visible = false;
            bookIdTB.ReadOnly = true;
            bookIdTB.Enabled = false;

            bookIdTB.Text = book.BookId;
            copiesTB.Text = Convert.ToString(book.Copies); 
            bookTitleTB.Text = book.Title;
            authorTB.Text = book.Classification;
            RadioButton[] radioButton = new RadioButton[15] { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6, radioButton7, radioButton8, radioButton9, radioButton10, radioButton11, radioButton12, radioButton13, radioButton14, radioButton15 };
            for (int i = 0; i < radioButton.Length; i++)
            {
                if (radioButton[i].Text.Equals(book.Author))
                {
                    radioButton[i].Checked = true;
                    
                }
                else
                {
                    //MessageBox.Show("classification is empty");

                }
            }
            
            publisherTB.Text = book.Publisher;
            subTitleTB.Text = book.Subtitle;
            copyTB.Text = book.Copyright;
            placeTB.Text = book.Place;
            publishedDateTB.Text = book.PublishDate;

//update upper LABEL

            bookIdLB.Text = book.BookId;
            copiesLB.Text = Convert.ToString(book.Copies);
            titleLB.Text = book.Title;
            authorLB.Text = book.Classification;
            RadioButton[] radioButtonall = new RadioButton[15] { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6, radioButton7, radioButton8, radioButton9, radioButton10, radioButton11, radioButton12, radioButton13, radioButton14, radioButton15 };
            for (int i = 0; i < radioButtonall.Length; i++)
            {

                if (radioButtonall[i].Text.Equals(book.Classification))
                {
                    radioButtonall[i].Checked = true;
                   radioButton[i].Text = book.Author;
                  

                }
                else
                {
                    //MessageBox.Show("classification is empty");

                }
            }

            publisherLB.Text = book.Publisher;
            subTitleLB.Text = book.Subtitle;
            copyRightLB.Text = book.Copyright;
            placeLB.Text = book.Place;
            publishdtLB.Text = book.PublishDate;
        }

        // sqlcomand 
        private void image_Btn_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    book_Image.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);
            
            Book book = new Book();
            book.Image =images;
            book.BookId = bookIdTB.Text;
            book.Title = bookTitleTB.Text;
            book.Publisher = publisherTB.Text;
            book.Subtitle = subTitleTB.Text;
            book.Copyright = copyTB.Text;
            book.Place = placeTB.Text;
            book.Author = authorTB.Text;
            book.Copies = Convert.ToInt32(copiesTB.Text);
            book.PublishDate = publishedDateTB.Text;
            RadioButton[] radioButton = new RadioButton[15] { radioButton1, radioButton2,radioButton3,radioButton4,radioButton5,radioButton6,radioButton7,radioButton8,radioButton9,radioButton10,radioButton11,radioButton12,radioButton13,radioButton14,radioButton15 };
            for (int i = 0; i < radioButton.Length; i++)
            {
                if (radioButton[i].Checked==true)
                {
                    book.Classification = radioButton[i].Text;
                }
                else
                {
                    //MessageBox.Show("classification is empty");
                    
                }
            }

            try
            {
                int i = Convert.ToInt32(copiesTB.Text);
                
                    if (bookRepo.InsertBook(book,images))
                    {
                        MessageBox.Show("Added");
                       
                    }
                
                else
                {
                    MessageBox.Show("Can Not Add");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data" + exp.StackTrace);

            }
            



        }

        private void key_Press(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Name.Equals("bookTitleTB"))
            {
                char a = Convert.ToChar(Keys.Back);
                if ((e.KeyChar == a))
                {
                    titleLB.Text = titleLB.Text.Substring(0, titleLB.Text.Length - 1);
                }
                else
                {
                    titleLB.Text = titleLB.Text + e.KeyChar;
                }
            }

            if (tb.Name.Equals("publisherTB"))
            {
                char a = Convert.ToChar(Keys.Back);
                if ((e.KeyChar == a))
                {
                    publisherLB.Text = publisherLB.Text.Substring(0, publisherLB.Text.Length - 1);
                }
                else
                {
                    publisherLB.Text = publisherLB.Text + e.KeyChar;
                }
            }

            if (tb.Name.Equals("authorTB"))
            {
                char a = Convert.ToChar(Keys.Back);
                if ((e.KeyChar == a))
                {
                    authorLB.Text = authorLB.Text.Substring(0, authorLB.Text.Length - 1);
                }
                else
                {
                    authorLB.Text = authorLB.Text + e.KeyChar;
                }
            }

            if (tb.Name.Equals("placeTB"))
            {
                char a = Convert.ToChar(Keys.Back);
                if ((e.KeyChar == a))
                {
                    placeLB.Text = placeLB.Text.Substring(0, placeLB.Text.Length - 1);
                }
                else
                {
                    placeLB.Text = placeLB.Text + e.KeyChar;
                }
            }

            if (tb.Name.Equals("copyTB"))
            {
                char a = Convert.ToChar(Keys.Back);
                if ((e.KeyChar == a))
                {
                    copyRightLB.Text = copyRightLB.Text.Substring(0, copyRightLB.Text.Length - 1);
                }
                else
                {
                    copyRightLB.Text = copyRightLB.Text + e.KeyChar;
                }
            }

            if (tb.Name.Equals("publishedDateTB"))
            {
                char a = Convert.ToChar(Keys.Back);
                if ((e.KeyChar == a))
                {
                    publishdtLB.Text = publishdtLB.Text.Substring(0, publishdtLB.Text.Length - 1);
                }
                else
                {
                    publishdtLB.Text = publishdtLB.Text + e.KeyChar;
                }
            }

            if (tb.Name.Equals("copiesTB"))
            {
                char a = Convert.ToChar(Keys.Back);
                if ((e.KeyChar == a))
                {
                    copiesLB.Text = copiesLB.Text.Substring(0, copiesLB.Text.Length - 1);
                }
                else
                {
                    copiesLB.Text = copiesLB.Text + e.KeyChar;
                }
            }

            if (tb.Name.Equals("bookIdTB"))
            {
                char a = Convert.ToChar(Keys.Back);
                if ((e.KeyChar == a))
                {
                    bookIdLB.Text = bookIdLB.Text.Substring(0, bookIdLB.Text.Length - 1);
                }
                else
                {
                    bookIdLB.Text = bookIdLB.Text + e.KeyChar;
                }
            }

            if (tb.Name.Equals("RB_Button"))
            {
                char a = Convert.ToChar(Keys.Back);
                if ((e.KeyChar == a))
                {
                    classifiLB.Text = classifiLB.Text.Substring(0, classifiLB.Text.Length - 1);
                }
                else
                {
                    classifiLB.Text = classifiLB.Text + e.KeyChar;
                }
            }

            if (tb.Name.Equals("subTitleTB"))
            {
                char a = Convert.ToChar(Keys.Back);
                if ((e.KeyChar == a))
                {
                    subTitleLB.Text = subTitleLB.Text.Substring(0, subTitleLB.Text.Length - 1);
                }
                else
                {
                    subTitleLB.Text = subTitleLB.Text + e.KeyChar;
                }
            }
        }


        private void UpdateBTN_Click(object sender, EventArgs e)
        {

            Book book1 = new Book();

            book1.BookId = bookIdTB.Text;
            book1.Title = bookTitleTB.Text;
            book1.Publisher = publisherTB.Text;
            book1.Subtitle = subTitleTB.Text;
            book1.Copyright = copyTB.Text;
            book1.Place = placeTB.Text;
            book1.Author = authorTB.Text;
            book1.Copies = Convert.ToInt32(copiesTB.Text);
            book1.PublishDate = publishedDateTB.Text;
            RadioButton[] radioButton = new RadioButton[15] { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6, radioButton7, radioButton8, radioButton9, radioButton10, radioButton11, radioButton12, radioButton13, radioButton14, radioButton15 };
            for (int i = 0; i < radioButton.Length; i++)
            {
                if (radioButton[i].Checked == true)
                {
                    book1.Classification = radioButton[i].Text;
                }
                else
                {
                    //MessageBox.Show("classification is empty");

                }
            }
           // MessageBox.Show(Convert.ToString (copiesLB));
            try
            {
                int i = Convert.ToInt32(copiesTB.Text);

                if (bookRepo.UpdateBook(book1))
                {
                    MessageBox.Show("Updated");

                }

                else
                {
                    MessageBox.Show("Can Not update");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data" + exp.StackTrace);

            }
        }
    }
}
