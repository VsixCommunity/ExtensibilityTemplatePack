using System;
using System.ComponentModel.Design;
using Microsoft;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Task = System.Threading.Tasks.Task;

namespace $safeprojectname$
{
    internal sealed class MyCommand
    {
        public static async Task InitializeAsync(AsyncPackage package)
        {
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

            IMenuCommandService commandService = await package.GetServiceAsync<IMenuCommandService, IMenuCommandService>();
            Assumes.Present(commandService);

            var cmdId = new CommandID(new Guid("$guid4$"), 0x0100);
            var menuItem = new OleMenuCommand((s, e) => Execute(package), cmdId);

            commandService.AddCommand(menuItem);
        }

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
