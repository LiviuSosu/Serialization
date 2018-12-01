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
        public List<BookInfo> GetAllBooks() {

            var bookInfo = new BookInfo();
            bookInfo.Id = 1;
            bookInfo.Author = new Author() { Name="Gheorghe"};
            bookInfo.Title = "Title 1";
            bookInfo.PageCount = 5;

            var bookInfos = new List<BookInfo>();
            bookInfos.Add(bookInfo);
            return bookInfos;
        }

        public BookInfo GetBook(int bookId) {
            var bookInfo = new BookInfo();
            bookInfo.Id = 1;
            bookInfo.Author = new Author() { Name = "Gheorghe" };
            bookInfo.Title = "Title 1";

            return bookInfo;
        }
    }
}
