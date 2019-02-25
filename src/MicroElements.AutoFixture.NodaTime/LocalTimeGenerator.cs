using System;
using AutoFixture.Kernel;
using NodaTime;

namespace MicroElements.AutoFixture.NodaTime
{
    public class LocalTimeGenerator : ISpecimenBuilder
    {
        /// <inheritdoc />
        public object Create(object request, ISpecimenContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (!typeof(LocalTime).Equals(request))
            {
                return new NoSpecimen();
            }

            return LocalTime.FromTicksSinceMidnight(DateTime.Now.TimeOfDay.Ticks);
        }
    }
}
