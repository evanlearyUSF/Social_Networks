using System;
using System.Collections.Generic;
using System.Linq;

namespace Leary_SocialMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Person 1 Name:");
            string persons = Console.ReadLine();
            Console.WriteLine("Please Enter " + persons + "'s Friends, and enter *** when finished");
            List<string> friends = new List<string>();
            string enterFriend = Console.ReadLine();
            while (enterFriend != "***")
            {
                friends.Add(enterFriend);
                enterFriend = Console.ReadLine();
            }


            Console.WriteLine("Please Enter Person 2 Name:");
            string person2 = Console.ReadLine();
            Console.WriteLine("Please Enter " + person2 + "'s Friends, and enter *** when finished");
            List<string> friends2 = new List<string>();
            string enterFriend2 = Console.ReadLine();
            while (enterFriend2 != "***")
            {
                friends2.Add(enterFriend2);
                enterFriend2 = Console.ReadLine();
            }

            // To make it a case insenstive comparison add second argument to Interesect called StringComparer.OrdinalIgnoreCase
            var commonFriends = friends.Intersect(friends2, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(persons + " and " + person2 + " have " + friends.Intersect(friends2, StringComparer.OrdinalIgnoreCase).Count() + " friends in common. These friends are :");
            foreach (string a in commonFriends)
            {
                Console.WriteLine(a);
            }
            //Console.WriteLine($"{ commonFriends}");




        }
    }
}
