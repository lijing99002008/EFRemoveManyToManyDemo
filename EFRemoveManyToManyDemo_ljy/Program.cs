using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EFRemoveManyToManyDemo_ljy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Update();
            Query();
            Console.ReadKey();
        }
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

        //static void Update()
        //{
        //    using (var cxt = new ManyToManyRemoveContext())
        //    {
        //        var user = cxt.Users.FirstOrDefault(x => x.Id == 3);
        //        user.FirstName = "ShuHao";
        //        cxt.SaveChanges();
        //    }
        //}
    }
}
