using DiscordChatBot;
using DSharpPlus;
using Microsoft.Extensions.Configuration;

var source = new CancellationTokenSource();

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", true)
    .AddUserSecrets(typeof(Program).Assembly, true)
    .Build();

var discordClient = new DiscordClient(new DiscordConfiguration
{
    Token = configuration["discordtoken"],
    TokenType = TokenType.Bot
});

discordClient.AddChatBot();

var token = source.Token;

await discordClient.ConnectAsync();

while (!token.IsCancellationRequested)
{
    await Task.Delay(100);

}
