using System.Collections.Specialized;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNet.WebHooks;

namespace SlackReceiver.WebHooks
{
    public class SlackWebHookHandler : WebHookHandler
    {
        public SlackWebHookHandler()
        {
            this.Receiver = "slack";
        }

        public override Task ExecuteAsync(string generator, WebHookHandlerContext context)
        {
            var allValues = context.Data as NameValueCollection;

            var insertedValue = allValues["text"];
            var triggerWord = allValues["trigger_word"];

            var finalAnswer = string.IsNullOrEmpty(insertedValue) == false
                                    ? insertedValue.Replace(triggerWord, "http://ticketingsystem.com/?ticketid=")
                                    : "Nepoznat ticket!";

            context.Response = context.Request.CreateResponse(new SlackResponse(finalAnswer));

            return Task.FromResult(true);
        }
    }
}