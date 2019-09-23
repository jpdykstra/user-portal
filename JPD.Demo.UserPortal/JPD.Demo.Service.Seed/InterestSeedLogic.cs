using JPD.Demo.Service.Common.Helpers;
using JPD.Demo.Service.Interfaces;
using JPD.Demo.Service.Entities;
using System;
using System.Collections.Generic;

namespace JPD.Demo.Service.Seed
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

        public Interest Populate(User user)
        {
            var interest = new Interest();

            interest.InterestId = Guid.NewGuid();
            interest.Name = RandomHelper.GetRandomString(GetInterestNames);
            interest.UserId = user.UserId;

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

        public ICollection<Interest> PopulateInterestList(User user, int count)
        {
            int i = 0;
            var interests = new List<Interest>();

            while (i < count)
            {
                interests.Add(Populate(user));
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
                "I am not a big fan of {0}.",
                "I wish I could do more {0}.",
                "I wish I was better at {0}.",
                "{0} is the best.",
                "Let me tell you a story about {0}.",
                "I enjoy {0}.",
            };

            return name;
        }
    }
}
