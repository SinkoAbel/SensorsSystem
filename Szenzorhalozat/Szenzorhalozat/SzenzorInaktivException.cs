using System;
using System.Runtime.Serialization;

namespace Szenzorhalozat
{
    [Serializable]
    internal class SzenzorInaktivException : Exception
    {
        public SzenzorInaktivException()
        {
        }

        public SzenzorInaktivException(string message) : base(message)
        {
        }

        public SzenzorInaktivException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SzenzorInaktivException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}