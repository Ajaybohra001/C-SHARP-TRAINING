using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Author
    {
        public string authorName {  get; set; }
        public int authorId { get; set; }
        public string authorEmail { get; set; }


        public  ICollection<Book> books { get; set; }


    }
}
