using System;
using System.Runtime.Serialization;

namespace Szenzorhalozat
{
    [Serializable]
    internal class RosszHatarokException : Exception
    {
        public RosszHatarokException()
        {
        }

        public RosszHatarokException(string message) : base(message)
        {
        }

        public RosszHatarokException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RosszHatarokException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}