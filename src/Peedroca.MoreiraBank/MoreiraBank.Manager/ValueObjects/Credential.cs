using Flunt.Notifications;
using Flunt.Validations;
using System.Security.Cryptography;
using System.Text;

namespace MoreiraBank.Manager.ValueObjects
{
    internal class Credential : ValueObjectBase
    {
        public string Username { get; private set; }
        public string HashPassword { get; private set; }

        public Credential(string username)
        {
            Username = username;
            HashPassword = string.Empty;

            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNullOrEmpty(Username, nameof(Username))
            );
        }

        public Credential(string username, string password)
        {
            Username = username;
            HashPassword = GetEncrypted(password);

            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNullOrEmpty(Username, nameof(Username))
                .IsNotNullOrEmpty(password, "Password")
            );
        }

        public string GetEncrypted(string password)
        {
            if (password == null)
                throw new ArgumentNullException("Password");

            var message = Encoding.UTF8.GetBytes(password);
            using (var alg = SHA512.Create())
            {
                string hex = "";

                var hashValue = alg.ComputeHash(message);
                foreach (byte x in hashValue)
                {
                    hex += String.Format("{0:x2}", x);
                }
                return hex;
            }
        }
    }
}
