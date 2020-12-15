using System.Threading.Tasks;
using Interface;
using Entity;
using Repository;
using System.ComponentModel;
using System.Threading.Tasks;
using Interface;
using Entity;
using Repository;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System;
using System.Collections.Generic;
namespace Repository
{
   public class AdminRepo
   {
       DatabaseConnectionClass dcc;


       public AdminRepo()
       {
           dcc = new DatabaseConnectionClass();
       }

        public bool InsertAdmin(Admin admin)
        {
            
            string query = "INSERT into Admin(id,Name,Contact,Pass) VALUES( '" + admin.Id + "','" + admin.Name + "','" + admin.Contact + "','" + admin.Password + "')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }

        }

        public bool InsertLogin(Admin admin)
        {
            string role = "0";
            string query1 = "INSERT into Login(id,Password,Role) VALUES('" + admin.Id + "','" + admin.Password + "','"+role+"')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query1);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }

        }



        public List<Admin> GetAllAdmin()
        {
            List<Admin> listOfAdmin = new List<Admin>();

            string query = "SELECT * from Admin";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Admin a = new Admin();
                a.Id= sdr["id"].ToString();
                a.Name = sdr["Name"].ToString();
                a.Contact = sdr["Contact"].ToString();
               // a.Password = sdr["Pass"].ToString();
                

                listOfAdmin.Add(a);
            }

            dcc.CloseConnection();

            return listOfAdmin;


        }



        

        }
       /*
        public bool RemoveAdmin(string AdminID)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateAdmin(Admin admin)
        {
            throw new System.NotImplementedException();
        }

        public Librarian GetAdmin(string adminID)
        {
            throw new System.NotImplementedException();
        }

        */
    }

