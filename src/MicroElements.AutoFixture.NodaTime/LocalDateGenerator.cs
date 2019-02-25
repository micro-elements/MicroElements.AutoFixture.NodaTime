using System;
using AutoFixture.Kernel;
using NodaTime;

namespace MicroElements.AutoFixture.NodaTime
{
    public class LocalDateGenerator : ISpecimenBuilder
    {
        /// <inheritdoc />
        public object Create(object request, ISpecimenContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (!typeof(LocalDate).Equals(request))
                return new NoSpecimen();

            return LocalDate.FromDateTime(DateTime.Today);
        }
    }
}
