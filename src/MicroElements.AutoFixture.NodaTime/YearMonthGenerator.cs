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
    public class YearMonthGenerator : AbstractDateTimeOffsetBasedSpecimenBuilder<YearMonth>
    {
        /// <inheritdoc/>
        protected override YearMonth CreateFromDateTimeOffset(DateTimeOffset dateTimeOffset, ISpecimenContext context)
            => new YearMonth(dateTimeOffset.Year, dateTimeOffset.Month);
    }
}
