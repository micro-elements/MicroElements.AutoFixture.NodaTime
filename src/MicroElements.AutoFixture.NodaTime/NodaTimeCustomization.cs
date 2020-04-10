// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using AutoFixture;

namespace MicroElements.AutoFixture.NodaTime
{
    /// <summary>
    /// AutoFixture customization that enables NodaTime types generation.
    /// </summary>
    public class NodaTimeCustomization : ICustomization
    {
        /// <inheritdoc />
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new LocalDateGenerator());
            fixture.Customizations.Add(new LocalTimeGenerator());
            fixture.Customizations.Add(new LocalDateTimeGenerator());
            fixture.Customizations.Add(new InstantGenerator());
        }
    }
}
