// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using AutoFixture.Kernel;
using NodaTime;

namespace MicroElements.AutoFixture.NodaTime
{
    /// <summary>
    /// AutoFixture generator for <see cref="Interval"/>.
    /// </summary>
    public class IntervalGenerator : ISpecimenBuilder
    {
        /// <inheritdoc/>
        public object Create(object request, ISpecimenContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (!typeof(Interval).Equals(request))
            {
                return new NoSpecimen();
            }

            var instantBuilder = new InstantGenerator();
            var instant1 = (Instant)instantBuilder.Create(typeof(Instant), context);
            var instant2 = (Instant)instantBuilder.Create(typeof(Instant), context);

            if (instant2 >= instant1)
            {
                return new Interval(instant1, instant2);
            }

            return new Interval(instant2, instant1);
        }
    }
}
