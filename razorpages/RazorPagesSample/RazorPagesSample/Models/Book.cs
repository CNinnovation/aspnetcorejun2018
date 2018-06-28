using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesSample.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(20)]
        public string Publisher { get; set; }
    }
}
