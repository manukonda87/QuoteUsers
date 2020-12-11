using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class QuoteController : Controller
    {
        IManageQuote manageQuote = null;
        IManageUsers manageUsers = null;
        public QuoteController()
        {
             manageQuote = new ManageQuote();
            manageUsers = new ManageUsers();
        }
        // GET: Quote
        public ActionResult Index(int ? id)
        {
            int quoteid = id ?? 1;
            Quote quote = manageQuote.GetQuote(quoteid);
            return View(quote);
        }

        public ActionResult getQuoteUsers(int quoteId)
        {
            List<User> users = manageUsers.GetQuoteUsers(quoteId);
            return PartialView("../ListQuoteUsers/PartialViews/_QuoteUsersList", users);
        }

        public ActionResult getSearchUsers(string firstName, string lastName, int QuoteId)
        {
            List<UserQuoteViewModel> usersviewModel = manageUsers.GetSearchUsers(firstName, lastName, QuoteId);
            return PartialView("../Users/PartialViews/_SearchUsersList", usersviewModel);
        }

        public bool addUsertoQuote(int userId, int quoteId)
        {
            bool isUserAdded = manageUsers.AddUserToQuote(userId, quoteId);
            return isUserAdded;
        }
        public bool deleteUserFromQuote(int userId, int quoteId)
        {
            bool isUserRemoved = manageUsers.DeleteUserFromQuote(userId, quoteId);
            return isUserRemoved;
        }
    }
}