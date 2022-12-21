using RH_PJ.Base.Models;

namespace RH_PJ.Base
{
    public class RHPJUsers
    {
        public static Dictionary<string, UserLogin> Users = new Dictionary<string, UserLogin>();

        public static UserLogin Get(string username)
        {
            if (!Users.ContainsKey(username)) return null;

            var u = Users[username];
            return u;
        }
        public static bool Check(string username, UserLogin user)
        {
            if (!Users.ContainsKey(username))
            {
                Users.Add(username, user);
                return true;
            }
            return true;
        }
        public static bool Remove(string username)
        {
            if (!Users.ContainsKey(username))
            {
                Users.Remove(username);
                return true;
            }
            return false;
        }
    }
}