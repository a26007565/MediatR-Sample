using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MediatR_sample
{
    internal static class Program
    {
        private static async System.Threading.Tasks.Task Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureServices((_, services)
                    => services.AddMediatR(typeof(User)))
                .UseConsoleLifetime()
                .Build();

            using var serviceScope = host.Services.CreateScope();
            var serviceProvider = serviceScope.ServiceProvider;

            var mediator = serviceProvider.GetRequiredService<IMediator>();

            var userA = new User("UserA");
            await mediator.Send(userA).ConfigureAwait(false);
            await mediator.Publish(userA).ConfigureAwait(false);

            var userB = new User("UserB");
            await mediator.Publish(userB).ConfigureAwait(false);
        }
    }
}
