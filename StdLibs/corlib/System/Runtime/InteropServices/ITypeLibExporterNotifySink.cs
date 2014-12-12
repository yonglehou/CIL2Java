using System.Reflection;

namespace System.Runtime.InteropServices
{
    /// <summary>Provides a callback mechanism for the assembly converter to inform the caller of the status of the conversion, and involve the caller in the conversion process itself.</summary>
    [GuidAttribute("F1C3BF77-C3E4-11d3-88E7-00902754C43A")]
    [ComVisibleAttribute(true)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ITypeLibExporterNotifySink
    {
        /// <summary>Notifies the caller that an event occured during the conversion of an assembly.</summary><param name="eventKind">An <see cref="T:System.Runtime.InteropServices.ExporterEventKind" /> value indicating the type of event. </param><param name="eventCode">Indicates extra information about the event. </param><param name="eventMsg">A message generated by the event. </param>
        void ReportEvent(ExporterEventKind eventKind, int eventCode, string eventMsg);
        
        
        /// <summary>Asks the user to resolve a reference to another assembly.</summary><returns>The type library for <paramref name="assembly" />.</returns><param name="assembly">The assembly to resolve. </param>
        object ResolveRef(Assembly assembly);
        
        
    }
}