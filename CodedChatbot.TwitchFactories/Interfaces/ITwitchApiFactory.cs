using TwitchLib.Api;

namespace CodedChatbot.TwitchFactories.Interfaces
{
    public interface ITwitchApiFactory
    {
        TwitchAPI Get();
        void Reconnect();
    }
}