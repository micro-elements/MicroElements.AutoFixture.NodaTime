using AutoFixture;
using FluentAssertions;
using NodaTime;
using Xunit;

namespace MicroElements.AutoFixture.NodaTime.Tests
{
    public class NodaTimeCustomizationTest
    {
        [Fact]
        public void LocalDateGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<LocalDate>()
                .Should().NotBe(default);
        }

        [Fact]
        public void LocalTimeGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<LocalTime>()
                .Should().NotBe(default);
        }

        [Fact]
        public void LocalDateTimeGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<LocalDateTime>()
                .Should().NotBe(default);
        }
        
        [Fact]
        public void InstantGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<Instant>()
                .Should().NotBe(default);
        }
    }
}
