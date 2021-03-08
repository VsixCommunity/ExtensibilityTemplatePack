using System.ComponentModel.Design;
using Microsoft;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Task = System.Threading.Tasks.Task;

namespace $rootnamespace$
{
    internal sealed class $commandName$
    {
        public static async Task InitializeAsync(AsyncPackage package)
        {
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

            IMenuCommandService commandService = await package.GetServiceAsync<IMenuCommandService, IMenuCommandService>();
            Assumes.Present(commandService);

            var cmdId = new CommandID(guid, id); // Replace guid and id with valid values
            var menuItem = new OleMenuCommand((s, e) => Execute(package), cmdId);

            commandService.AddCommand(menuItem);
        }

        // %ifnot% $toolWindow$
        public static void Execute(AsyncPackage package)
        {
            VsShellUtilities.ShowMessageBox(package,
                "$safeitemname$ executed",
                "Title of message",
                OLEMSGICON.OLEMSGICON_INFO,
                OLEMSGBUTTON.OLEMSGBUTTON_OKCANCEL,
                OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST
            );
        }
        // %endif%
        // %if% $toolWindow$
        private void Execute(object sender, EventArgs e)
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            ToolWindowPane window = this.package.FindToolWindow(typeof($toolWindow$), 0, true);
            if ((null == window) || (null == window.Frame))
            {
                throw new NotSupportedException("Cannot create tool window");
            }

            IVsWindowFrame windowFrame = (IVsWindowFrame)window.Frame;
            Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(windowFrame.Show());
        }
        // %endif%
    }
}
