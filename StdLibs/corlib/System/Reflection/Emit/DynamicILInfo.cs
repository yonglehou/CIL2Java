using System.Runtime.InteropServices;
using System.Security;
using System;

namespace System.Reflection.Emit
{
    /// <summary>Provides support for alternative ways to generate the Microsoft intermediate language (MSIL) and metadata for a dynamic method, including methods for creating tokens and for inserting the code, exception handling, and local variable signature blobs.</summary>
    [ComVisibleAttribute(true)]
    public class DynamicILInfo
    {
    
        /// <summary>Gets the dynamic method whose body is generated by the current instance.</summary><returns>A <see cref="T:System.Reflection.Emit.DynamicMethod" /> object representing the dynamic method for which the current <see cref="T:System.Reflection.Emit.DynamicILInfo" /> object is generating code.</returns>
        public DynamicMethod DynamicMethod
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Sets the code body of the associated dynamic method.</summary><param name="code">An array that contains the MSIL stream.</param><param name="maxStackSize">The maximum number of items on the operand stack when the method is executing.</param>
        public void SetCode(byte[] code, int maxStackSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the code body of the associated dynamic method.</summary><param name="code">A pointer to a byte array containing the MSIL stream.</param><param name="codeSize">The number of bytes in the MSIL stream.</param><param name="maxStackSize">The maximum number of items on the operand stack when the method is executing.</param><exception cref="T:System.ArgumentNullException"><paramref name="code" /> is null and <paramref name="codeSize" /> is greater than 0. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="codeSize" /> is less than 0.</exception>
        [SecurityCriticalAttribute()]
        public unsafe void SetCode(byte* code, int codeSize, int maxStackSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the exception metadata for the associated dynamic method.</summary><param name="exceptions">An array that contains the exception metadata.</param>
        public void SetExceptions(byte[] exceptions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the exception metadata for the associated dynamic method.</summary><param name="exceptions">A pointer to a byte array containing the exception metadata.</param><param name="exceptionsSize">The number of bytes of exception metadata.</param><exception cref="T:System.ArgumentNullException"><paramref name="exceptions" /> is null and <paramref name="exceptionSize" /> is greater than 0.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="exceptionSize" /> is less than 0.</exception>
        [SecurityCriticalAttribute()]
        public unsafe void SetExceptions(byte* exceptions, int exceptionsSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the local variable signature that describes the layout of local variables for the associated dynamic method.</summary><param name="localSignature">An array that contains the layout of local variables for the associated <see cref="T:System.Reflection.Emit.DynamicMethod" />.</param>
        public void SetLocalSignature(byte[] localSignature)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the local variable signature that describes the layout of local variables for the associated dynamic method.</summary><param name="localSignature">An array that contains the layout of local variables for the associated <see cref="T:System.Reflection.Emit.DynamicMethod" />.</param><param name="signatureSize">The number of bytes in the signature.</param><exception cref="T:System.ArgumentNullException"><paramref name="localSignature" /> is null and <paramref name="signatureSize" /> is greater than 0.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="signatureSize" /> is less than 0.</exception>
        [SecurityCriticalAttribute()]
        public unsafe void SetLocalSignature(byte* localSignature, int signatureSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a token, valid in the scope of the current <see cref="T:System.Reflection.Emit.DynamicILInfo" />, representing a method to be accessed from the associated dynamic method.</summary><returns>A token that can be used as the operand of an MSIL instruction that accesses methods, such as <see cref="F:System.Reflection.Emit.OpCodes.Call" /> or <see cref="F:System.Reflection.Emit.OpCodes.Ldtoken" />, in the scope of the current <see cref="T:System.Reflection.Emit.DynamicILInfo" /> object.</returns><param name="method">The method to be accessed.</param>
        [SecuritySafeCriticalAttribute()]
        public int GetTokenFor(RuntimeMethodHandle method)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a token, valid in the scope of the current <see cref="T:System.Reflection.Emit.DynamicILInfo" />, representing a dynamic method to be called from the associated method.</summary><returns>A token that can be embedded in the MSIL stream for the associated dynamic method, as the target of an MSIL instruction.</returns><param name="method">The dynamic method to call.</param>
        public int GetTokenFor(DynamicMethod method)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a token, valid in the scope of the current <see cref="T:System.Reflection.Emit.DynamicILInfo" />, representing a method on a generic type.</summary><returns>A token that can be used as the operand of an MSIL instruction that accesses methods, such as <see cref="F:System.Reflection.Emit.OpCodes.Call" /> or <see cref="F:System.Reflection.Emit.OpCodes.Ldtoken" />, in the scope of the current <see cref="T:System.Reflection.Emit.DynamicILInfo" /> object.</returns><param name="method">The method.</param><param name="contextType">The generic type the method belongs to.</param>
        public int GetTokenFor(RuntimeMethodHandle method, RuntimeTypeHandle contextType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a token, valid in the scope of the current <see cref="T:System.Reflection.Emit.DynamicILInfo" />, representing a field to be accessed from the associated dynamic method.</summary><returns>A token that can be used as the operand of an MSIL instruction that accesses fields, in the scope of the current <see cref="T:System.Reflection.Emit.DynamicILInfo" /> object.</returns><param name="field">The field to be accessed. </param>
        public int GetTokenFor(RuntimeFieldHandle field)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a token, valid in the scope of the current <see cref="T:System.Reflection.Emit.DynamicILInfo" />, representing a field to be accessed from the associated dynamic method; the field is on the specified generic type.</summary><returns>A token that can be used as the operand of an MSIL instruction that accesses fields in the scope of the current <see cref="T:System.Reflection.Emit.DynamicILInfo" /> object.</returns><param name="field">The field to be accessed.</param><param name="contextType">The generic type the field belongs to.</param>
        public int GetTokenFor(RuntimeFieldHandle field, RuntimeTypeHandle contextType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a token, valid in the scope of the current <see cref="T:System.Reflection.Emit.DynamicILInfo" />, representing a type to be used in the associated dynamic method.</summary><returns>A token that can be used as the operand of an MSIL instruction that requires a type, in the scope of the current <see cref="T:System.Reflection.Emit.DynamicILInfo" /> object.</returns><param name="type">The type to be used.</param>
        public int GetTokenFor(RuntimeTypeHandle type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a token, valid in the scope of the current <see cref="T:System.Reflection.Emit.DynamicILInfo" />, representing a string literal to be used in the associated dynamic method.</summary><returns>A token that can be used as the operand of an MSIL instruction that requires a string, in the scope of the current <see cref="T:System.Reflection.Emit.DynamicILInfo" /> object.</returns><param name="literal">The string to be used.</param>
        public int GetTokenFor(string literal)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a token, valid in the scope of the current <see cref="T:System.Reflection.Emit.DynamicILInfo" />, representing the signature for the associated dynamic method.</summary><returns>A token that can be embedded in the metadata and the MSIL stream for the associated dynamic method.</returns><param name="signature">An array that contains the signature.</param>
        public int GetTokenFor(byte[] signature)
        {
             throw new NotImplementedException();
        }
        
        
    }
}