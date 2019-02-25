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
                .Should().NotBe(default(LocalDate));
        }

        [Fact]
        public void LocalTimeGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<LocalTime>()
                .Should().NotBe(default(LocalTime));
        }

        [Fact]
        public void LocalDateTimeGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<LocalDateTime>()
                .Should().NotBe(default(LocalDateTime));
        }
    }
}
