using System;

namespace System.Management.Instrumentation
{
    [AttributeUsageAttribute(AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = false)]
    public sealed class ManagementBindAttribute : ManagementNewInstanceAttribute
    {
    
        public Type Schema
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public ManagementBindAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
