using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Text
{
    /// <summary>Represents a UTF-7 encoding of Unicode characters.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class UTF7Encoding : Encoding
    {
    
        public UTF7Encoding()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Text.UTF7Encoding" /> class. A parameter specifies whether to allow optional characters.</summary><param name="allowOptionals">true to specify that optional characters are allowed; otherwise, false. </param>
        public UTF7Encoding(bool allowOptionals)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a value indicating whether the specified object is equal to the current <see cref="T:System.Text.UTF7Encoding" /> object.</summary><returns>true if <paramref name="value" /> is a <see cref="T:System.Text.UTF7Encoding" /> object and is equal to the current <see cref="T:System.Text.UTF7Encoding" /> object; otherwise, false.</returns><param name="value">An object to compare to the current <see cref="T:System.Text.UTF7Encoding" /> object.</param><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public override bool Equals(object value)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the number of bytes produced by encoding a set of characters from the specified character array.</summary><returns>The number of bytes produced by encoding the specified characters.</returns><param name="chars">The character array containing the set of characters to encode. </param><param name="index">The index of the first character to encode. </param><param name="count">The number of characters to encode. </param><exception cref="T:System.ArgumentNullException"><paramref name="chars" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is less than zero.-or- <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="chars" />.-or- The resulting number of bytes is greater than the maximum number that can be returned as an int. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public override int GetByteCount(char[] chars, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the number of bytes produced by encoding the characters in the specified <see cref="T:System.String" /> object.</summary><returns>The number of bytes produced by encoding the specified characters.</returns><param name="s">The <see cref="T:System.String" /> object containing the set of characters to encode. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException">The resulting number of bytes is greater than the maximum number that can be returned as an int. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        [SecuritySafeCriticalAttribute()]
        public override int GetByteCount(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the number of bytes produced by encoding a set of characters starting at the specified character pointer.</summary><returns>The number of bytes produced by encoding the specified characters.</returns><param name="chars">A pointer to the first character to encode. </param><param name="count">The number of characters to encode. </param><exception cref="T:System.ArgumentNullException"><paramref name="chars" /> is null (Nothing in Visual Basic .NET). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> is less than zero.-or- The resulting number of bytes is greater than the maximum number that can be returned as an int. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        [SecurityCriticalAttribute()]
        public unsafe override int GetByteCount(char* chars, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Encodes a set of characters from the specified <see cref="T:System.String" /> into the specified byte array.</summary><returns>The actual number of bytes written into <paramref name="bytes" />.</returns><param name="s">The <see cref="T:System.String" /> containing the set of characters to encode. </param><param name="charIndex">The index of the first character to encode. </param><param name="charCount">The number of characters to encode. </param><param name="bytes">The byte array to contain the resulting sequence of bytes. </param><param name="byteIndex">The index at which to start writing the resulting sequence of bytes. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null (Nothing).-or- <paramref name="bytes" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.-or- <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.-or- <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />. </exception><exception cref="T:System.ArgumentException"><paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Encodes a set of characters from the specified character array into the specified byte array.</summary><returns>The actual number of bytes written into <paramref name="bytes" />.</returns><param name="chars">The character array containing the set of characters to encode. </param><param name="charIndex">The index of the first character to encode. </param><param name="charCount">The number of characters to encode. </param><param name="bytes">The byte array to contain the resulting sequence of bytes. </param><param name="byteIndex">The index at which to start writing the resulting sequence of bytes. </param><exception cref="T:System.ArgumentNullException"><paramref name="chars" /> is null (Nothing).-or- <paramref name="bytes" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.-or- <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.-or- <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />. </exception><exception cref="T:System.ArgumentException"><paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Encodes a set of characters starting at the specified character pointer into a sequence of bytes that are stored starting at the specified byte pointer.</summary><returns>The actual number of bytes written at the location indicated by <paramref name="bytes" />.</returns><param name="chars">A pointer to the first character to encode. </param><param name="charCount">The number of characters to encode. </param><param name="bytes">A pointer to the location at which to start writing the resulting sequence of bytes. </param><param name="byteCount">The maximum number of bytes to write. </param><exception cref="T:System.ArgumentNullException"><paramref name="chars" /> is null (Nothing).-or- <paramref name="bytes" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="charCount" /> or <paramref name="byteCount" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="byteCount" /> is less than the resulting number of bytes. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the number of characters produced by decoding a sequence of bytes from the specified byte array.</summary><returns>The number of characters produced by decoding the specified sequence of bytes.</returns><param name="bytes">The byte array containing the sequence of bytes to decode. </param><param name="index">The index of the first byte to decode. </param><param name="count">The number of bytes to decode. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is less than zero.-or- <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />.-or- The resulting number of characters is greater than the maximum number that can be returned as an int. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public override int GetCharCount(byte[] bytes, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the number of characters produced by decoding a sequence of bytes starting at the specified byte pointer.</summary><returns>The number of characters produced by decoding the specified sequence of bytes.</returns><param name="bytes">A pointer to the first byte to decode. </param><param name="count">The number of bytes to decode. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> is less than zero.-or- The resulting number of characters is greater than the maximum number that can be returned as an int. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public unsafe override int GetCharCount(byte* bytes, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Decodes a sequence of bytes from the specified byte array into the specified character array.</summary><returns>The actual number of characters written into <paramref name="chars" />.</returns><param name="bytes">The byte array containing the sequence of bytes to decode. </param><param name="byteIndex">The index of the first byte to decode. </param><param name="byteCount">The number of bytes to decode. </param><param name="chars">The character array to contain the resulting set of characters. </param><param name="charIndex">The index at which to start writing the resulting set of characters. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null (Nothing).-or- <paramref name="chars" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="byteIndex" /> or <paramref name="byteCount" /> or <paramref name="charIndex" /> is less than zero.-or- <paramref name="byteindex" /> and <paramref name="byteCount" /> do not denote a valid range in <paramref name="bytes" />.-or- <paramref name="charIndex" /> is not a valid index in <paramref name="chars" />. </exception><exception cref="T:System.ArgumentException"><paramref name="chars" /> does not have enough capacity from <paramref name="charIndex" /> to the end of the array to accommodate the resulting characters. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Decodes a sequence of bytes starting at the specified byte pointer into a set of characters that are stored starting at the specified character pointer.</summary><returns>The actual number of characters written at the location indicated by <paramref name="chars" />.</returns><param name="bytes">A pointer to the first byte to decode. </param><param name="byteCount">The number of bytes to decode. </param><param name="chars">A pointer to the location at which to start writing the resulting set of characters. </param><param name="charCount">The maximum number of characters to write. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null (Nothing).-or- <paramref name="chars" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="byteCount" /> or <paramref name="charCount" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="charCount" /> is less than the resulting number of characters. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        [SecurityCriticalAttribute()]
        public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Decodes a range of bytes from a byte array into a string.</summary><returns>A <see cref="T:System.String" /> containing the results of decoding the specified sequence of bytes.</returns><param name="bytes">The byte array containing the sequence of bytes to decode. </param><param name="index">The index of the first byte to decode. </param><param name="count">The number of bytes to decode. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is less than zero.-or- <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public override string GetString(byte[] bytes, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public override Decoder GetDecoder()
        {
             throw new NotImplementedException();
        }
        
        
        public override Encoder GetEncoder()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the maximum number of bytes produced by encoding the specified number of characters.</summary><returns>The maximum number of bytes produced by encoding the specified number of characters.</returns><param name="charCount">The number of characters to encode. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="charCount" /> is less than zero.-or- The resulting number of bytes is greater than the maximum number that can be returned as an int. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public override int GetMaxByteCount(int charCount)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the maximum number of characters produced by decoding the specified number of bytes.</summary><returns>The maximum number of characters produced by decoding the specified number of bytes.</returns><param name="byteCount">The number of bytes to decode. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="byteCount" /> is less than zero.-or- The resulting number of characters is greater than the maximum number that can be returned as an int. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public override int GetMaxCharCount(int byteCount)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
