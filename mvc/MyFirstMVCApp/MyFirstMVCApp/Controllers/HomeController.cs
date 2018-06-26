using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApp.Controllers
{
    public class HomeController
    {
        public string Index() => "Index";
        public string About() => "About";

        public int Add(int x, int y) => x + y;

        public string ToUpper(string id) => id.ToUpper();
    }
}
