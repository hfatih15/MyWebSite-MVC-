using MyWebSite.DAL.MyEntities;
using MyWebSite.DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.BLL
{
   public class UserService 
    {
        UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public int AddUser(User item)
        {
            return _userRepository.AddItem(item);
        }


    }
}
