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
    public class LocalDateTimeGenerator : ISpecimenBuilder
    {
        /// <inheritdoc />
        public object Create(object request, ISpecimenContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (!typeof(LocalDateTime).Equals(request))
            {
                return new NoSpecimen();
            }

            return LocalDateTime.FromDateTime(DateTime.Now);
        }
    }
}
