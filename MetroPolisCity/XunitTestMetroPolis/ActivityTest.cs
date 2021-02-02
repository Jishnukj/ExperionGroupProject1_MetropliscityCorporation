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
using Moq;
using FluentAssertions;

namespace XunitTestMetroPolis
{
    public class ActivityTest
    {
        private Mock<IActivityRepo> mockActivityRepo = new Mock<IActivityRepo>();

        [Fact]
        public void GetallActivity_Valid()
        {
            mockActivityRepo.Setup(x => x.GetAllActivities())
                .Returns(GetSamples());
            var cls = new ActivityService(mockActivityRepo.Object);
            var expected = GetSamples();
            var actual = cls.GetActivities();
            Assert.True(actual != null);
            Assert.Equal(expected.Count, actual.Count);
            Assert.Equal(expected[1].Name, actual[1].Name);
        }
        [Fact]
        public void GetActivity_Valid()
        {
            int id = 2;
            var activityDto = new ActivityDto
            {
                Id = 2,
                Date = DateTime.Now,
                Description = "nothing",
                IsStreetClosed = false,
                Name = "Thrissur",
                StreetId = 213,
                StreetName = "Thrissur",
                Type = "emergency"
            };
            var activity = GetSamples()[id];
            mockActivityRepo.Setup(x => x.GetActivity(It.IsAny<int>()))
                .Returns(activity);
            var cls = new ActivityService(mockActivityRepo.Object);
            var result = cls.GetActivity(id);
            result.Id.Should().Be(activity.Id);
            result.Name.Should().Be(activity.Name);

        }
        [Fact]
        public void Delete_WithValidId_ReturnTrue()
        {
            var activity = new Activity
            {
                Id = 1,
                Date = DateTime.Now
            };
            var deleteResponse = true;
            mockActivityRepo.Setup(x => x.GetActivity(It.IsAny<int>()))
                .Returns(activity);
            mockActivityRepo.Setup(x => x.Delete(It.IsAny<int>()))
                .Returns(deleteResponse);
            var service = new ActivityService(mockActivityRepo.Object);
            //Act
            var result = service.Delete(1);
            //Assert
            result.Should().Be(deleteResponse);

        }
        [Fact]
        public void Delete_WithInvalidId_ReturnFalse()
        {
            var activity = new Activity
            {
                Id = 1,
                Date = DateTime.Now
            };
            var deleteResponse = false;
            mockActivityRepo.Setup(x => x.Delete(It.IsAny<int>()))
                .Returns(deleteResponse);
            var service = new ActivityService(mockActivityRepo.Object);
            //Act
            var result = service.Delete(1);
            //Assert
            result.Should().Be(deleteResponse);

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
