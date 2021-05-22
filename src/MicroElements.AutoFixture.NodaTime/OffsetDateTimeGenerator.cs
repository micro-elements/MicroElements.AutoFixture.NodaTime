// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using AutoFixture.Kernel;
using NodaTime;

namespace MicroElements.AutoFixture.NodaTime
{
    /// <summary>
    /// AutoFixture generator for <see cref="OffsetDateTime"/>.
    /// </summary>
    public class OffsetDateTimeGenerator : AbstractDateTimeOffsetBasedSpecimenBuilder<OffsetDateTime>
    {
        /// <inheritdoc/>
        protected override OffsetDateTime CreateFromDateTimeOffset(DateTimeOffset dateTimeOffset, ISpecimenContext context)
            => OffsetDateTime.FromDateTimeOffset(dateTimeOffset);
    }
}
