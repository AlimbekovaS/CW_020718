using System;
using System.Runtime.Serialization;

namespace CW_020718
{
    [Serializable]
    internal class DirectoryNotFoundExeption : Exception
    {
        public DirectoryNotFoundExeption()
        {
        }

        public DirectoryNotFoundExeption(string message) : base(message)
        {
        }

        public DirectoryNotFoundExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DirectoryNotFoundExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}