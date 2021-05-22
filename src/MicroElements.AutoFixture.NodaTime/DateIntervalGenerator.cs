// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using AutoFixture.Kernel;
using NodaTime;

namespace MicroElements.AutoFixture.NodaTime
{
    /// <summary>
    /// AutoFixture generator for <see cref="DateInterval"/>.
    /// </summary>
    public class DateIntervalGenerator : ISpecimenBuilder
    {
        /// <inheritdoc/>
        public object Create(object request, ISpecimenContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (!typeof(DateInterval).Equals(request))
            {
                return new NoSpecimen();
            }

            var localDateBuilder = new LocalDateGenerator();
            var periodBuilder = new PeriodGenerator();

            var localDate = (LocalDate)localDateBuilder.Create(typeof(LocalDate), context);
            var period = (Period)periodBuilder.Create(typeof(Period), context);

            return new DateInterval(localDate, localDate.PlusDays(period.Days));
        }
    }
}
