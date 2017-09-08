using System;
using System.Runtime.Serialization;

namespace prueba_individual_serv.Exceptions
{
    [Serializable]
    internal class NoEncontradoException : Exception
    {
        public NoEncontradoException()
        {
        }

        public NoEncontradoException(string message) : base(message)
        {
        }

        public NoEncontradoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoEncontradoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}