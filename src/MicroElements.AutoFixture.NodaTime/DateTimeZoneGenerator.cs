// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using AutoFixture.Kernel;
using NodaTime;

namespace MicroElements.AutoFixture.NodaTime
{
    /// <summary>
    /// AutoFixture generator for <see cref="DateTimeZone"/>.
    /// </summary>
    public class DateTimeZoneGenerator : ISpecimenBuilder
    {
        private static IDateTimeZoneProvider dateTimeZoneProvider = DateTimeZoneProviders.Tzdb;

        /// <summary>
        /// Gets or sets the <see cref="IDateTimeZoneProvider"/> used for creating <see cref="DateTimeZone"/> specimens.
        /// </summary>
        public static IDateTimeZoneProvider DateTimeZoneProvider
        {
            get { return dateTimeZoneProvider; }
            set { dateTimeZoneProvider = value ?? throw new ArgumentNullException(nameof(value)); }
        }

        /// <inheritdoc/>
        public object Create(object request, ISpecimenContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (!typeof(DateTimeZone).Equals(request))
            {
                return new NoSpecimen();
            }

            var zones = DateTimeZoneProvider.Ids;

            return DateTimeZoneProvider[zones[new Random().Next(0, zones.Count - 1)]];
        }
    }
}
