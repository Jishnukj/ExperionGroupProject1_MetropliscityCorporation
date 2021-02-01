using System;
using Xunit;
using MetroPolisBusinessService;
using MetroPolisDataService;
using Autofac.Extras.Moq;
using MetroPolisDataService.Repo;
using MetroPolisDataService.Entities;
using System.Collections.Generic;
using MetroPolisBusinessService.Dto;
using System.Linq;

namespace XunitTestMetroPolis
{
    public class ActivityTest
    {
        [Fact]
        public void GetallActivityValid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IActivityRepo>()
                    .Setup(x => x.GetAllActivities())
                    .Returns(GetSamples());
                var cls = mock.Create<ActivityService>();
                var expected = GetSamples();
                var actual = cls.GetActivities();
                Assert.True(actual != null);
                Assert.Equal(expected.Count, actual.Count);
                Assert.Equal(expected[1].Name, actual[1].Name);
            }
        }
        [Fact]
        public void GetActivityValid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                int id = 2;
                mock.Mock<IActivityRepo>()
                    .Setup(x => x.GetActivity(id))
                    .Returns(GetSamples().Where(e => e.Id == id).FirstOrDefault());
                var cls = mock.Create<ActivityService>();
                var expected = GetSamples().Where(e => e.Id == id).FirstOrDefault();
                var actual = cls.GetActivity(id);
                Assert.True(actual != null);
                Assert.Equal(expected.StreetName, actual.StreetName);
                Assert.Equal(expected.Name, actual.Name);
            }
        }


       

        private List<Activity> GetSamples()
        {
            List<Activity> output = new List<Activity>
            {
                new Activity
                {
                    Id=1,
                    Date=DateTime.Now,
                    Description="nothing",
                    IsStreetClosed=false,
                    Name="mambilly",
                    StreetId=23,
                    StreetName="mambilly",
                    Type="emergency"
                },
                new Activity
                {
                    Id=2,
                    Date=DateTime.Now,
                    Description="nothing",
                    IsStreetClosed=false,
                    Name="Thrissur",
                    StreetId=213,
                    StreetName="Thrissur",
                    Type="emergency"
                },
                new Activity
                {
                    Id=3,
                    Date=DateTime.Now,
                    Description="nothing",
                    IsStreetClosed=false,
                    Name="kandassankadavu",
                    StreetId=233,
                    StreetName="kandassankadavu",
                    Type="emergency"
                },

            };
            return output;
            
        }
        private Activity activitydemo = new Activity
        {
            Id = 2,
            Date = DateTime.Now,
            Description = "nothing",
            IsStreetClosed = false,
            Name = "vadanapilly",
            StreetId = 23,
            StreetName = "vadanapilly",
            Type = "emergency"
        };
    }
}
