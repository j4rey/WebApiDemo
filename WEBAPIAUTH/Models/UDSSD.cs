using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPIAUTH.Models
{
    public class UDSSD
    {
        public List<ssdclass> SSD { get; set; }
        public int totalRows { get; set; }
        public int currentPage { get; set; }
        
        public UDSSD()
        {
           
        }
    }

    public class ssdclass
    {
        public int indexCount { get; set; }
        public System.Guid ID { get; set; }
        public string POST_NAME { get; set; }
        public string POST_CONTENT { get; set; }
        public string POST_TYPE { get; set; }
        public Nullable<System.DateTime> DATE_ENTERED { get; set; }

        public static List<ssdclass> get()
        {
            List<ssdclass> lst = new List<ssdclass>();
            for (int i = 0; i < 761; i++)
            {
                lst.Add(
                    new ssdclass()
                    {
                        indexCount = i,
                        ID = Guid.NewGuid(),
                        POST_NAME = "Post name " + i,
                        POST_CONTENT = "Post Content " + i,
                        POST_TYPE = "Post Type " + i,
                        DATE_ENTERED = null
                    }
                    );
            }
            return lst;
        }
    }

    public class LoginModel
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class UserModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string[] role { get; set; }

        public static List<UserModel> Users()
        {
            List<UserModel> lst = new List<UserModel>();
            lst.Add(new UserModel() { username = "user", password = "password", role = new string[] { "user" } });
            lst.Add(new UserModel() { username = "admin", password = "password", role = new string[] { "admin" } });
            lst.Add(new UserModel() { username = "visitor", password = "password", role = new string[] { "visitor" } });

            return lst;
        }
    }
}