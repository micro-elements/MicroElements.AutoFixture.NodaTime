// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using AutoFixture.Kernel;
using NodaTime;

namespace MicroElements.AutoFixture.NodaTime
{
    /// <summary>
    /// AutoFixture generator for <see cref="AnnualDate"/>.
    /// </summary>
    public class AnnualDateGenerator : AbstractDateTimeOffsetBasedSpecimenBuilder<AnnualDate>
    {
        /// <inheritdoc/>
        protected override AnnualDate CreateFromDateTimeOffset(DateTimeOffset dateTimeOffset, ISpecimenContext context)
            => new AnnualDate(dateTimeOffset.Month, dateTimeOffset.Day);
    }
}
