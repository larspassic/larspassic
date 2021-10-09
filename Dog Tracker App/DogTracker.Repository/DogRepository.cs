using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTracker.Repository
{
    public interface IDogRepository
    {
        DogModel[] Dogs { get; }
        DogModel Dog(int dogId);
    }

    //Define the dog object in the repository
    public class DogModel
    {
        public int RepositoryDogId { get; set; }
        public string RepositoryDogName { get; set; }
        public string RepositoryOwnerName { get; set; }
        public string RepositoryPrimaryBreed { get; set; }
        public string RepositorySecondaryBreed { get; set; }

    }
    
    public class DogRepository : IDogRepository
    {
        public DogModel[] Dogs
        {
            get
            {
                return DatabaseAccessor.Instance
                    .Dog
                    .Select(t => new DogModel
                    {
                        RepositoryDogId = t.DogId,
                        RepositoryDogName = t.DogName,
                        RepositoryOwnerName = t.OwnerName,
                        RepositoryPrimaryBreed = t.PrimaryBreed,
                        RepositorySecondaryBreed = t.SecondaryBreed,
                    }).ToArray();
            }
        }

        public DogModel Dog(int dogId)
        {
            var dog = DatabaseAccessor.Instance
                .Dog
                .Where(t => t.DogId == dogId)
                .Select(t => new DogModel { RepositoryDogId = t.DogId, RepositoryDogName = t.DogName, RepositoryOwnerName = t.OwnerName, RepositoryPrimaryBreed = t.PrimaryBreed, RepositorySecondaryBreed = t.SecondaryBreed })
                .First();

            return dog;
        }
    }
}
