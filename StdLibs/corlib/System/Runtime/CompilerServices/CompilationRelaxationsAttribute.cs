using System;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
    /// <summary>Controls the strictness of the code generated by the common language runtime's just-in-time (JIT) compiler.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Module|AttributeTargets.Class|AttributeTargets.Method)]
    [ComVisibleAttribute(true)]
    public class CompilationRelaxationsAttribute : Attribute
    {
    
        /// <summary>Gets the compilation relaxations specified when the current object was constructed.</summary><returns>The compilation relaxations specified when the current object was constructed.Use the <see cref="T:System.Runtime.CompilerServices.CompilationRelaxations" /> enumeration with the <see cref="P:System.Runtime.CompilerServices.CompilationRelaxationsAttribute.CompilationRelaxations" /> property.</returns>
        public int CompilationRelaxations
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.CompilationRelaxationsAttribute" /> class with the specified compilation relaxations.</summary><param name="relaxations">The compilation relaxations. </param>
        public CompilationRelaxationsAttribute(int relaxations)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.CompilationRelaxationsAttribute" /> class with the specified <see cref="T:System.Runtime.CompilerServices.CompilationRelaxations" /> value. </summary><param name="relaxations">One of the <see cref="T:System.Runtime.CompilerServices.CompilationRelaxations" /> values.</param>
        public CompilationRelaxationsAttribute(CompilationRelaxations relaxations)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
