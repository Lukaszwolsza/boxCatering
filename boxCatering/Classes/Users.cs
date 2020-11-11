using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxCatering.Classes
{
    public abstract class Users
    {
        public int userID { get; protected set; }
        public string userLogin { get; protected set; }
        public string userPassword { get; protected set; }
        public string userEmail { get; protected set; }
        public bool isAdmin { get; protected set; }



        public virtual bool setAdmin(bool isadmin)
        {
            return this.isAdmin = false;
        }

    }

    public class Administrator : Users
    {
        public override bool setAdmin(bool isadmin)
        {
            isadmin = true;
            return isadmin;
        }
    }
    public class User : Users
    {
        public User(string userlogin, string userpass, string useremail, bool isadmin)
        {
            setUserLogin(userlogin);
            setUserPassword(userpass);
            setUserEmail(useremail);
            setAdmin(isadmin);
        }


        public override bool setAdmin(bool isadmin)
        {
            isadmin = false;
            return isadmin;
        }

        public void setUserLogin(string login)
        {
            this.userLogin = login;
        }
        public void setUserPassword(string password)
        {
            this.userPassword = password;
        }
        public void setUserEmail(string email)
        {
            this.userEmail = email;
        }
    }
}
