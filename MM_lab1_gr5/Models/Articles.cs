using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MM_lab1_gr5.Models
{
    public class Article
    {
        public int Id { get ; set;}
        public String Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
    }
}