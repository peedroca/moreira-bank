using MoreiraBank.Manager.Business;
using MoreiraBank.Manager.Models;
using MoreiraBank.Manager.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreiraBank.Manager.Facades
{
    internal class UserFacade
    {
        private UserModel? userModel;

        public void Create(string username, string password)
        {
            userModel = new UserModel(0, new Credential(username, password));
        }

        public void AddProfile(string firstName, string lastName, string email)
        {
            if (userModel == null)
                throw new InvalidOperationException(nameof(userModel));

            userModel.AddProfile(new ProfileModel(0, new Name(firstName, lastName), new Email(email)));
        }

        public Response<UserModel> Save()
        {
            var userBusiness = new UserBusiness();

            if (userModel == null)
                throw new InvalidOperationException(nameof(userModel));
            
            return userBusiness.Create(userModel);
        }
    }
}
