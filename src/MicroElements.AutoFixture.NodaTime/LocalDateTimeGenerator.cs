using System;
using AutoFixture.Kernel;
using NodaTime;

namespace MicroElements.AutoFixture.NodaTime
{
    public class LocalDateTimeGenerator : ISpecimenBuilder
    {
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
