using DSharpPlus;

namespace DiscordChatBot;

public static class DiscordExtensions
{
    private static ChatBot? chatBot;

    public static DiscordClient AddChatBot(this DiscordClient discordClient)
    {
        chatBot = new ChatBot();
        chatBot.Initialize(discordClient);

        return discordClient;
    }
}