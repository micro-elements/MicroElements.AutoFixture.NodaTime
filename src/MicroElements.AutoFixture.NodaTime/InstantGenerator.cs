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
    public class InstantGenerator : ISpecimenBuilder
    {
        /// <inheritdoc />
        public object Create(object request, ISpecimenContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (!typeof(Instant).Equals(request))
            {
                return new NoSpecimen();
            }

            return Instant.FromDateTimeUtc(DateTime.Now.ToUniversalTime());
        }
    }
}
