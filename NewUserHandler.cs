using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatR_sample
{
    public class NewUserHandler : IRequestHandler<User, bool>
    {
        public Task<bool> Handle(User user, CancellationToken cancellationToken)
        {
            Console.WriteLine($"User register: {user.Username}.");
            return Task.FromResult(true);
        }
    }
}