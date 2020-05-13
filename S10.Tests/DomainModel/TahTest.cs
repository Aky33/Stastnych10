using S10.DomainModel.Models;
using S10.Tests.Utils;
using S10.Tests.Utils.Attributes;
using Xunit;

namespace S10.Tests.DomainModel
{
    public class TahTest
    {
        [Theory]
        [AutoDataDryIoc]
        public void TahEquals(Tah expected) //TODO rozšířit testy
        {
            var actual = DeepCopier.DeepCopy<Tah>(expected);
            Assert.Equal(expected, actual);
        }
    }
}
