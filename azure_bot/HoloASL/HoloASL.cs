using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Threading.Tasks;

namespace HoloASL
{
    public class HoloASL : IBot
    {
        public async Task OnTurn(ITurnContext context)
        {
            ConversationContext.userMsg = context.Activity.Text;

            if (context.Activity.Type is ActivityTypes.Message)
            {
                if (string.IsNullOrEmpty(ConversationContext.userName))
                {
                    ConversationContext.userName = ConversationContext.userMsg;
                    await context.SendActivity($"Hello {ConversationContext.userName}. Looks like today it is going to rain. \nLuckily I have umbrellas and waterproof jackets to sell!");
                }
                else
                {
                    if (ConversationContext.userMsg.Contains("how much"))
                    {
                        if (ConversationContext.userMsg.Contains("umbrella")) await context.SendActivity($"Umbrellas are $13.");
                        else if (ConversationContext.userMsg.Contains("jacket")) await context.SendActivity($"Waterproof jackets are $30.");
                        else await context.SendActivity($"Umbrellas are $13. \nWaterproof jackets are $30.");
                    }
                    else if (ConversationContext.userMsg.Contains("color") || ConversationContext.userMsg.Contains("colour"))
                    {
                        await context.SendActivity($"Umbrellas are black. \nWaterproof jackets are yellow.");
                    }
                    else
                    {
                        await context.SendActivity($"Sorry {ConversationContext.userName}. I did not understand the question");
                    }
                }
            }
            else
            {

                ConversationContext.userMsg = string.Empty;
                ConversationContext.userName = string.Empty;
                await context.SendActivity($"Welcome! \nI am the Weather Shop Bot \nWhat is your name?");
            }

        }
    }
}