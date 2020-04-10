using AutoFixture;

namespace MicroElements.AutoFixture.NodaTime
{
    public class NodaTimeCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new LocalDateGenerator());
            fixture.Customizations.Add(new LocalTimeGenerator());
            fixture.Customizations.Add(new LocalDateTimeGenerator());
            fixture.Customizations.Add(new InstantGenerator());
        }
    }
}
