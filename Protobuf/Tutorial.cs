using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protobuf
{
    [ProtoContract]
    public class Book
    {
        [ProtoMember(1)]
        public Author Author { get; set; }
        [ProtoMember(2)]
        public string Name { get; set; }
        [ProtoMember(3)]
        public int PageCount { get; set; }
        [ProtoMember(4)]
        public string Extra { get; set; }
    }

    [ProtoContract]
    public class Author
    {
        [ProtoMember(1)]
        public string Name { get; set; }
    }
}
