using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreSample1
{
    public class Book
    {
        public int BookId { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }
        public string Publisher { get; set; }

        [MaxLength(20)]
        public string Isbn { get; set; }
    }
}
