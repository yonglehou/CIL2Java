using System.Runtime.InteropServices;
using System.Security;
using System.Globalization;

namespace System
{
    /// <summary>Represents a 64-bit signed integer.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct Int64 : IComparable, IFormattable, IConvertible, IComparable<Int64>, IEquatable<Int64>
    {
        /// <summary>Represents the largest possible value of an Int64. This field is constant.</summary><filterpriority>1</filterpriority>
        public const long MaxValue = 9223372036854775807;
        /// <summary>Represents the smallest possible value of an Int64. This field is constant.</summary><filterpriority>1</filterpriority>
        public const long MinValue = -9223372036854775808;
    
        /// <summary>Compares this instance to a specified object and returns an indication of their relative values.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />.-or- <paramref name="value" /> is null. </returns><param name="value">An object to compare, or null. </param><exception cref="T:System.ArgumentException"><paramref name="value" /> is not an <see cref="T:System.Int64" />. </exception><filterpriority>2</filterpriority>
        public int CompareTo(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares this instance to a specified 64-bit signed integer and returns an indication of their relative values.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />. </returns><param name="value">An integer to compare. </param><filterpriority>2</filterpriority>
        public int CompareTo(long value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is an instance of an <see cref="T:System.Int64" /> and equals the value of this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance. </param><filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified <see cref="T:System.Int64" /> value.</summary><returns>true if <paramref name="obj" /> has the same value as this instance; otherwise, false.</returns><param name="obj">An <see cref="T:System.Int64" /> value to compare to this instance.</param><filterpriority>2</filterpriority>
        public bool Equals(long obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="provider" />.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting information. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public string ToString(IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation, using the specified format.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" />.</returns><param name="format">A numeric format string.</param><exception cref="T:System.FormatException"><paramref name="format" /> is invalid or not supported.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public string ToString(string format)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" /> and <paramref name="provider" />.</returns><param name="format">A numeric format string.</param><param name="provider">An object that supplies culture-specific formatting information about this instance. </param><exception cref="T:System.FormatException"><paramref name="format" /> is invalid or not supported.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public string ToString(string format, IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a number to its 64-bit signed integer equivalent.</summary><returns>A 64-bit signed integer equivalent to the number contained in <paramref name="s" />.</returns><param name="s">A string containing a number to convert. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> is not in the correct format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public static long Parse(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a number in a specified style to its 64-bit signed integer equivalent.</summary><returns>A 64-bit signed integer equivalent to the number specified in <paramref name="s" />.</returns><param name="s">A string containing a number to convert. </param><param name="style">A bitwise combination of <see cref="T:System.Globalization.NumberStyles" /> values that indicates the permitted format of <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception><exception cref="T:System.FormatException"><paramref name="s" /> is not in a format compliant with <paramref name="style" />. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />.-or-<paramref name="style" /> supports fractional digits but <paramref name="s" /> includes non-zero fractional digits. </exception><filterpriority>1</filterpriority>
        public static long Parse(string s, NumberStyles style)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a number in a specified culture-specific format to its 64-bit signed integer equivalent.</summary><returns>A 64-bit signed integer equivalent to the number specified in <paramref name="s" />.</returns><param name="s">A string containing a number to convert. </param><param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> is not in the correct format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public static long Parse(string s, IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a number in a specified style and culture-specific format to its 64-bit signed integer equivalent.</summary><returns>A 64-bit signed integer equivalent to the number specified in <paramref name="s" />.</returns><param name="s">A string containing a number to convert. </param><param name="style">A bitwise combination of enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param><param name="provider">An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting information about <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception><exception cref="T:System.FormatException"><paramref name="s" /> is not in a format compliant with <paramref name="style" />. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />. -or-<paramref name="style" /> supports fractional digits, but <paramref name="s" /> includes non-zero fractional digits.</exception><filterpriority>1</filterpriority>
        public static long Parse(string s, NumberStyles style, IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string s, ref long result)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, ref long result)
        {
             throw new NotImplementedException();
        }
        
        
        public TypeCode GetTypeCode()
        {
             throw new NotImplementedException();
        }



        TypeCode IConvertible.GetTypeCode()
        {
            throw new NotImplementedException();
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }
    }
}
