using System.Runtime.InteropServices;
using System;

namespace System.IO
{
    /// <summary>Specifies whether to search the current directory, or the current directory and all subdirectories. </summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum SearchOption : int
    {
        /// <summary>Includes only the current directory in a search operation.</summary>
        TopDirectoryOnly = 0,
        /// <summary>Includes the current directory and all its subdirectories in a search operation. This option includes reparse points such as mounted drives and symbolic links in the search.</summary>
        AllDirectories = 1
    }
}
