using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstUser = new User();
            firstUser.Id = 1; //set
            int firstId = firstUser.Id; //get
            Console.WriteLine(firstUser.Id);

            var secondUser = new User
            {
                Id = 2,
                Login = "denizzz9998881"
            };

            firstUser[0] = "Devil666";
            firstUser[1] = "CrazyDevil666";
              
            Console.ReadLine();
        }
    }
}
