using System.Collections;
using System.Collections.Generic;

namespace CollectionProject
{
    class User
    {
        public string? Name { set; get; }
        public int Age { set; get; }

        public override string ToString()
        {
            return $"{Name} - {Age}";
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            //CollectionList.Run();

            List<User> users = new List<User>()
            {
                new User(){ Name = "Bob", Age = 34 },
                new User(){ Name = "Tom", Age = 22 },
                new User(){ Name = "Joe", Age = 19 },
                new User(){ Name = "Sam", Age = 41 },
                new User(){ Name = "Tim", Age = 38 },
                new User(){ Name = "Jim", Age = 25 },
                //new User(){ Name = "Sam", Age = 18 },
            };

            //LinkedList
            //LinkedList<User> usersList = new LinkedList<User>(users);

            //Console.WriteLine(usersList.Average(u => u.Age));
            //Console.WriteLine(usersList.Sum(u => u.Age));
            //Console.WriteLine(usersList.Min(u => u.Age));
            //Console.WriteLine(usersList.Max(u => u.Age));


            //Dictonary
            //Dictionary<string, User> usersDict = new Dictionary<string, User>();

            //foreach(var user in users)
            //{
            //    usersDict.TryAdd(user.Name, user);
            //}
            //Console.WriteLine("--------------");
            //foreach (var key in usersDict.Keys)
            //    Console.WriteLine($"{key} => {usersDict[key]}");
            //Console.WriteLine("--------------");
            //foreach (var value in usersDict.Values)
            //    Console.WriteLine(value);
            //Console.WriteLine("--------------");

            //List<string> keys = new List<string>(usersDict.Keys);

            foreach (var value in users)
                Console.WriteLine(value);
            Console.WriteLine("--------------");

            //HashSet<User> usersHash = new HashSet<User>(users);
            //foreach (var value in usersHash)
            //    Console.WriteLine(value);
            //Console.WriteLine("--------------");

            //SortedList<string, User> usersSort = new SortedList<string, User>();
            //foreach (var user in users)
            //{
            //    usersSort.TryAdd(user.Name, user);
            //}
            //foreach (var key in usersSort.Keys)
            //    Console.WriteLine($"{key} => {usersSort[key]}");
            //Console.WriteLine("--------------");


            //Hashtable usersHT = new Hashtable();
            //foreach (var user in users)
            //{
            //    usersHT.Add(user.GetHashCode(), user);
            //}
            //foreach (var key in usersHT.Keys)
            //    Console.WriteLine($"{key} => {usersHT[key]}");
            //Console.WriteLine("--------------");
        }
    }
}