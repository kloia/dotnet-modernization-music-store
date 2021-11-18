using System.Web.Security;

namespace MvcMusicStore.Controllers
{
    public class AccountService
    {
        public bool LogOn(string username, string password)
        {

            return Membership.ValidateUser(username, password);
        }
        public MembershipCreateStatus Register(string username, string password, string email)
        {
            MembershipCreateStatus status;
            Membership.CreateUser(username, password, email, "question", "answer", true, null, out status);

            return status;
        }

        public bool ChangePassword(string userName, string oldPassword, string newPassword)
        {
            MembershipUser currentUser = Membership.GetUser(userName, true);
            return currentUser.ChangePassword(oldPassword, newPassword);
        }
    }
}
