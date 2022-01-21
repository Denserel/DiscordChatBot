using DSharpPlus;
using DSharpPlus.EventArgs;

namespace DiscordChatBot;

internal class ChatBot
{
    public void Initialize(DiscordClient discordClient)
    {
        discordClient.MessageCreated += OnMessageCreated;
    }

    private async Task OnMessageCreated(DiscordClient client, MessageCreateEventArgs args)
    {
        if (args.Message.Content.StartsWith("hi"))
        {
            await client.SendMessageAsync(args.Channel, $"hey, {args.Author.Username} how is it going");
        }
    }
}

