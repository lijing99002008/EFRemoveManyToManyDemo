using EFRemoveManyToManyDemo_ljy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EFRemoveManyToManyDemo_ljy
{
    class Program
    {
        #region 程序入口

        static void Main(string[] args)
        {
            //Update();
            Add();
            RemoveManyToMany();
            //Remove();      
            Query();
            Console.ReadKey();
        }

        #endregion

        #region 查询数据

        static void Query()
        {
            using (var cxt = new ManyToManyRemoveContext())
            {
                var users = cxt.Users.ToList();
                users.ForEach(x =>
                {
                    Console.WriteLine("User First Name:{0},Last Name:{1},Create On:{2}\n |__Roles:{3}", x.FirstName, x.LastName, x.CreatedOn, string.Join(",", x.Roles.Select(r => r.Name)));
                });
            }
        }

        #endregion

        #region 更新数据

        static void Update()
        {
            using (var cxt = new ManyToManyRemoveContext())
            {
                var user = cxt.Users.FirstOrDefault(x => x.Id == 3);
                if (user != null)
                {
                    user.FirstName = "ShuHao";
                    cxt.SaveChanges();
                }

            }
        }

        #endregion

        #region 删除数据

        static void Remove()
        {
            using (var cxt = new ManyToManyRemoveContext())
            {
                var user = cxt.Users.FirstOrDefault(x => x.Id == 2);
                if (user != null)
                {
                    cxt.Users.Remove(user);
                    cxt.SaveChanges();
                }

            }
        }

        #endregion

        #region 增加数据
        static void Add()
        {
            List<Role> roles;
            using (var cxt = new ManyToManyRemoveContext())
            {
                roles = cxt.Roles.ToList();
                cxt.Users.Add(new User
                {
                    Id = 4,
                    FirstName = "Console",
                    LastName = "App",
                    CreatedOn = DateTime.Now,
                    Roles = roles.Where(x => x.Id == 1).ToList()
                });
                cxt.SaveChanges();
            }
        }
        #endregion

        #region 删除多对多数据

        static void RemoveManyToMany()
        {
            using (var cxt = new ManyToManyRemoveContext())
            {
                var user = cxt.Users.FirstOrDefault(x => x.Id == 1);
                var roles = new List<Role>();
                roles.AddRange(user.Roles.Select(x => x));
                foreach (var role in roles)
                {
                    user.Roles.Remove(role);
                }
                cxt.Users.Remove(user);
                cxt.SaveChanges();
            }
        }

        #endregion

    }
}
