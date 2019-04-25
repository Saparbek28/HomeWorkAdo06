using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppContext())
            {
                var security = (from Security in context.Securities
                                select Security).ToList();
                if(security.Count > 0)
                {
                    foreach(var securitys in security)
                    {
                        Console.WriteLine($"Name: {securitys.Name}");
                        Console.WriteLine($"Password: {securitys.Password}");
                        Console.WriteLine($"Come in: {securitys.ComeIn.Hour}:{securitys.ComeIn.Minute}");
                        Console.WriteLine($"Released: {securitys.Released.Hour}:{securitys.Released.Minute}");
                        Console.WriteLine($"Target: {securitys.Target}");
                    }
                }
                else
                {
                    Console.WriteLine("Oops no one here");
                }
            }
            
        }
    }
}
