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
        public string BusinessOwnerName { get; set; }
        public string BusinessPrimaryBreed {get; set;}
        public string BusinessSecondaryBreed { get; set; }

        //Is this the default constructor
        public DogModel(int id, string dogName)
        {
            BusinessDogId = id;
            BusinessDogName = dogName;
        }
    }

    public class DogManager : IDogManager
    {
        private readonly IDogRepository dogRepository;

        public DogManager(IDogRepository dogRepository)
        {
            this.dogRepository = dogRepository;
        }

        public DogModel[] Dogs
        {
            get
            {
                return dogRepository.Dogs
                    .Select(t => new DogModel(t.RepositoryDogId, t.RepositoryDogName))
                    .ToArray();
            }
        }

        public DogModel Dog(int dogId)
        {
            var dogModel = dogRepository.Dog(dogId);
            return new DogModel(dogModel.RepositoryDogId, dogModel.RepositoryDogName);
        }
    }
}
