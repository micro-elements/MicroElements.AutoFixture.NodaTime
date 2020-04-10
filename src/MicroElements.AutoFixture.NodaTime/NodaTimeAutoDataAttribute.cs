// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using AutoFixture;
using AutoFixture.Xunit2;

namespace MicroElements.AutoFixture.NodaTime
{
    /// <summary>
    /// Provides auto-generated data for NodaTime in xUnit.net's Theory attribute.
    /// </summary>
    public sealed class NodaTimeAutoDataAttribute : AutoDataAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodaTimeAutoDataAttribute"/> class.
        /// </summary>
        public NodaTimeAutoDataAttribute()
            : base(() => new Fixture().Customize(new NodaTimeCustomization()))
        {
        }
    }
}
