using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Interface
{
   public interface IAdminRepo
    {
        /*bool InsertAdmin(Admin admin, byte[] images);
        bool RemoveAdmin(string AdminID);
        bool UpdateAdmin(Admin admin);
        Librarian GetAdmin(string adminID);
        */
       List<Admin> GetAllAdmin();
    
    }
}
