using AutoFixture;
using AutoFixture.Xunit2;

namespace MicroElements.AutoFixture.NodaTime
{
    public sealed class NodaTimeAutoDataAttribute : AutoDataAttribute
    {
        public NodaTimeAutoDataAttribute(): base(() => new Fixture().Customize(new NodaTimeCustomization()))
        {
        }
    }
}
