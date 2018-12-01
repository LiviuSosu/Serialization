using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AvroSerializer
{
    //Sample class used in serialization samples
    [DataContract(Name = "SensorDataValue", Namespace = "Sensors")]
    class SensorData
    {
        [DataMember(Name = "Location")]
        public Location Position { get; set; }

        [DataMember(Name = "Value")]
        public byte[] Value { get; set; }
    }

    //Sample struct used in serialization samples
    [DataContract]
    internal struct Location
    {
        [DataMember]
        public int Floor { get; set; }

        [DataMember]
        public int Room { get; set; }
    }
}
