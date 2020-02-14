﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaletteColorSet.cs" company="Vizioz Limited">
//   Copyright Vizioz Limited
// </copyright>
// <summary>
//   Defines the PaletteColorSet type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PalettePicker.Core.V7.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The color set.
    /// </summary>
    public class PaletteColorSet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaletteColorSet"/> class.
        /// </summary>
        public PaletteColorSet()
        {
            this.Colors = new List<PaletteColor>();
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the colors.
        /// </summary>
        public IEnumerable<PaletteColor> Colors { get; set; }
    }
}
