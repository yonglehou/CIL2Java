using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    /// <summary>Wraps an XML NMTOKEN attribute.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class SoapNmtoken : ISoapXsd
    {
    
        /// <summary>Gets the XML Schema definition language (XSD) of the current SOAP type.</summary><returns>A <see cref="T:System.String" /> that indicates the XSD of the current SOAP type.</returns>
        public static string XsdType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets an XML NMTOKEN attribute.</summary><returns>A <see cref="T:System.String" /> that contains an XML NMTOKEN attribute.</returns>
        public string Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public string GetXsdType()
        {
             throw new NotImplementedException();
        }
        
        
        public SoapNmtoken()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken" /> class with an XML NMTOKEN attribute.</summary><param name="value">A <see cref="T:System.String" /> containing an XML NMTOKEN attribute. </param>
        public SoapNmtoken(string value)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified <see cref="T:System.String" /> into a <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken" /> object.</summary><returns>A <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken" /> object that is obtained from <paramref name="value" />.</returns><param name="value">The String to convert. </param>
        public static SoapNmtoken Parse(string value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
