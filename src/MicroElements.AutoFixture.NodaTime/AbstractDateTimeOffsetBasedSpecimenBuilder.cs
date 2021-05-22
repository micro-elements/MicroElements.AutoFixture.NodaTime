// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using AutoFixture;
using AutoFixture.Kernel;

namespace MicroElements.AutoFixture.NodaTime
{
    /// <summary>
    /// Abstract generic specimen builder, used to provide a DateTimeOffset to derived builders.
    /// </summary>
    /// <typeparam name="T">The type to create.</typeparam>
    public abstract class AbstractDateTimeOffsetBasedSpecimenBuilder<T> : ISpecimenBuilder
    {
        /// <inheritdoc/>
        public object Create(object request, ISpecimenContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (!typeof(T).Equals(request))
            {
                return new NoSpecimen();
            }

            var dateTime = context.Create<DateTimeOffset>();
            return this.CreateFromDateTimeOffset(dateTime, context);
        }

        /// <summary>
        /// Implement to create a T specimen from a DateTimeOffset.
        /// </summary>
        /// <param name="dateTimeOffset">The DateTimeOffset value to use for specimen building.</param>
        /// <returns>The generated value.</returns>
        /// <param name="context">A context that can be used to create other specimens.</param>
        protected abstract T CreateFromDateTimeOffset(DateTimeOffset dateTimeOffset, ISpecimenContext context);
    }
}
