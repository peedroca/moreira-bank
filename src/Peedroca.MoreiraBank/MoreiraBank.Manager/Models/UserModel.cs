using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreiraBank.Manager.Models
{
    internal class UserModel
    {
        public UserModel(string name, string password)
        {
            Name = name;
            Password = password;

            Profiles = new List<ProfileModel>();
        }

        public string Name { get; private set; }
        public string Password { get; private set; }

        public IReadOnlyCollection<ProfileModel> Profiles { get; private set; }
    }
}
