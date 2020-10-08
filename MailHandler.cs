using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatR_sample
{
    public class MailHandler : INotificationHandler<User>
    {
        public Task Handle(User user, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Send Mail to {user.Username}.");
            return Task.FromResult(true);
        }
    }
}