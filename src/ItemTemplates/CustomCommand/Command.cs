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
    }
}
