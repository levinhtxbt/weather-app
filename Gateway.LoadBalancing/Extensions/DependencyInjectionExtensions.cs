using Steeltoe.Discovery;
using Yarp.ReverseProxy.Configuration;

namespace Gateway.LoadBalancing.Extensions;

public static class DependencyInjectionExtensions
{
    public static IReverseProxyBuilder LoadFromDiscoveryService(this IReverseProxyBuilder builder)
    {
        builder.Services.AddSingleton<InMemoryConfigProvider>();

        builder.Services.AddSingleton<IHostedService>(ctx => ctx.GetRequiredService<InMemoryConfigProvider>());

        builder.Services.AddSingleton<IProxyConfigProvider>(ctx => ctx.GetRequiredService<InMemoryConfigProvider>());

        return builder;
    }
}