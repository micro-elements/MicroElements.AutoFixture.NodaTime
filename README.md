# MicroElements.AutoFixture.NodaTime
Autogenerating NodaTime types with AutoFixture

## Statuses
[![License](https://img.shields.io/github/license/micro-elements/MicroElements.AutoFixture.NodaTime.svg)](https://raw.githubusercontent.com/micro-elements/MicroElements.AutoFixture.NodaTime/master/LICENSE)
[![NuGetVersion](https://img.shields.io/nuget/v/MicroElements.AutoFixture.NodaTime.svg)](https://www.nuget.org/packages/MicroElements.AutoFixture.NodaTime)
![NuGetDownloads](https://img.shields.io/nuget/dt/MicroElements.AutoFixture.NodaTime.svg)
[![MyGetVersion](https://img.shields.io/myget/micro-elements/v/MicroElements.AutoFixture.NodaTime.svg)](https://www.myget.org/feed/micro-elements/package/nuget/MicroElements.AutoFixture.NodaTime)

[![Travis](https://img.shields.io/travis/micro-elements/MicroElements.AutoFixture.NodaTime/master.svg?logo=travis)](https://travis-ci.org/micro-elements/MicroElements.AutoFixture.NodaTime)

[![Gitter](https://img.shields.io/gitter/room/micro-elements/MicroElements.AutoFixture.NodaTime.svg)](https://gitter.im/micro-elements/MicroElements.AutoFixture.NodaTime)

## Installation

### Package Reference:

```
dotnet add package MicroElements.AutoFixture.NodaTime
```

## Build
Windows: Run `build.ps1`

Linux: Run `build.sh`

## Usage
Add `NodaTimeCustomization` to `Fixture`:

```csharp
var localDate = new Fixture()
    .Customize(new NodaTimeCustomization())
    .Create<LocalDate>();

```

## Supported types
* LocalDate
* LocalTime
* LocalDateTime
* OffsetDate
* OffsetTime
* OffsetDateTime
* YearMonth
* AnnualDate
* DateInterval
* Interval
* Period
* Duration
* DateTimeZone
* ZonedDateTime

## License
This project is licensed under the MIT license. See the [LICENSE] file for more info.


[LICENSE]: https://raw.githubusercontent.com/micro-elements/MicroElements.AutoFixture.NodaTime/master/LICENSE
