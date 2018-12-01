using Common.ThriftInterface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift.Protocol;
using Thrift.Transport;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var transport = new TSocket("localhost", 9090);
            var protocol = new TBinaryProtocol(transport);
            var client = new LibraryService.Client(protocol);

            transport.Open();

            var sw = new Stopwatch();
            sw.Start();
            var allBooks = client.GetAllBooks(); // Actual Thrift call
            sw.Stop();
            long elapsedMilliseconds = sw.ElapsedMilliseconds;
            // var firstBook = client.GetBook(allBooks.First().Id); // Actual Thrift call
        }
    }
}
