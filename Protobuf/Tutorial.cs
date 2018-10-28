using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protobuf
{
    [ProtoContract]
    public class Tutorial
    {
        [ProtoMember(1)]
        public string Author { get; set; }
        [ProtoMember(2)]
        public string Name { get; set; }
        [ProtoMember(3)]
        public int PageCount { get; set; }
    }
}
