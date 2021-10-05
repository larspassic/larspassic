using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTracker.Repository
{
    public interface ICategoryRepository
    {
        DogModel[] Dogs { get; }
        DogModel Dog(int dogId);
    }

    //Define the dog object in the repository
    public class DogModel
    {
        public int DogId { get; set; }
        public string DogName { get; set; }
        public string OwnerName { get; set; }
        public string PrimaryBreed { get; set; }
        public string SecondaryBreed { get; set; }

    }
    
    public class DogRepository
    {
        public DogModel[] Dogs
        {
            get
            {
                return DatabaseAccessor.Instance
                    .Dog
                    .Select(t => new DogModel
                    {
                        DogId = t.DogId,
                        DogName = t.DogName,
                        OwnerName = t.OwnerName,
                        PrimaryBreed = t.PrimaryBreed,
                        SecondaryBreed = t.SecondaryBreed,
                    }).ToArray();
            }
        }

        public DogModel Dog(int dogId)
        {
            var dog = DatabaseAccessor.Instance
                .Dog
                .Where(t => t.DogId == dogId)
                .Select(t => new DogModel { DogId = t.DogId, DogName = t.DogName, OwnerName = t.OwnerName, PrimaryBreed = t.PrimaryBreed, SecondaryBreed = t.SecondaryBreed })
                .First();

            return dog;
        }
    }
}
