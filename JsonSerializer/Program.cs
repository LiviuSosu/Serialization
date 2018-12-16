using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace JsonSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<BookInfo>();
            BookInfo bookInfo;

            for (int i=1;i <= Config.Config.DataSetSize; i++)
            {
                bookInfo = new BookInfo();

                bookInfo.Id = i;
                bookInfo.Authtor = new Author() {
                    Name = "Author name "+i
                };
                bookInfo.PageCount = i;
                bookInfo.Title = "Title "+i;
                
                books.Add(bookInfo);
            }

            var sw = new Stopwatch();
            sw.Start();
            string serializedBooks = Newtonsoft.Json.JsonConvert.SerializeObject(books);

            //File.WriteAllText(Config.Config.JsonFilePath, serializedBooks);

            Newtonsoft.Json.JsonConvert.DeserializeObject<List<BookInfo>>(serializedBooks);
            sw.Stop();
            long elapsedMilliseconds = sw.ElapsedMilliseconds;

            Console.WriteLine("Finished!");
        }
    }
}
