// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using AutoFixture.Kernel;
using NodaTime;

namespace MicroElements.AutoFixture.NodaTime
{
    /// <summary>
    /// AutoFixture generator for <see cref="Instant"/>.
    /// </summary>
    public class InstantGenerator : AbstractDateTimeOffsetBasedSpecimenBuilder<Instant>
    {
        /// <inheritdoc/>
        protected override Instant CreateFromDateTimeOffset(DateTimeOffset dateTimeOffset, ISpecimenContext context)
            => Instant.FromDateTimeOffset(dateTimeOffset);
    }
}
