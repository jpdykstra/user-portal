using JPD.Demo.Service.Common.Helpers;
using JPD.Demo.Service.Common.Interfaces;
using JPD.Demo.Service.Entities;
using System;
using System.Collections.Generic;

namespace JPD.Demo.Service.Business
{
    public class InterestSeedLogic : IInterestSeed
    {
        private static InterestSeedLogic instance;

        private InterestSeedLogic() { }

        public static InterestSeedLogic Instance
        {
            get
            {
                if (instance == null) { instance = new InterestSeedLogic(); }

                return instance;
            }
        }

        public Interest Populate()
        {
            var interest = new Interest();

            interest.InterestId = Guid.NewGuid();
            interest.Name = RandomHelper.GetRandomString(GetInterestNames);

            if (interest.Name.Trim().ToLower().Equals("sofware engineering"))
            {
                interest.Description = string.Format("{0} Rocks!", interest.Name);
            }
            else
            {
                interest.Description = RandomHelper.GetRandomFormattedString(GetInterestDescriptions, interest.Name);
            }

            return interest;
        }

        public ICollection<Interest> PopulateInterestList(int count)
        {
            int i = 0;
            var interests = new List<Interest>();

            while (i < count)
            {
                interests.Add(Populate());
                i++;
            }

            return interests;
        }

        private List<string> GetInterestNames()
        {
            var name = new List<string>()
            {
                "Swimming",
                "Skiing",
                "Golf",
                "Traveling",
                "Fishing",
                "Volunteer Work",
                "Painting",
                "Dancing",
                "Reading",
                "Sofware Engineering",
                "Tennis",
                "Bicycling",
                "Hiking",
                "Gardening",
                "Music",
                "Space Exploration",
                "Theater",
                "Caligraphy",
                "Mountain Climbing",
                "Singing Out Loud"
            };

            return name;
        }

        private List<string> GetInterestDescriptions()
        {
            var name = new List<string>()
            {
                "{0} is my favorite thing to do.",
                "I not a big fan of {0}.",
                "I wish I could do more {0}.",
                "I wish I was better at {0}.",
                "{0} is the best.",
                "{0}, nuff said.",
                "I enjoy {0}.",
            };

            return name;
        }
    }
}
