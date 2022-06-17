using System;
using System.Runtime.Serialization;

namespace Szenzorhalozat
{
    [Serializable]
    internal class AlacsonyAlsoHatarException : Exception
    {
        public AlacsonyAlsoHatarException()
        {
        }

        public AlacsonyAlsoHatarException(string message) : base(message)
        {
        }

        public AlacsonyAlsoHatarException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AlacsonyAlsoHatarException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}