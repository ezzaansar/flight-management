using SE3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3
{
    public class UserService
    {
        private static UserService? _instance = null;
        public static UserService Instance
        {
            get
            {
                if (_instance == null) _instance = new UserService();
                return _instance;
            }
        }

        private User? _currentUser = null;
        public User? CurrentUser => _currentUser;
        public void SetCurrentUser(User? user) => _currentUser = user;
    }
}
