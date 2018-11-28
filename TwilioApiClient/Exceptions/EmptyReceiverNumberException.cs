using System;

namespace TwilioApiClient.Exceptions
{
    public class EmptyReceiverNumberException : TwilioApiClientException
    {
        public EmptyReceiverNumberException()
        {
        }

        public EmptyReceiverNumberException(string message)
            : base(message)
        {
        }

        public EmptyReceiverNumberException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}