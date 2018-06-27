using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApp.ViewComponents
{
    public class MySampleViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string data1, string data2)
        {
            return Task.FromResult<IViewComponentResult>(
                View(MyDataMethod(data1, data2)));
        }

        private (string V1, string V2) MyDataMethod(string d1, string d2)
            => (d1, d2);
    }
}
