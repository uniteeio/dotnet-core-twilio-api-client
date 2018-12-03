using System.Linq.Expressions;
using System.Threading.Tasks;
using Twilio;
using Twilio.Exceptions;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Rest.Proxy.V1.Service.Session.Participant;
using Twilio.Types;
using TwilioApiClient.Exceptions;

namespace TwilioApiClient
{
    public class TwilioApiClient : ITwilioApiClient
    {
        private readonly TwilioApiOptions _options;

        public TwilioApiClient(TwilioApiOptions options)
        {
            _options = options;
        }

        public async Task<MessageResource> SendSms(string receiverNumber, string smsBody)
        {
            TwilioClient.Init(_options.AccountSid, _options.AuthToken);

            if (string.IsNullOrEmpty(receiverNumber))
            {
                throw new EmptyReceiverNumberException();
            }

            try
            {
                var message = MessageResource.Create(
                    body: smsBody,
                    from: new PhoneNumber(_options.SenderPhoneNumber),
                    to: new PhoneNumber(receiverNumber)
                );
                
                if (message.Status == MessageInteractionResource.ResourceStatusEnum.Failed)
                {
                    throw new SendSmsException();
                }

                return message;
            }
            catch (ApiException e)
            {
                 throw new TwilioApiClientException(e.Message);
            }
        }
    }
}