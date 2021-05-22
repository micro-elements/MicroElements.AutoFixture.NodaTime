// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using AutoFixture.Kernel;
using NodaTime;

namespace MicroElements.AutoFixture.NodaTime
{
    /// <summary>
    /// AutoFixture generator for <see cref="OffsetDate"/>.
    /// </summary>
    public class OffsetDateGenerator : AbstractDateTimeOffsetBasedSpecimenBuilder<OffsetDate>
    {
        /// <inheritdoc/>
        protected override OffsetDate CreateFromDateTimeOffset(DateTimeOffset dateTimeOffset, ISpecimenContext context)
            => OffsetDateTime.FromDateTimeOffset(dateTimeOffset).ToOffsetDate();
    }
}
