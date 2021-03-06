using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;

namespace TwilioApiClient
{
    public interface ITwilioApiClient
    {
        Task<MessageResource> SendSms(string receiverNumber, string smsBody);
    }
}