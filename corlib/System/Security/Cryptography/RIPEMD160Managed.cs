using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Cryptography
{
    /// <summary>Computes the <see cref="T:System.Security.Cryptography.RIPEMD160" /> hash for the input data using the managed library. </summary>
    [ComVisibleAttribute(true)]
    public class RIPEMD160Managed : RIPEMD160
    {
    
        public RIPEMD160Managed()
        {
             throw new NotImplementedException();
        }
        
        
        public override void Initialize()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, routes data written to the object into the <see cref="T:System.Security.Cryptography.RIPEMD160" /> hash algorithm for computing the hash.</summary><param name="rgb">The input data. </param><param name="ibStart">The offset into the byte array from which to begin using data. </param><param name="cbSize">The number of bytes in the array to use as data. </param>
        [SecuritySafeCriticalAttribute()]
        protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected override byte[] HashFinal()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
