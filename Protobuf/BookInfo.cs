using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protobuf
{
    [ProtoContract]
    public class BookInfo
    {
        [ProtoMember(1)]
        public int Id { get; set; }
        [ProtoMember(2)]
        public Author Author { get; set; }
        [ProtoMember(3)]
        public string Title { get; set; }
        [ProtoMember(4)]
        public int PageCount { get; set; }
    }

    [ProtoContract]
    public class Author
    {
        [ProtoMember(1)]
        public string Name { get; set; }
    }
}
