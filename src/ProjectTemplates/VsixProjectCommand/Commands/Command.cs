using System;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Task = System.Threading.Tasks.Task;

namespace $safeprojectname$
{
    internal sealed class MyCommand : BaseCommand<MyToolWindowCommand>
{
        public MyToolWindowCommand() : base(new Guid("$guid4$"), 0x0100)
        { }

        public static void Execute(AsyncPackage package)
        {
            VsShellUtilities.ShowMessageBox(package,
                "MyCommand executed",
                "Title of message",
                OLEMSGICON.OLEMSGICON_INFO,
                OLEMSGBUTTON.OLEMSGBUTTON_OKCANCEL,
                OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST
            );
        }
    }
}
