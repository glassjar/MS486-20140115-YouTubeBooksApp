using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS486_20140115_YouTubeBooksApp.Models
{
    public class Book
    {
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishDate { get; set; }
    }
}