using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace $rootnamespace$
{
    [Guid("$toolWindowGuid$")]
    public class $toolWindow$ : ToolWindowPane
    {
        public $toolWindow$() : base(null)
        {
            Caption = "$rootItemName$";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            Content = new $toolWindowControl$();
        }
    }
}
