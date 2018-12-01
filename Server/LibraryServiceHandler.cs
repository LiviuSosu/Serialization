using Common.ThriftInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class LibraryServiceHandler : LibraryService.Iface
    {
        public List<BookInfo> GetAllBooks()
        {
            BookInfo bookInfo;
            var bookInfos = new List<BookInfo>();
            for (int i = 1; i <= Config.Config.DataSetSize; i++)
            {
                bookInfo = new BookInfo();
                bookInfo.Id = i;
                bookInfo.Author = new Author() { Name = "Author name "+i };
                bookInfo.Title = "Title "+i;
                bookInfo.PageCount = i;

                bookInfos.Add(bookInfo);
            }

            return bookInfos;
        }

        public BookInfo GetBook(int bookId)
        {
            var bookInfo = new BookInfo();
            bookInfo.Id = 1;
            bookInfo.Author = new Author() { Name = "Gheorghe" };
            bookInfo.Title = "Title 1";

            return bookInfo;
        }
    }
}
