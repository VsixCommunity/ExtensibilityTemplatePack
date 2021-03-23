using System;
using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Task = System.Threading.Tasks.Task;

namespace $rootnamespace$
{
    internal sealed class $commandName$ : BaseCommand<$commandName$>
    {
        public $commandName$() : base(new Guid("$cmdSetGuid$"), $commandIdValue$)
        { }
        
        protected override Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            VsShellUtilities.ShowMessageBox(Package,
                "$safeitemname$ executed",
                "Title of message",
                OLEMSGICON.OLEMSGICON_INFO,
                OLEMSGBUTTON.OLEMSGBUTTON_OKCANCEL,
                OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST
            );

            return Task.CompletedTask;
        }
    }
}
