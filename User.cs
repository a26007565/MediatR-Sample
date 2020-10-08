using MediatR;

namespace MediatR_sample
{
    public class User : INotification, IRequest<bool>
    {
        public User(string username)
        {
            Username = username;
        }
        public string Username { get; }
        public string Password { get; set; }
    }
}