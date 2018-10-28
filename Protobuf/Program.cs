using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace Protobuf
{
    class Program
    {
        static void Main(string[] args)
        {
            Tutorial objTutorial = new Tutorial();
            objTutorial.Author = "Author";
            objTutorial.Name = "Name 1";
            objTutorial.PageCount = 50;
            byte[] tempByte = GPBSerialization(objTutorial);
            Tutorial objReconstructed = (Tutorial)GDPDeserialization(tempByte);
        }

        public static byte[] GPBSerialization(object objectToSerialize)
        {
            if (objectToSerialize == null)
            {
                return null;
            }
            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    Serializer.Serialize(stream, objectToSerialize);
                    return stream.ToArray();
                }
            }
            catch
            {
                throw;
            }
        }

        public static object GDPDeserialization(byte[] data)
        {
            if (data == null)
            {
                return null;
            }
            try
            {
                using (MemoryStream stream = new MemoryStream(data))
                {
                    return Serializer.Deserialize(typeof(Tutorial), stream);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
