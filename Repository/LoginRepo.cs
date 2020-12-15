using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Data;

using System.ComponentModel;

using System.Drawing;
using System.IO;

namespace Repository
{
  public  class LoginRepo
    {
      DatabaseConnectionClass dcc;


      public LoginRepo()
      {
          dcc = new DatabaseConnectionClass();

      }
      public Login GetUser(string id, string password)
      {
          Login l = null;
          string query = "SELECT * from Login WHERE Id = '" + id + "' AND Password = '" + password + "'";
          dcc.ConnectWithDB();
          SqlDataReader sdr = dcc.GetData(query);

          while (sdr.Read())
          {
              l = new Login();
              l.Id = sdr["Id"].ToString();
              l.Password = sdr["Password"].ToString();
              l.Role = Convert.ToInt32(sdr["Role"]);
             
          }

          dcc.CloseConnection();

          return l;

      }

    }
}
