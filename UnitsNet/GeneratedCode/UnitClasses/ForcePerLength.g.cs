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
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
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
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// Windows Runtime Component does not support CultureInfo type, so use culture name string instead for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
using Culture = System.String;
#else
using Culture = System.IFormatProvider;
#endif

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     The magnitude of force per unit length.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class ForcePerLength
#else
    public partial struct ForcePerLength : IComparable, IComparable<ForcePerLength>
#endif
    {
        /// <summary>
        ///     Base unit of ForcePerLength.
        /// </summary>
        private readonly double _newtonsPerMeter;

		// Windows Runtime Component requires a default constructor
#if WINDOWS_UWP
        public ForcePerLength() : this(0)
        {
        }
#endif

        public ForcePerLength(double newtonspermeter)
        {
            _newtonsPerMeter = Convert.ToDouble(newtonspermeter);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        private
#else
        public
#endif
        ForcePerLength(long newtonspermeter)
        {
            _newtonsPerMeter = Convert.ToDouble(newtonspermeter);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
#if WINDOWS_UWP
        private
#else
        public
#endif
        ForcePerLength(decimal newtonspermeter)
        {
            _newtonsPerMeter = Convert.ToDouble(newtonspermeter);
        }

        #region Properties

        public static ForcePerLengthUnit BaseUnit
        {
            get { return ForcePerLengthUnit.NewtonPerMeter; }
        }

        /// <summary>
        ///     Get ForcePerLength in CentinewtonsPerMeter.
        /// </summary>
        public double CentinewtonsPerMeter
        {
            get { return (_newtonsPerMeter) / 1e-2d; }
        }

        /// <summary>
        ///     Get ForcePerLength in DecinewtonsPerMeter.
        /// </summary>
        public double DecinewtonsPerMeter
        {
            get { return (_newtonsPerMeter) / 1e-1d; }
        }

        /// <summary>
        ///     Get ForcePerLength in KilogramsForcePerMeter.
        /// </summary>
        public double KilogramsForcePerMeter
        {
            get { return _newtonsPerMeter/9.80665002864; }
        }

        /// <summary>
        ///     Get ForcePerLength in KilonewtonsPerMeter.
        /// </summary>
        public double KilonewtonsPerMeter
        {
            get { return (_newtonsPerMeter) / 1e3d; }
        }

        /// <summary>
        ///     Get ForcePerLength in MicronewtonsPerMeter.
        /// </summary>
        public double MicronewtonsPerMeter
        {
            get { return (_newtonsPerMeter) / 1e-6d; }
        }

        /// <summary>
        ///     Get ForcePerLength in MillinewtonsPerMeter.
        /// </summary>
        public double MillinewtonsPerMeter
        {
            get { return (_newtonsPerMeter) / 1e-3d; }
        }

        /// <summary>
        ///     Get ForcePerLength in NanonewtonsPerMeter.
        /// </summary>
        public double NanonewtonsPerMeter
        {
            get { return (_newtonsPerMeter) / 1e-9d; }
        }

        /// <summary>
        ///     Get ForcePerLength in NewtonsPerMeter.
        /// </summary>
        public double NewtonsPerMeter
        {
            get { return _newtonsPerMeter; }
        }

        #endregion

        #region Static

        public static ForcePerLength Zero
        {
            get { return new ForcePerLength(); }
        }

        /// <summary>
        ///     Get ForcePerLength from CentinewtonsPerMeter.
        /// </summary>
        public static ForcePerLength FromCentinewtonsPerMeter(double centinewtonspermeter)
        {
            return new ForcePerLength((centinewtonspermeter) * 1e-2d);
        }

        /// <summary>
        ///     Get ForcePerLength from DecinewtonsPerMeter.
        /// </summary>
        public static ForcePerLength FromDecinewtonsPerMeter(double decinewtonspermeter)
        {
            return new ForcePerLength((decinewtonspermeter) * 1e-1d);
        }

        /// <summary>
        ///     Get ForcePerLength from KilogramsForcePerMeter.
        /// </summary>
        public static ForcePerLength FromKilogramsForcePerMeter(double kilogramsforcepermeter)
        {
            return new ForcePerLength(kilogramsforcepermeter*9.80665002864);
        }

        /// <summary>
        ///     Get ForcePerLength from KilonewtonsPerMeter.
        /// </summary>
        public static ForcePerLength FromKilonewtonsPerMeter(double kilonewtonspermeter)
        {
            return new ForcePerLength((kilonewtonspermeter) * 1e3d);
        }

        /// <summary>
        ///     Get ForcePerLength from MicronewtonsPerMeter.
        /// </summary>
        public static ForcePerLength FromMicronewtonsPerMeter(double micronewtonspermeter)
        {
            return new ForcePerLength((micronewtonspermeter) * 1e-6d);
        }

        /// <summary>
        ///     Get ForcePerLength from MillinewtonsPerMeter.
        /// </summary>
        public static ForcePerLength FromMillinewtonsPerMeter(double millinewtonspermeter)
        {
            return new ForcePerLength((millinewtonspermeter) * 1e-3d);
        }

        /// <summary>
        ///     Get ForcePerLength from NanonewtonsPerMeter.
        /// </summary>
        public static ForcePerLength FromNanonewtonsPerMeter(double nanonewtonspermeter)
        {
            return new ForcePerLength((nanonewtonspermeter) * 1e-9d);
        }

        /// <summary>
        ///     Get ForcePerLength from NewtonsPerMeter.
        /// </summary>
        public static ForcePerLength FromNewtonsPerMeter(double newtonspermeter)
        {
            return new ForcePerLength(newtonspermeter);
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Get nullable ForcePerLength from nullable CentinewtonsPerMeter.
        /// </summary>
        public static ForcePerLength? FromCentinewtonsPerMeter(double? centinewtonspermeter)
        {
            if (centinewtonspermeter.HasValue)
            {
                return FromCentinewtonsPerMeter(centinewtonspermeter.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ForcePerLength from nullable DecinewtonsPerMeter.
        /// </summary>
        public static ForcePerLength? FromDecinewtonsPerMeter(double? decinewtonspermeter)
        {
            if (decinewtonspermeter.HasValue)
            {
                return FromDecinewtonsPerMeter(decinewtonspermeter.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ForcePerLength from nullable KilogramsForcePerMeter.
        /// </summary>
        public static ForcePerLength? FromKilogramsForcePerMeter(double? kilogramsforcepermeter)
        {
            if (kilogramsforcepermeter.HasValue)
            {
                return FromKilogramsForcePerMeter(kilogramsforcepermeter.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ForcePerLength from nullable KilonewtonsPerMeter.
        /// </summary>
        public static ForcePerLength? FromKilonewtonsPerMeter(double? kilonewtonspermeter)
        {
            if (kilonewtonspermeter.HasValue)
            {
                return FromKilonewtonsPerMeter(kilonewtonspermeter.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ForcePerLength from nullable MicronewtonsPerMeter.
        /// </summary>
        public static ForcePerLength? FromMicronewtonsPerMeter(double? micronewtonspermeter)
        {
            if (micronewtonspermeter.HasValue)
            {
                return FromMicronewtonsPerMeter(micronewtonspermeter.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ForcePerLength from nullable MillinewtonsPerMeter.
        /// </summary>
        public static ForcePerLength? FromMillinewtonsPerMeter(double? millinewtonspermeter)
        {
            if (millinewtonspermeter.HasValue)
            {
                return FromMillinewtonsPerMeter(millinewtonspermeter.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ForcePerLength from nullable NanonewtonsPerMeter.
        /// </summary>
        public static ForcePerLength? FromNanonewtonsPerMeter(double? nanonewtonspermeter)
        {
            if (nanonewtonspermeter.HasValue)
            {
                return FromNanonewtonsPerMeter(nanonewtonspermeter.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ForcePerLength from nullable NewtonsPerMeter.
        /// </summary>
        public static ForcePerLength? FromNewtonsPerMeter(double? newtonspermeter)
        {
            if (newtonspermeter.HasValue)
            {
                return FromNewtonsPerMeter(newtonspermeter.Value);
            }
            else
            {
                return null;
            }
        }

#endif

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ForcePerLengthUnit" /> to <see cref="ForcePerLength" />.
        /// </summary>
        /// <param name="val">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ForcePerLength unit value.</returns>
        public static ForcePerLength From(double val, ForcePerLengthUnit fromUnit)
        {
            switch (fromUnit)
            {
                case ForcePerLengthUnit.CentinewtonPerMeter:
                    return FromCentinewtonsPerMeter(val);
                case ForcePerLengthUnit.DecinewtonPerMeter:
                    return FromDecinewtonsPerMeter(val);
                case ForcePerLengthUnit.KilogramForcePerMeter:
                    return FromKilogramsForcePerMeter(val);
                case ForcePerLengthUnit.KilonewtonPerMeter:
                    return FromKilonewtonsPerMeter(val);
                case ForcePerLengthUnit.MicronewtonPerMeter:
                    return FromMicronewtonsPerMeter(val);
                case ForcePerLengthUnit.MillinewtonPerMeter:
                    return FromMillinewtonsPerMeter(val);
                case ForcePerLengthUnit.NanonewtonPerMeter:
                    return FromNanonewtonsPerMeter(val);
                case ForcePerLengthUnit.NewtonPerMeter:
                    return FromNewtonsPerMeter(val);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ForcePerLengthUnit" /> to <see cref="ForcePerLength" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ForcePerLength unit value.</returns>
        public static ForcePerLength? From(double? value, ForcePerLengthUnit fromUnit)
        {
            if (!value.HasValue)
            {
                return null;
            }
            switch (fromUnit)
            {
                case ForcePerLengthUnit.CentinewtonPerMeter:
                    return FromCentinewtonsPerMeter(value.Value);
                case ForcePerLengthUnit.DecinewtonPerMeter:
                    return FromDecinewtonsPerMeter(value.Value);
                case ForcePerLengthUnit.KilogramForcePerMeter:
                    return FromKilogramsForcePerMeter(value.Value);
                case ForcePerLengthUnit.KilonewtonPerMeter:
                    return FromKilonewtonsPerMeter(value.Value);
                case ForcePerLengthUnit.MicronewtonPerMeter:
                    return FromMicronewtonsPerMeter(value.Value);
                case ForcePerLengthUnit.MillinewtonPerMeter:
                    return FromMillinewtonsPerMeter(value.Value);
                case ForcePerLengthUnit.NanonewtonPerMeter:
                    return FromNanonewtonsPerMeter(value.Value);
                case ForcePerLengthUnit.NewtonPerMeter:
                    return FromNewtonsPerMeter(value.Value);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }
#endif

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(ForcePerLengthUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="culture">Culture to use for localization. Defaults to Thread.CurrentUICulture.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(ForcePerLengthUnit unit, [CanBeNull] Culture culture)
        {
            return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Arithmetic Operators

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static ForcePerLength operator -(ForcePerLength right)
        {
            return new ForcePerLength(-right._newtonsPerMeter);
        }

        public static ForcePerLength operator +(ForcePerLength left, ForcePerLength right)
        {
            return new ForcePerLength(left._newtonsPerMeter + right._newtonsPerMeter);
        }

        public static ForcePerLength operator -(ForcePerLength left, ForcePerLength right)
        {
            return new ForcePerLength(left._newtonsPerMeter - right._newtonsPerMeter);
        }

        public static ForcePerLength operator *(double left, ForcePerLength right)
        {
            return new ForcePerLength(left*right._newtonsPerMeter);
        }

        public static ForcePerLength operator *(ForcePerLength left, double right)
        {
            return new ForcePerLength(left._newtonsPerMeter*(double)right);
        }

        public static ForcePerLength operator /(ForcePerLength left, double right)
        {
            return new ForcePerLength(left._newtonsPerMeter/(double)right);
        }

        public static double operator /(ForcePerLength left, ForcePerLength right)
        {
            return Convert.ToDouble(left._newtonsPerMeter/right._newtonsPerMeter);
        }
#endif

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is ForcePerLength)) throw new ArgumentException("Expected type ForcePerLength.", "obj");
            return CompareTo((ForcePerLength) obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(ForcePerLength other)
        {
            return _newtonsPerMeter.CompareTo(other._newtonsPerMeter);
        }

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static bool operator <=(ForcePerLength left, ForcePerLength right)
        {
            return left._newtonsPerMeter <= right._newtonsPerMeter;
        }

        public static bool operator >=(ForcePerLength left, ForcePerLength right)
        {
            return left._newtonsPerMeter >= right._newtonsPerMeter;
        }

        public static bool operator <(ForcePerLength left, ForcePerLength right)
        {
            return left._newtonsPerMeter < right._newtonsPerMeter;
        }

        public static bool operator >(ForcePerLength left, ForcePerLength right)
        {
            return left._newtonsPerMeter > right._newtonsPerMeter;
        }

        public static bool operator ==(ForcePerLength left, ForcePerLength right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._newtonsPerMeter == right._newtonsPerMeter;
        }

        public static bool operator !=(ForcePerLength left, ForcePerLength right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._newtonsPerMeter != right._newtonsPerMeter;
        }
#endif

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return _newtonsPerMeter.Equals(((ForcePerLength) obj)._newtonsPerMeter);
        }

        public override int GetHashCode()
        {
            return _newtonsPerMeter.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value in new unit if successful, exception otherwise.</returns>
        /// <exception cref="NotImplementedException">If conversion was not successful.</exception>
        public double As(ForcePerLengthUnit unit)
        {
            switch (unit)
            {
                case ForcePerLengthUnit.CentinewtonPerMeter:
                    return CentinewtonsPerMeter;
                case ForcePerLengthUnit.DecinewtonPerMeter:
                    return DecinewtonsPerMeter;
                case ForcePerLengthUnit.KilogramForcePerMeter:
                    return KilogramsForcePerMeter;
                case ForcePerLengthUnit.KilonewtonPerMeter:
                    return KilonewtonsPerMeter;
                case ForcePerLengthUnit.MicronewtonPerMeter:
                    return MicronewtonsPerMeter;
                case ForcePerLengthUnit.MillinewtonPerMeter:
                    return MillinewtonsPerMeter;
                case ForcePerLengthUnit.NanonewtonPerMeter:
                    return NanonewtonsPerMeter;
                case ForcePerLengthUnit.NewtonPerMeter:
                    return NewtonsPerMeter;

                default:
                    throw new NotImplementedException("unit: " + unit);
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static ForcePerLength Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static ForcePerLength Parse(string str, [CanBeNull] Culture culture)
        {
            if (str == null) throw new ArgumentNullException("str");

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            return UnitParser.ParseUnit<ForcePerLengthUnit, ForcePerLength>(str, formatProvider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    ForcePerLengthUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromNewtonsPerMeter(x.NewtonsPerMeter + y.NewtonsPerMeter));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out ForcePerLength result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] Culture culture, out ForcePerLength result)
        {
            try
            {
                result = Parse(str, culture);
                return true;
            }
            catch
            {
                result = default(ForcePerLength);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ForcePerLengthUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ForcePerLengthUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        static ForcePerLengthUnit ParseUnit(string str, IFormatProvider formatProvider = null)
        {
            if (str == null) throw new ArgumentNullException("str");

            var unitSystem = UnitSystem.GetCached(formatProvider);
            var unit = unitSystem.Parse<ForcePerLengthUnit>(str.Trim());

            if (unit == ForcePerLengthUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized ForcePerLengthUnit.");
                newEx.Data["input"] = str;
                newEx.Data["formatprovider"] = formatProvider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is NewtonPerMeter
        /// </summary>
        public static ForcePerLengthUnit ToStringDefaultUnit { get; set; } = ForcePerLengthUnit.NewtonPerMeter;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(ToStringDefaultUnit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(ForcePerLengthUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <returns>String representation.</returns>
        public string ToString(ForcePerLengthUnit unit, [CanBeNull] Culture culture)
        {
            return ToString(unit, culture, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(ForcePerLengthUnit unit, [CanBeNull] Culture culture, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, culture, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(ForcePerLengthUnit unit, [CanBeNull] Culture culture, [NotNull] string format,
            [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, formatProvider, args);
            return string.Format(formatProvider, format, formatArgs);
        }

        /// <summary>
        /// Represents the largest possible value of ForcePerLength
        /// </summary>
        public static ForcePerLength MaxValue
        {
            get
            {
                return new ForcePerLength(double.MaxValue);
            }
        }

        /// <summary>
        /// Represents the smallest possible value of ForcePerLength
        /// </summary>
        public static ForcePerLength MinValue
        {
            get
            {
                return new ForcePerLength(double.MinValue);
            }
        }
    }
}
