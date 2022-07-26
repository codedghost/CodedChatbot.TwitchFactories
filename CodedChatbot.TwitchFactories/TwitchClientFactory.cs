using CodedChatbot.TwitchFactories.Interfaces;
using CoreCodedChatbot.Config;
using CoreCodedChatbot.Secrets;
using TwitchLib.Client;
using TwitchLib.Client.Models;

namespace CodedChatbot.TwitchFactories
{
    public class TwitchClientFactory : ITwitchClientFactory
    {
        private readonly IConfigService _configService;
        private readonly ISecretService _secretService;

        private TwitchClient _client;

        public TwitchClientFactory(
            IConfigService configService,
            ISecretService secretService
        )
        {
            _configService = configService;
            _secretService = secretService;
        }

        public TwitchClient Get()
        {
            if (_client == null || !_client.IsConnected || !_client.IsInitialized)
                Reconnect();

            return _client;
        }

        public void Reconnect()
        {
            var creds = new ConnectionCredentials(
                _configService.Get<string>("ChatbotNick"),
                _secretService.GetSecret<string>("ChatbotPass"));
            _client = new TwitchClient();
            _client.Initialize(creds, _configService.Get<string>("StreamerChannel"));
            _client.Connect();
        }
    }
}