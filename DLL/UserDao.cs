using System;
using System.Linq;
using Models;
namespace DLL
{
    public class UserDao
    {
        public static testContext db = new testContext();
        /// <summary>
        /// 增加一个用户数据
        /// </summary>
        /// <param name="model"></param>
        public static User.AddUserR AddUser(User model)
        {
            var r = new User.AddUserR();
            var userSearch = db.User
                .Where(b => b.Name == model.Name);
            if (userSearch.Count() == 0)
            {
                User user = new User();
                user.Name = model.Name;
                user.Pwd = model.Pwd;
                db.User.Add(user);
                int i = db.SaveChanges();
                if (i > 0)
                {
                    r.code = 1;
                    r.message = "数据插入成功";
                }
                else
                {
                    r.code = 0;
                    r.message = "数据插入成功";
                }
            }
            else
            {
                r.code = 0;
                r.message = "手机号已经存在";
            }
            return r;
        }
        public static User queryUser(string name)
        {
            var userSearch = db.User
               .Where(b => b.Name == name);
            if (userSearch.Count() > 0)
            {
                return userSearch.First();
            }
            else
            {
                return null;
            }
        }
    
    }
}
