using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogTracker.WebSite.Models
{
    public class DogModel
    {
        public int WebSiteDogId { get; set; }
        public string WebSiteDogName { get; set; }
        public string WebSiteOwnerName { get; set; }
        public string WebSitePrimaryBreed { get; set; }
        public string WebSiteSecondaryBreed { get; set; }

        public DogModel(int dogId, string dogName)
        {
            WebSiteDogId = dogId;
            WebSiteDogName = dogName;
        }
    }
}
