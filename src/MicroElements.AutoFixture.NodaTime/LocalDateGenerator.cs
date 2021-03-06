﻿// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using AutoFixture.Kernel;
using NodaTime;

namespace MicroElements.AutoFixture.NodaTime
{
    /// <summary>
    /// AutoFixture generator for <see cref="LocalDate"/>.
    /// </summary>
    public class LocalDateGenerator : AbstractDateTimeOffsetBasedSpecimenBuilder<LocalDate>
    {
        /// <inheritdoc/>
        protected override LocalDate CreateFromDateTimeOffset(DateTimeOffset dateTimeOffset, ISpecimenContext context)
            => LocalDate.FromDateTime(dateTimeOffset.DateTime);
    }
}
