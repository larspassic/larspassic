using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogTracker.DogDatabase;

namespace DogTracker.Repository
{
    public class DatabaseAccessor
    {
        static DatabaseAccessor()
        {
            //This is supposed to be a class/method created by entity framework
            //In the "dog database" project
            Instance = new DogDbContext();
        }

        //This is supposed to be a class/method created by entity framework
        //In the "dog database" project
        public static DogDbContect Instance { get; private set; }
    }
}
