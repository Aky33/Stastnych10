using S10.DataAccessLayer.Interfaces;
using S10.DomainModel.Models;
using S10.Tests.Utils.Attributes;
using Xunit;

namespace S10.Tests.DataAccessLayer
{
    public class TahDaoTest
    {
        [Theory]
        [AutoDataDryIoc]
        public void UlozTah(Tah expected, ITahDao tahDao)
        {
            tahDao.Uloz(expected);

            var actual = tahDao.DejPodleId(expected.Id.Value);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [AutoDataDryIoc]
        public void DejVsechno(Tah expected, ITahDao tahDao)
        {
            tahDao.Uloz(expected);

            var actual = tahDao.DejVsechny();
            Assert.Contains(expected, actual);
        }
        
        [Theory]
        [AutoDataDryIoc]
        public void SmazPodleId(Tah expected, ITahDao tahDao)
        {
            tahDao.Uloz(expected);

            var actual = tahDao.SmazPodleId(expected.Id.Value);
            Assert.False(actual < 1);
        }
    }
}
