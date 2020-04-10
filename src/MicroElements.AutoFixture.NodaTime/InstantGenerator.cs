using System;
using AutoFixture.Kernel;
using NodaTime;

namespace MicroElements.AutoFixture.NodaTime
{
    public class InstantGenerator : ISpecimenBuilder
    {
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
