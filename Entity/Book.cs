using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Book
    {
        private byte[] image;

        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }

        private string bookId;

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        private int copies;

        public int Copies
        {
            get { return copies; }
            set { copies = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string classification;

        public string Classification
        {
            get { return classification; }
            set { classification = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string publisher;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        private string subtitle;

        public string Subtitle
        {
            get { return subtitle; }
            set { subtitle = value; }
        }
        
        private string copyright;

        public string Copyright
        {
            get { return copyright; }
            set { copyright = value; }
        }

        private string place;

        public string Place
        {
            get { return place; }
            set { place = value; }
        }

        private string publishDate;

        public string PublishDate
        {
            get { return publishDate; }
            set { publishDate = value; }
        }

 
    }
}
