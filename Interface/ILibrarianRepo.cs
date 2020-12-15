using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace Interface
{
    public interface ILibrarianRepo
    {
        bool InsertLibrarian(Librarian librarian, byte[] images);
        bool RemoveLibrarian(string librarianID);
        bool UpdateLibrarian(Librarian librarian);
        Librarian GetLibrarian(string librarianID);
        List<Librarian> GetAllLibrarian();
    }
}
