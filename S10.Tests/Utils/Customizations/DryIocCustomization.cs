using AutoFixture;
using S10.Tests.Utils.Adapters;
using CompRoot = S10.CompositionRoot;

namespace S10.Tests.Utils.Customizations
{
    public class DryIocCustomization : ICustomization
    {
        private readonly CompRoot.CompositionRoot compositionRoot;

        public DryIocCustomization()
        {
            compositionRoot = new CompRoot.CompositionRoot();
            compositionRoot.Compose();
        }

        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new DryIocAdapter(compositionRoot.Container));
        }
    }
}
