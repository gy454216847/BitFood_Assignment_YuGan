using BitFood_Assignment_YuGan.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitFood_Assignment_YuGan.Pages
{
    /// <summary>
    /// Define main page elements and methods
    /// </summary>
    public class MainPage
    {
        public static string SearchBox = "id=search-box";
        public static void SearchItem(string item)
        {
            CommonWeb.Type(SearchBox, item);
            CommonWeb.TypeEnter(SearchBox);
        }
    }
}
