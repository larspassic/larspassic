using System;
using System.Linq;
using DogTracker.Repository;

namespace DogTracker.Business
{
    public interface IDogManager
    {
        DogModel[] Dogs { get; }
        DogModel Dog(int dogId);
    }
    
    public class DogModel
    {
        public int BusinessDogId { get; set; }
        public string BusinessDogName { get; set; }

    }

    public class DogManager
    {
    }
}
