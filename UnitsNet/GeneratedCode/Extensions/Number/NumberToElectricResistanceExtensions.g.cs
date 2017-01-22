﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/anjdreas/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyUnit.extra.cs files to add code to generated unit classes.
//     Add Extensions\MyUnitExtensions.cs to decorate unit classes with new behavior.
//     Add Scripts\UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

#if !WINDOWS_UWP
// Extension methods/overloads not supported in Universal Windows Platform (WinRT Components)
namespace UnitsNet.Extensions.NumberToElectricResistance
{
    public static class NumberToElectricResistanceExtensions
    {
        #region Kiloohm

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(double)"/>
        public static ElectricResistance Kiloohms(this int value) => ElectricResistance.FromKiloohms(value);

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(double?)"/>
        public static ElectricResistance? Kiloohms(this int? value) => ElectricResistance.FromKiloohms(value);

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(double)"/>
        public static ElectricResistance Kiloohms(this long value) => ElectricResistance.FromKiloohms(value);

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(double?)"/>
        public static ElectricResistance? Kiloohms(this long? value) => ElectricResistance.FromKiloohms(value);

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(double)"/>
        public static ElectricResistance Kiloohms(this double value) => ElectricResistance.FromKiloohms(value);

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(double?)"/>
        public static ElectricResistance? Kiloohms(this double? value) => ElectricResistance.FromKiloohms(value);

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(double)"/>
        public static ElectricResistance Kiloohms(this float value) => ElectricResistance.FromKiloohms(value);

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(double?)"/>
        public static ElectricResistance? Kiloohms(this float? value) => ElectricResistance.FromKiloohms(value);

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(double)"/>
        public static ElectricResistance Kiloohms(this decimal value) => ElectricResistance.FromKiloohms(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(double?)"/>
        public static ElectricResistance? Kiloohms(this decimal? value) => ElectricResistance.FromKiloohms(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Megaohm

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(double)"/>
        public static ElectricResistance Megaohms(this int value) => ElectricResistance.FromMegaohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(double?)"/>
        public static ElectricResistance? Megaohms(this int? value) => ElectricResistance.FromMegaohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(double)"/>
        public static ElectricResistance Megaohms(this long value) => ElectricResistance.FromMegaohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(double?)"/>
        public static ElectricResistance? Megaohms(this long? value) => ElectricResistance.FromMegaohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(double)"/>
        public static ElectricResistance Megaohms(this double value) => ElectricResistance.FromMegaohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(double?)"/>
        public static ElectricResistance? Megaohms(this double? value) => ElectricResistance.FromMegaohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(double)"/>
        public static ElectricResistance Megaohms(this float value) => ElectricResistance.FromMegaohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(double?)"/>
        public static ElectricResistance? Megaohms(this float? value) => ElectricResistance.FromMegaohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(double)"/>
        public static ElectricResistance Megaohms(this decimal value) => ElectricResistance.FromMegaohms(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(double?)"/>
        public static ElectricResistance? Megaohms(this decimal? value) => ElectricResistance.FromMegaohms(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Ohm

        /// <inheritdoc cref="ElectricResistance.FromOhms(double)"/>
        public static ElectricResistance Ohms(this int value) => ElectricResistance.FromOhms(value);

        /// <inheritdoc cref="ElectricResistance.FromOhms(double?)"/>
        public static ElectricResistance? Ohms(this int? value) => ElectricResistance.FromOhms(value);

        /// <inheritdoc cref="ElectricResistance.FromOhms(double)"/>
        public static ElectricResistance Ohms(this long value) => ElectricResistance.FromOhms(value);

        /// <inheritdoc cref="ElectricResistance.FromOhms(double?)"/>
        public static ElectricResistance? Ohms(this long? value) => ElectricResistance.FromOhms(value);

        /// <inheritdoc cref="ElectricResistance.FromOhms(double)"/>
        public static ElectricResistance Ohms(this double value) => ElectricResistance.FromOhms(value);

        /// <inheritdoc cref="ElectricResistance.FromOhms(double?)"/>
        public static ElectricResistance? Ohms(this double? value) => ElectricResistance.FromOhms(value);

        /// <inheritdoc cref="ElectricResistance.FromOhms(double)"/>
        public static ElectricResistance Ohms(this float value) => ElectricResistance.FromOhms(value);

        /// <inheritdoc cref="ElectricResistance.FromOhms(double?)"/>
        public static ElectricResistance? Ohms(this float? value) => ElectricResistance.FromOhms(value);

        /// <inheritdoc cref="ElectricResistance.FromOhms(double)"/>
        public static ElectricResistance Ohms(this decimal value) => ElectricResistance.FromOhms(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistance.FromOhms(double?)"/>
        public static ElectricResistance? Ohms(this decimal? value) => ElectricResistance.FromOhms(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
