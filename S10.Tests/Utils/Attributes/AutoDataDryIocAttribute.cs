using AutoFixture;
using AutoFixture.Xunit2;
using S10.Tests.Utils.Customizations;

namespace S10.Tests.Utils.Attributes
{
    public class AutoDataDryIocAttribute : AutoDataAttribute
    {
        public AutoDataDryIocAttribute() 
            : base(() => new Fixture().Customize(new DryIocCustomization())) 
        { 
        
        }
    }
}
