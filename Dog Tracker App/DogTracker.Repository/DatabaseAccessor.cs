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
            Instance = new DogDbContext();
        }


        public static DogDbContect Instance { get; private set; }
    }
}
