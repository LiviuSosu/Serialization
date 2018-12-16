using Google.Protobuf;
using Google.Protobuf.Examples.AddressBook;
using System;
using System.Diagnostics;
using System.IO;
using static Google.Protobuf.Examples.AddressBook.Books.Types;
using static Google.Protobuf.Examples.AddressBook.Books.Types.BookInfo.Types;

namespace Protobuf_Classic
{
    class Program
    {
        static void Main(string[] args)
        {
            BookInfo bookInfo;
            Books books = new Books();
            for (int i = 1; i <= Config.Config.DataSetSize; i++)
            {
                bookInfo = new BookInfo();
                bookInfo.Id = i;
                bookInfo.Author = new Author() { Name = "Author name " + i};
                bookInfo.Title = "Title " + i;
                bookInfo.PageCount = i;

                books.Books_.Add(bookInfo);
            }
            var sw = new Stopwatch();
            sw.Start();

            string fileName = Config.Config.ProtobufFilePath;

            using (var output = File.Create(fileName))
            {
                books.WriteTo(output);
            }

            using (var input = File.OpenRead(fileName))
            {
                books = Books.Parser.ParseFrom(input);
            }
            sw.Stop();
            long elapsedMilliseconds = sw.ElapsedMilliseconds;
            Console.WriteLine("Finished!");
        }
    }
}
