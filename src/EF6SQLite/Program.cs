using System;
using System.Linq;

namespace EF6SQLite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var dbContext = new SQLiteDbContext())
            {
                if (dbContext.Users.Any())
                {
                    Console.WriteLine("Users:{0}", dbContext.Users.Count());
                    foreach (var user in dbContext.Users)
                    {
                        Console.WriteLine("\tUser:{0} Photos:{1}", user.Username, user.Photos.Count);
                        if (user.Photos.Any())
                        {
                            foreach (var photo in user.Photos)
                            {
                                Console.WriteLine("\t\tPhoto:{0}", photo.Name);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Done !");
            Console.ReadLine();
        }
    }
}