// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using AutoFixture.Kernel;
using NodaTime;

namespace MicroElements.AutoFixture.NodaTime
{
    /// <summary>
    /// AutoFixture generator for <see cref="LocalDateTime"/>.
    /// </summary>
    public class LocalDateTimeGenerator : AbstractDateTimeOffsetBasedSpecimenBuilder<LocalDateTime>
    {
        /// <inheritdoc/>
        protected override LocalDateTime CreateFromDateTimeOffset(DateTimeOffset dateTimeOffset, ISpecimenContext context)
            => LocalDateTime.FromDateTime(dateTimeOffset.DateTime);
    }
}
