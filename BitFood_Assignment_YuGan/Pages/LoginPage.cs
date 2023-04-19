using BitFood_Assignment_YuGan.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitFood_Assignment_YuGan.Pages
{
    /// <summary>
    /// Define login page elements and methods
    /// </summary>
    public class LoginPage
    {
        public static string UserNameBox = "id=UserName";
        public static string PasswordBox = "id=Password";
        public static string LoginButton = "id=submitBtn";
        public static void Login(string username,string password)
        {
            CommonWeb.Type(UserNameBox, username);
            CommonWeb.Type(PasswordBox, password);
            CommonWeb.Click(LoginButton);
        }
    }
}
