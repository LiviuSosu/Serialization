using System;
using System.Collections.Generic;
using System.Text;

namespace JsonSerializer
{
    public class BookInfo
    {
        public int Id { get; set; }
        public Author Authtor { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
    }
}
