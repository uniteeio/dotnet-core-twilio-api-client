# A .NET Core 2 client for Twilio API

Nuget package can be found here : https://www.nuget.org/packages/Unitee.Twilio.ApiClient

## Usage for a dotnet core mvc application
### Configuration

Add Twilio AccountSid and AuthToken in the root of your appsettings.json :

<pre>
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  <b>"Twilio": {
    "AccountSid": "ABCDEF123456",
    "AuthToken": "a5ze5rty123qs3df3gh"
  }</b>
}
</pre>

Add TwilioApiClient service in your Startup.cs file :
<pre>
// This method gets called by the runtime. Use this method to add services to the container.
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
    <b>services.AddTwilioApiClient(Configuration); </b>
}
</pre>
        
### Service injection
Inject TwilioApiClient service in your class (controller, ...) : 
<pre>
private readonly ITwilioApiClient _twilioApiClient;

public ValuesController(ITwilioApiClient twilioApiClient)
{
    _twilioApiClient = twilioApiClient;
}
</pre>

Use SendSms method to send an SMS :
```
[HttpGet]
public async Task<ActionResult<MessageResource>> Get()
{
    return await _twilioApiClient.SendSms(
            "+3365454545", //senderPhoneNumber
            "+3378989898", //receiverPhoneNumber
            "Hello from +3365454545" //smsBody
            new Dictionary<string, string> {{"ids", "all"}}
     );
}
```
