using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IBookRepo
    {
        bool InsertBook(Book book,byte[] image);
        bool RemoveBook(string bookID);
        bool UpdateBook(Book book);
       // Employee GetEmployee(string empId);
        List<Book> GetAllBooks();
    }
}
