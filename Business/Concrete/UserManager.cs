using Business.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public User GetByMail(string email)
        {
            throw new NotImplementedException();
        }

        public List<OperationClaim> GetClaims(User user)
        {
            throw new NotImplementedException();
        }
    }
}
