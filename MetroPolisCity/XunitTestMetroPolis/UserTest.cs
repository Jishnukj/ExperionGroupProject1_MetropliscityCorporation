using Autofac.Extras.Moq;
using MetroPolisBusinessService;
using MetroPolisDataService.Entities;
using MetroPolisDataService.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XunitTestMetroPolis
{
    public class UserTest
    {
        [Fact]
        public void GetallUserValid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IUserRepo>()
                    .Setup(x => x.GetAllUsers())
                    .Returns(GetSamples());
                var cls = mock.Create<UserService>();
                var expected = GetSamples();
                var actual = cls.GetUsers();
                Assert.Equal(expected.Count, actual.Count);
            }
        }

        [Fact]
        public void GetUserValid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                int id = 5;
                mock.Mock<IUserRepo>()
                    .Setup(x => x.GetUser(id))
                    .Returns(GetSamples().Where(e => e.UserId == id).FirstOrDefault());
                var cls = mock.Create<UserService>();
                var expected = GetSamples().Where(e => e.UserId == id).FirstOrDefault();
                var actual = cls.GetUser(id);
            }
        }
        private List<User> GetSamples()
        {
            List<User> output = new List<User>
            {
                new User
                {
                    UserId=101,
                    UserName="alpha",
                    Password="alpha@123"
                },
                new User
                {

                    UserId=102,
                    UserName="beta",
                    Password="beta@123"

                },


            };
            return output;

        }
    }
}

