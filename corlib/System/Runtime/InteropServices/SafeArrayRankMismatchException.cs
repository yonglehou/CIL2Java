using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
    /// <summary>The exception thrown when the rank of an incoming SAFEARRAY does not match the rank specified in the managed signature.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class SafeArrayRankMismatchException : SystemException
    {
        public SafeArrayRankMismatchException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the SafeArrayRankMismatchException class with the specified message.</summary><param name="message">The message that indicates the reason for the exception. </param>
        public SafeArrayRankMismatchException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.SafeArrayRankMismatchException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public SafeArrayRankMismatchException(string message, Exception inner)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the SafeArrayTypeMismatchException class from serialization data.</summary><param name="info">The object that holds the serialized object data. </param><param name="context">The contextual information about the source or destination. </param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception>
        protected SafeArrayRankMismatchException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
