using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApp.Controllers
{
    public class CalcController
    {
        public int Add(int x, int y) => x + y;
        public int Sub(int x, int y) => x - y;
    }
}
