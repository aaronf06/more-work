using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarthomecontrollers
{
    public class User
    {
        // private fields 
        private int userId;
        private string username;
        private string password;
        private string contactInfo;
        private bool isLoggedin;
        private bool isloggedout; 
        public int UserId
        {
            get { return UserId; }
            set { UserId = value; }
        }
      
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool IsLoggedin
        {
            get { return isLoggedin; }
            set { isLoggedin = value; }
        }
        public bool IsLoggedOut
        {
            get { return IsLoggedOut; } 
            set { IsLoggedOut = value;  }
            }


        // constructor 

        public User (int userID, 
            string password,
            string username,
            string contactInfo,
            bool isLoggedin)
        {
            userID = userId; 
           UserName = username;
            Password = password;
            ContactInfo = contactInfo;
           IsLoggedin = isLoggedin;
        }

    public bool Login( string username, string password )
        {
            if (UserName == UserName && Password == password )
            {
                isLoggedin = true;
                Console.WriteLine("Log in Succesful");
            }
            else
            {
                isLoggedin = false;
                Console.WriteLine($"Log in failed. User {username} or password is incorrect"); ; 

            }
            return isLoggedin;
        }
        public bool Logout( string username, string password ) {
            if (isLoggedin == true )
            {
                  
                isLoggedin = false;
                Console.WriteLine("You have been logged out");
            }
            else
            {
                
                isLoggedin = false;
                Console.WriteLine("You are not logged in");
            }
            return IsLoggedin; 
            }
    }

}
