// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using AutoFixture;
using AutoFixture.Kernel;
using NodaTime;

namespace MicroElements.AutoFixture.NodaTime
{
    /// <summary>
    /// AutoFixture generator for <see cref="Duration"/>.
    /// </summary>
    public class DurationGenerator : ISpecimenBuilder
    {
        /// <inheritdoc/>
        public object Create(object request, ISpecimenContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (!typeof(Duration).Equals(request))
            {
                return new NoSpecimen();
            }

            return Duration.FromHours(context.Create<int>())
                .Plus(Duration.FromSeconds(context.Create<long>()))
                .Plus(Duration.FromMilliseconds(context.Create<long>()));
        }
    }
}
