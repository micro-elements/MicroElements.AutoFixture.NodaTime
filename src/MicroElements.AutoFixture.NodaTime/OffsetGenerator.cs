// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using AutoFixture.Kernel;
using NodaTime;

namespace MicroElements.AutoFixture.NodaTime
{
    /// <summary>
    /// AutoFixture generator for <see cref="Offset"/>.
    /// </summary>
    public class OffsetGenerator : AbstractDateTimeOffsetBasedSpecimenBuilder<Offset>
    {
        /// <inheritdoc/>
        protected override Offset CreateFromDateTimeOffset(DateTimeOffset dateTimeOffset, ISpecimenContext context)
            => Offset.FromTimeSpan(dateTimeOffset.Offset);
    }
}
