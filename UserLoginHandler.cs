using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatR_sample
{
    public class UserLoginHandler : INotificationHandler<User>
    {
        public Task Handle(User user, CancellationToken cancellationToken)
        {
            Console.WriteLine($"User Login: {user.Username}");
            return Task.FromResult(true);
        }
    }
}