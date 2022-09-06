using System;
using System.Runtime.Serialization;

namespace bottomnavigationclass.models
{
    public class FragmentModel : ISerializable
    {
        public string name { get; set; }
        public FragmentModel()
        {
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
