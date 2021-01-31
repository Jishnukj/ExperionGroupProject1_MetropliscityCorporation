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
    public class StreetTest
    {
        [Fact]
        public void GetallStreetValid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IStreetRepo>()
                    .Setup(x => x.GetAllStreets())
                    .Returns(GetSamples());
                var cls = mock.Create<StreetService>();
                var expected = GetSamples();
                var actual = cls.GetStreets();
                Assert.True(actual != null);
                Assert.Equal(expected.Count, actual.Count);
                Assert.Equal(expected[1].Name, actual[1].Name);
            }
        }

        [Fact]
        public void GetStreetValid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                int id = 23;
                mock.Mock<IStreetRepo>()
                    .Setup(x => x.GetStreet(id))
                    .Returns(GetSamples().Where(e => e.Id == id).FirstOrDefault());
                var cls = mock.Create<StreetService>();
                var expected = GetSamples().Where(e => e.Id == id).FirstOrDefault();
                var actual = cls.GetStreet(id);
                Assert.True(actual != null);
                Assert.Equal(expected.Name, actual.Name);
                
            }
        }
        private List<Street> GetSamples()
        {
            List<Street> output = new List<Street>
            {
                new Street
                {
                    Id=23,
                    Name="mambilly",
                    Location="mambilly"
                },
                new Street
                {
                    
                    Id=213,
                    Name="Thrissur",
                    Location="Thrissur"

                },
               

            };
            return output;

        }




    }
}
