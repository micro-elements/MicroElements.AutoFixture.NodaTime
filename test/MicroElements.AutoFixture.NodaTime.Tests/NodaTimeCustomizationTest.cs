using System;
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

        [Fact]
        public void OffsetDateGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<OffsetDate>()
                .Should().NotBe(default);
        }

        [Fact]
        public void OffsetTimeGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<OffsetTime>()
                .Should().NotBe(default);
        }

        [Fact]
        public void OffsetDateTimeGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<OffsetDateTime>()
                .Should().NotBe(default);
        }

        [Fact]
        public void AnnualDateGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<AnnualDate>()
                .Should().NotBe(default);
        }


        [Fact]
        public void YearMonthGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<YearMonth>()
                .Should().NotBe(default);
        }

        [Fact]
        public void DurationGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<Duration>()
                .Should().NotBe(default);
        }

        [Fact]
        public void PeriodGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<Period>()
                .Should().NotBe(default);
        }

        [Fact]
        public void DateTimeZoneGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<DateTimeZone>()
                .Should().NotBe(default);
        }

        [Fact]
        public void DateIntervalGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<DateInterval>()
                .Should().NotBeNull();
        }

        [Fact]
        public void IntervalGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<Interval>()
                .Should().NotBeNull();
        }

        [Fact]
        public void OffsetGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<Offset>()
                .Should().NotBeNull();
        }

        [Fact]
        public void ZonedDateTimeGenerator()
        {
            new Fixture()
                .Customize(new NodaTimeCustomization())
                .Create<ZonedDateTime>()
                .Should().NotBeNull();
        }
    }
}
