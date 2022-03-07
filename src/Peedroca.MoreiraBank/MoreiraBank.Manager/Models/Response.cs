using Flunt.Notifications;

namespace MoreiraBank.Manager.Models
{
    internal class Response<T> where T : ModelBase
    {
        public Response()
        {
            Success = true;
            Errors = new List<Notification>();
        }

        public Response(IReadOnlyCollection<Notification> errors)
        {
            Success = false;
            Errors = errors;
        }

        public Response(T result) : this()
        {
            Result = result;
        }

        public bool Success { get; private set; }
        public T? Result { get; private set; }
        public IReadOnlyCollection<Notification> Errors { get; private set; }
    }
}
