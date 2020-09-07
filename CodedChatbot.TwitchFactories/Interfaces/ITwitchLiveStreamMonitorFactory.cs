using TwitchLib.Api.Services;

namespace CodedChatbot.TwitchFactories.Interfaces
{
    interface ITwitchLiveStreamMonitorFactory
    {
        LiveStreamMonitorService Get();
    }
}
