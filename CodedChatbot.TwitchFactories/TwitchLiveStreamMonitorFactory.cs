using System.Linq;
using CodedChatbot.TwitchFactories.Interfaces;
using TwitchLib.Api.Services;

namespace CodedChatbot.TwitchFactories
{
    public class TwitchLiveStreamMonitorFactory : ITwitchLiveStreamMonitorFactory
    {
        private readonly ITwitchApiFactory _twitchApiFactory;
        private LiveStreamMonitorService _monitorService;

        public TwitchLiveStreamMonitorFactory(ITwitchApiFactory twitchApiFactory)
        {
            _twitchApiFactory = twitchApiFactory;
        }

        public LiveStreamMonitorService Get()
        {
            if (_monitorService == null || _monitorService.ChannelsToMonitor == null ||
                _monitorService.ChannelsToMonitor.Any())
                Reconnect();

            return _monitorService;
        }

        public void Reconnect()
        {
            var api = _twitchApiFactory.Get();
            
            _monitorService = new LiveStreamMonitorService(api);
        }
    }
}