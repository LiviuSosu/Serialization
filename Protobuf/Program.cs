using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var books = new List<BookInfo>();
            BookInfo bookInfo;

            for (int i = 1; i <= Config.Config.DataSetSize; i++)
            {
                bookInfo = new BookInfo();

                bookInfo.Id = i;
                bookInfo.Author = new Author()
                {
                    Name = "Author name " + i
                };
                bookInfo.PageCount = i;
                bookInfo.Title = "Title " + i;

                books.Add(bookInfo);
            }

            var sw = new Stopwatch();
            sw.Start();
            byte[] tempByte = GPBSerialization(books);
            var objReconstructed = (List<BookInfo>)GDPDeserialization(tempByte);
            sw.Stop();
            long elapsedMilliseconds = sw.ElapsedMilliseconds;
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
                    return Serializer.Deserialize(typeof(List<BookInfo>), stream);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
