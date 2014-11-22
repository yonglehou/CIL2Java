
namespace System.Globalization
{
    /// <summary>Supports the use of non-ASCII characters for Internet domain names. This class cannot be inherited.</summary>
    public sealed class IdnMapping
    {
    
        /// <summary>Gets or sets a value that indicates whether unassigned Unicode code points are used in operations performed by members of the current <see cref="T:System.Globalization.IdnMapping" /> object.</summary><returns>true if unassigned code points are used in operations; otherwise, false.</returns>
        public bool AllowUnassigned
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that indicates whether standard or relaxed naming conventions are used in operations performed by members of the current <see cref="T:System.Globalization.IdnMapping" /> object.</summary><returns>true if standard naming conventions are used in operations; otherwise, false.</returns>
        public bool UseStd3AsciiRules
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public IdnMapping()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Encodes a string of domain name labels that consist of Unicode characters to a string of displayable Unicode characters in the US-ASCII character range. The string is formatted according to the IDNA standard.</summary><returns>The equivalent of the string specified by the <paramref name="unicode" /> parameter, consisting of displayable Unicode characters in the US-ASCII character range (U+0020 to U+007E) and formatted according to the IDNA standard.</returns><param name="unicode">The string to convert, which consists of one or more domain name labels delimited with label separators.</param><exception cref="T:System.ArgumentNullException"><paramref name="unicode" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="unicode" /> is invalid based on the <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> and <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" /> properties, and the IDNA standard.</exception>
        public string GetAscii(string unicode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Encodes a substring of domain name labels that include Unicode characters outside the US-ASCII character range. The substring is converted to a string of displayable Unicode characters in the US-ASCII character range and is formatted according to the IDNA standard.  </summary><returns>The equivalent of the substring specified by the <paramref name="unicode" /> and <paramref name="index" /> parameters, consisting of displayable Unicode characters in the US-ASCII character range (U+0020 to U+007E) and formatted according to the IDNA standard.</returns><param name="unicode">The string to convert, which consists of one or more domain name labels delimited with label separators.</param><param name="index">A zero-based offset into <paramref name="unicode" /> that specifies the start of the substring to convert. The conversion operation continues to the end of the <paramref name="unicode" /> string.</param><exception cref="T:System.ArgumentNullException"><paramref name="unicode" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or-<paramref name="index" /> is greater than the length of <paramref name="unicode" />.</exception><exception cref="T:System.ArgumentException"><paramref name="unicode" /> is invalid based on the <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> and <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" /> properties, and the IDNA standard.</exception>
        public string GetAscii(string unicode, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Encodes the specified number of characters in a  substring of domain name labels that include Unicode characters outside the US-ASCII character range. The substring is converted to a string of displayable Unicode characters in the US-ASCII character range and is formatted according to the IDNA standard. </summary><returns>The equivalent of the substring specified by the <paramref name="unicode" />, <paramref name="index" />, and <paramref name="count" /> parameters, consisting of displayable Unicode characters in the US-ASCII character range (U+0020 to U+007E) and formatted according to the IDNA standard.</returns><param name="unicode">The string to convert, which consists of one or more domain name labels delimited with label separators.</param><param name="index">A zero-based offset into <paramref name="unicode" /> that specifies the start of the substring.</param><param name="count">The number of characters to convert in the substring that starts at the position specified by  <paramref name="index" /> in the <paramref name="unicode" /> string. </param><exception cref="T:System.ArgumentNullException"><paramref name="unicode" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is less than zero.-or-<paramref name="index" /> is greater than the length of <paramref name="unicode" />.-or-<paramref name="index" /> is greater than the length of <paramref name="unicode" /> minus <paramref name="count" />.</exception><exception cref="T:System.ArgumentException"><paramref name="unicode" /> is invalid based on the <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> and <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" /> properties, and the IDNA standard.</exception>
        public string GetAscii(string unicode, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Decodes a string of one or more domain name labels, encoded according to the IDNA standard, to a string of Unicode characters. </summary><returns>The Unicode equivalent of the IDNA substring specified by the <paramref name="ascii" /> parameter.</returns><param name="ascii">The string to decode, which consists of one or more labels in the US-ASCII character range (U+0020 to U+007E) encoded according to the IDNA standard. </param><exception cref="T:System.ArgumentNullException"><paramref name="ascii" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="ascii" /> is invalid based on the <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> and <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" /> properties, and the IDNA standard.</exception>
        public string GetUnicode(string ascii)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Decodes a substring of one or more domain name labels, encoded according to the IDNA standard, to a string of Unicode characters. </summary><returns>The Unicode equivalent of the IDNA substring specified by the <paramref name="ascii" /> and <paramref name="index" /> parameters.</returns><param name="ascii">The string to decode, which consists of one or more labels in the US-ASCII character range (U+0020 to U+007E) encoded according to the IDNA standard. </param><param name="index">A zero-based offset into <paramref name="ascii" /> that specifies the start of the substring to decode. The decoding operation continues to the end of the <paramref name="ascii" /> string.</param><exception cref="T:System.ArgumentNullException"><paramref name="ascii" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or-<paramref name="index" /> is greater than the length of <paramref name="ascii" />.</exception><exception cref="T:System.ArgumentException"><paramref name="ascii" /> is invalid based on the <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> and <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" /> properties, and the IDNA standard.</exception>
        public string GetUnicode(string ascii, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Decodes a substring of a specified length that contains one or more domain name labels, encoded according to the IDNA standard, to a string of Unicode characters. </summary><returns>The Unicode equivalent of the IDNA substring specified by the <paramref name="ascii" />, <paramref name="index" />, and <paramref name="count" /> parameters.</returns><param name="ascii">The string to decode, which consists of one or more labels in the US-ASCII character range (U+0020 to U+007E) encoded according to the IDNA standard. </param><param name="index">A zero-based offset into <paramref name="ascii" /> that specifies the start of the substring. </param><param name="count">The number of characters to convert in the substring that starts at the position specified by <paramref name="index" /> in the <paramref name="ascii" /> string. </param><exception cref="T:System.ArgumentNullException"><paramref name="ascii" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is less than zero.-or-<paramref name="index" /> is greater than the length of <paramref name="ascii" />.-or-<paramref name="index" /> is greater than the length of <paramref name="ascii" /> minus <paramref name="count" />.</exception><exception cref="T:System.ArgumentException"><paramref name="ascii" /> is invalid based on the <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> and <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" /> properties, and the IDNA standard.</exception>
        public string GetUnicode(string ascii, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a specified object and the current <see cref="T:System.Globalization.IdnMapping" /> object are equal.</summary><returns>true if the object specified by the <paramref name="obj" /> parameter is derived from <see cref="T:System.Globalization.IdnMapping" /> and its <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> and <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" /> properties are equal; otherwise, false. </returns><param name="obj">The object to compare to the current object.</param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
