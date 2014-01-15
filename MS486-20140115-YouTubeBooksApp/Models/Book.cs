using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MS486_20140115_YouTubeBooksApp.Models
{
    public class Book
    {
        [Required]
        public string AuthorName { get; set; }

        [Required]
        public string Title { get; set; }
        
        public string Publisher { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
    }
}