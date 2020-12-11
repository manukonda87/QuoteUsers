using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    interface IManageUsers
    {
        List<User> GetQuoteUsers(int Quoteid);

        List<UserQuoteViewModel> GetSearchUsers(string firstName, string lastName,int quoteId);

        bool AddUserToQuote(int userId, int quoteId);

        bool DeleteUserFromQuote(int userId, int quoteId);
    }
}
