using System;

namespace TwilioApiClient.Exceptions
{
    public class SendSmsException : TwilioApiClientException
    {
        public SendSmsException()
        {
        }

        public SendSmsException(string message)
            : base(message)
        {
        }

        public SendSmsException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}