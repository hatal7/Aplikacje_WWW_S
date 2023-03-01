using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS_lab1_gr1.Models
{
    public class Articles
    {
        public int Id {get; set;}
        public string Title {get; set;}

        public string Content {get; set;}
        public DateTime CreationDate {get; set;}
    }
}