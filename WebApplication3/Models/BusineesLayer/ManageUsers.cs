using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class ManageUsers : IManageUsers
    {
        public List<User> GetQuoteUsers(int quoteid)
        {
            var userids = DummyQuoteUsersData.addQuoteUsers().Where(q => q.QuoteId == quoteid).Select(q=>q.UserId).ToArray();
            var users = DummyUserData.addUsers().Where(u => userids.Contains(u.Id)).ToList();
            return users;
        }

        public List<UserQuoteViewModel> GetSearchUsers(string firstName, string lastName,int quoteId)
        {
            List<UserQuoteViewModel> userQuoteModel = new List<UserQuoteViewModel>();
            var userids = DummyQuoteUsersData.addQuoteUsers().Where(q => q.QuoteId == quoteId).Select(q => q.UserId).ToArray();
            var users = DummyUserData.addUsers().Where(u => firstName.ToLower().Contains(u.FirstName.ToLower()) || lastName.ToLower().Contains(u.LastName.ToLower())).ToList();
            foreach(var user in users)
            {
                userQuoteModel.Add(new UserQuoteViewModel { user = user, IsExistingUser = userids.Contains(user.Id) ? true: false});
            }

            return userQuoteModel;
        }

        public bool AddUserToQuote(int userId, int quoteId)
        {
            int QuoteUserscount = DummyQuoteUsersData.quoteUsers.Count;
            DummyQuoteUsersData.quoteUsers.Add(new QuoteUser { UserId = userId, QuoteId = quoteId, Id = QuoteUserscount + 1 });
            if(DummyQuoteUsersData.quoteUsers.Count > QuoteUserscount)
            {
                return true;
            }
            return false;
        }

        public bool DeleteUserFromQuote(int userId, int quoteId)
        {
            int QuoteUserscount = DummyQuoteUsersData.quoteUsers.Count;

            DummyQuoteUsersData.quoteUsers.Remove(DummyQuoteUsersData.quoteUsers.Where(q => q.UserId == userId && q.QuoteId == quoteId).SingleOrDefault());
            if (DummyQuoteUsersData.quoteUsers.Count <  QuoteUserscount)
            {
                return true;
            }
            return false;
        }
    }
}