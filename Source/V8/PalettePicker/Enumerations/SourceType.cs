﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SourceType.cs" company="Vizioz Limited">
//   Copyright Vizioz Limited
// </copyright>
// <summary>
//   Defines the SourceType type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace Vizioz.PalettePicker.Enumerations
{
    /// <summary>
    /// The source type.
    /// </summary>
    internal enum SourceType
    {
        /// <summary>
        /// The xml.
        /// </summary>
        [Display(Name = "xml")]
        Xml
    }
}
