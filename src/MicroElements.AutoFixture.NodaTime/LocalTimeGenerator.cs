// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using AutoFixture.Kernel;
using NodaTime;

namespace MicroElements.AutoFixture.NodaTime
{
    /// <summary>
    /// AutoFixture generator for <see cref="LocalTime"/>.
    /// </summary>
    public class LocalTimeGenerator : AbstractDateTimeOffsetBasedSpecimenBuilder<LocalTime>
    {
        /// <inheritdoc/>
        protected override LocalTime CreateFromDateTimeOffset(DateTimeOffset dateTimeOffset, ISpecimenContext context)
            => LocalTime.FromTicksSinceMidnight(dateTimeOffset.TimeOfDay.Ticks);
    }
}
