﻿using System;

namespace Sangmado.Inka.MessageEncoding
{
    [Serializable]
    public class CannotDeserializeMessageException : Exception
    {
        public CannotDeserializeMessageException()
            : base()
        {
        }

        public CannotDeserializeMessageException(string message)
            : base(message)
        {
        }

        public CannotDeserializeMessageException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
