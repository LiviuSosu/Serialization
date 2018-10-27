using Common.ThriftInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift.Server;
using Thrift.Transport;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler = new LibraryServiceHandler();
            var processor = new LibraryService.Processor(handler);

            TServerTransport transport = new TServerSocket(9090);
            TServer server = new TThreadPoolServer(processor, transport);

            server.Serve();
        }
    }
}
