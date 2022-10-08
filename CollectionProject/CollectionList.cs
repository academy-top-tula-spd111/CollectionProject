using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    internal class CollectionList
    {
        static public void Run()
        {
            int[] array = new int[10];
            // Array array = new int[10];

            // Non generic collection ArrayList:

            //ArrayList alist = new ArrayList();
            //alist.Add(1);
            //alist.Add("name");
            //alist.AddRange(array);
            //alist.Add(() => { Console.WriteLine("Hello"); });


            //User user = new User();
            //object obj = user;
            //User? userNew = obj as User;


            // List<int>

            //List<int> list1 = new List<int>(10){ 6, 9, 2, 7, 4 };
            //List<int> list2 = new List<int>(list1) { 6, 7, 8, 9 };
            //List<int> list3 = new List<int>(10);

            //int[] arrcopy = list1.ToArray();

            //Console.WriteLine(list1.Exists(x => x % 2 == 0));
            //Console.WriteLine(list1.Find(x => x % 2 == 0));
            //Console.WriteLine(list1.FindLast(x => x % 2 == 0));
            //var listRes1 = list1.FindAll(x => x % 2 == 0);
            //foreach(var item in listRes1) Console.Write($"{item} ");



            List<User> users = new List<User>()
            {
                new User(){ Name = "Bob", Age = 34 },
                new User(){ Name = "Tom", Age = 22 },
                new User(){ Name = "Joe", Age = 19 },
                new User(){ Name = "Sam", Age = 41 },
                new User(){ Name = "Tim", Age = 38 },
                new User(){ Name = "Jim", Age = 25 },
            };

            foreach (var user in users) Console.WriteLine(user);
            Console.WriteLine("--------------");

            Console.WriteLine(users.Exists(u => u.Age < 16));
            User? userFind = users.Find(u => u.Age < 20);
            Console.WriteLine(userFind);
            Console.WriteLine("--------------");

            //users.RemoveAll(u => u.Age % 2 == 0);
            //foreach (var user in users) Console.WriteLine(user);
            //Console.WriteLine("--------------");

            //userFind.Name = "Bill";
            //foreach (var user in users) Console.WriteLine(user);
            //Console.WriteLine("--------------");

            var usersAgeEven = users.FindAll(u => u.Name[0] == 'J');
            foreach (var user in usersAgeEven) Console.WriteLine(user);
            Console.WriteLine("--------------");

            users.Insert(3, new User() { Name = "Leo", Age = 27 });
            foreach (var user in users) Console.WriteLine(user);
            Console.WriteLine("--------------");

            //users.Sort((u1, u2) => u1.Name.CompareTo(u2.Name));
            users.Sort((u1, u2) => u1.Age - u2.Age);
            //foreach (var user in users) Console.WriteLine(user);
            //Console.WriteLine("--------------");

            users.ForEach(u => Console.WriteLine(u));
            Console.WriteLine("--------------");
        }
    }
}
