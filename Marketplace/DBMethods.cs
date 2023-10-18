using Marketplace.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace
{
    public class DBMethods
    {
        public static bool CheckLoginExists(string login)
        {
            try
            {
                Authorization auth = App.Connection.Authorization.First(x => x.Login == login);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static User GetUserByAuthorization(Authorization auth)
        {
            return App.Connection.User.First(x => x.idAuthorization == auth.idAuthorization);
        }
    }
}
