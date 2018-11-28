using System;

namespace TwilioApiClient.Exceptions
{
    public class TwilioApiClientException : Exception
    {
        public TwilioApiClientException()
        {
        }

        public TwilioApiClientException(string message)
            : base(message)
        {
        }

        public TwilioApiClientException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}