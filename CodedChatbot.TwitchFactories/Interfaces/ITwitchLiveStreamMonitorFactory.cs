using TwitchLib.Api.Services;

namespace CodedChatbot.TwitchFactories.Interfaces
{
    public interface ITwitchLiveStreamMonitorFactory
    {
        LiveStreamMonitorService Get();
    }
}
