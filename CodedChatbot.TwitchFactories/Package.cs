using CodedChatbot.TwitchFactories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CodedChatbot.TwitchFactories
{
    public static class Package
    {
        public static IServiceCollection AddTwitchFactories(this IServiceCollection services)
        {
            services.AddSingleton<ITwitchApiFactory, TwitchApiFactory>();
            services.AddSingleton<ITwitchClientFactory, TwitchClientFactory>();

            return services;
        }
    }
}