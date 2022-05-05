using System;
using System.Collections.Generic;
namespace WEBapi.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>() {
            new UserModel() { Username = "admin", EmailAddress = "admin@hotmail.com", Password = "admin" , GivenName = "Admin", Surname = " Admin" , Role = "Admin" },
        new UserModel() { Username = "admin", EmailAddress = "admin@hotmail.com", Password = "admin" , GivenName = "Admin", Surname = " Admin" , Role = "Admin" },
             new UserModel() { Username = "client", EmailAddress = "client@hotmail.com", Password = "client" , GivenName = "Client", Surname = "Client" , Role = "Common" }



    };
       
    }
    
}
