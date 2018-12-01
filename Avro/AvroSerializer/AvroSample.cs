//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;

//namespace AvroSerializer
//{
//    //This class contains all methods demonstrating
//    //the usage of Microsoft Avro Library
//    public class AvroSample
//    {
//        //Serialize and deserialize sample data set represented as an object using reflection.
//        //No explicit schema definition is required - schema of serialized objects is automatically built.
//        public void SerializeDeserializeObjectUsingReflection()
//        {

//            Console.WriteLine("SERIALIZATION USING REFLECTION\n");
//            Console.WriteLine("Serializing Sample Data Set...");

//            //Create a new AvroSerializer instance and specify a custom serialization strategy AvroDataContractResolver
//            //for serializing only properties attributed with DataContract/DateMember
//            var avroSerializer = AvroSerializer.Create<SensorData>();

//            //Create a memory stream buffer
//            using (var buffer = new MemoryStream())
//            {
//                //Create a data set by using sample class and struct
//                var expected = new SensorData { Value = new byte[] { 1, 2, 3, 4, 5 }, Position = new Location { Room = 243, Floor = 1 } };

//                //Serialize the data to the specified stream
//                avroSerializer.Serialize(buffer, expected);


//                Console.WriteLine("Deserializing Sample Data Set...");

//                //Prepare the stream for deserializing the data
//                buffer.Seek(0, SeekOrigin.Begin);

//                //Deserialize data from the stream and cast it to the same type used for serialization
//                var actual = avroSerializer.Deserialize(buffer);

//                Console.WriteLine("Comparing Initial and Deserialized Data Sets...");

//                //Finally, verify that deserialized data matches the original one
//                bool isEqual = this.Equal(expected, actual);

//                Console.WriteLine("Result of Data Set Identity Comparison is {0}", isEqual);

//            }
//        }

//        //
//        //Helper methods
//        //

//        //Comparing two SensorData objects
//        private bool Equal(SensorData left, SensorData right)
//        {
//            return left.Position.Equals(right.Position) && left.Value.SequenceEqual(right.Value);
//        }

//    }
//}
