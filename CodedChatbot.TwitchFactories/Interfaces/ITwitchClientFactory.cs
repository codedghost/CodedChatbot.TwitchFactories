using TwitchLib.Client;

namespace CodedChatbot.TwitchFactories.Interfaces
{
    public interface ITwitchClientFactory
    {
        TwitchClient Get();
        void Reconnect();
    }
}